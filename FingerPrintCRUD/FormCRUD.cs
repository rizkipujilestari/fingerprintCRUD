using FingerPrintGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using SourceAFIS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.Xml;
using System.Diagnostics;

namespace FingerPrintCRUD
{
    public partial class FormCRUD : Form
    {
        string fileLocation = "";


        public FormCRUD()
        {
            InitializeComponent();
        }

        private void FormNewData_FormClosed()
        {
            MessageBox.Show("Form Closed");
        }

        private void FormCRUD_Load(object sender, EventArgs e)
        {
            fileLocation = Properties.Settings.Default.FileName;
            if (fileLocation != "")
            {
                System.Drawing.Image picture = System.Drawing.Image.FromFile(Properties.Settings.Default.FileName);
            }

            LoadData();
        }

        public void LoadData()
        {
            // dataGridView
            var database = new Database();
            try
            {
                database.connectdb.Open();
                //string query = "SELECT * FROM fingerprint";
                string query = "SELECT nomor_induk, nama_lengkap FROM fingerprint";
                MySqlCommand sql = new MySqlCommand(query);
                sql.Connection = database.connectdb;

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = sql;
                DataTable datatbl = new DataTable();
                adapter.Fill(datatbl);

                BindingSource bindingsrc = new BindingSource();
                bindingsrc.DataSource = datatbl;
                dataGridFingerprint.DataSource = bindingsrc;

                database.connectdb.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot connect to database :" + ex);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Title = "Browse Image File";
            chooseFile.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.JPG;*.JPEG;*.PNG|All Files(*.*)|*.*";
            chooseFile.FilterIndex = 2;
            chooseFile.Multiselect = false;
            chooseFile.RestoreDirectory = true;

            if (chooseFile.ShowDialog() == DialogResult.OK)
            {
                fileLocation = chooseFile.FileName;
            }

            Pictures.path = fileLocation;

            if (Pictures.path != "")
            {
                Properties.Settings.Default.FileName = Pictures.path;
                Properties.Settings.Default.Save();

                System.Drawing.Image picture = System.Drawing.Image.FromFile(Properties.Settings.Default.FileName);
                imgFingerPrint.Image = picture;

                // MessageBox.Show(Pictures.path);
                txtPath.Text = Pictures.path;
            }
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
            var database = new Database();

            try
            {
                database.connectdb.Open();
                MessageBox.Show("Connection success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                database.connectdb.Close();
            }
        }

        private void btnMatchProbe_Click(object sender, EventArgs e)
        {
            if (Pictures.path != "")
            {
                var probe = new FingerprintTemplate(
                    new FingerprintImage(File.ReadAllBytes(@"" + Pictures.path + "")));

                var watch = System.Diagnostics.Stopwatch.StartNew();

                var database = new Database();
                try
                {
                    database.connectdb.Open();

                    string query = "SELECT * FROM fingerprint";
                    MySqlCommand sql = new MySqlCommand(query, database.connectdb);
                    MySqlDataReader reader = sql.ExecuteReader();

                    DataTable datatbl = new DataTable();
                    datatbl.Columns.Add("Nomor Induk", typeof(string));
                    datatbl.Columns.Add("Nama Lengkap", typeof(string));
                    datatbl.Columns.Add("Similarity Score", typeof(int));
                    datatbl.Columns.Add("Matched", typeof(bool));

                    while (reader.Read())
                    {
                        var nomor_induk = reader["nomor_induk"];
                        var nama_lengkap = reader["nama_lengkap"];

                        var candidate = new FingerprintTemplate(
                            new FingerprintImage(File.ReadAllBytes(@"" + reader["image_path"] + "")));

                        var matcher = new FingerprintMatcher(probe);
                        double similarity = matcher.Match(candidate);
                        var score = Math.Round(similarity, 2);

                        double threshold = 40;
                        bool matches = similarity >= threshold;

                        /*// show all with no filter
                        datatbl.Rows.Add(nomor_induk, nama_lengkap, score, matches);*/

                        if (matches == true)
                        {
                            datatbl.Rows.Add(nomor_induk, nama_lengkap, score, matches);
                        }

                    }

                    bool check_found = true;
                    bool contains = datatbl.AsEnumerable().Any(row => check_found == row.Field<bool>("Matched"));

                    if (contains == true)
                    {
                        dataGridFingerprint.DataSource = datatbl;

                    }
                    else
                    {
                        DialogResult confirmAddNew = MessageBox.Show("No matched data found! Add New?", "DATA NOT FOUND", MessageBoxButtons.YesNo);
                        if (confirmAddNew == DialogResult.Yes)
                        {
                            var formAdd = new FormNewData();
                            formAdd.ShowDialog();
                        }
                    }

                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    labelExecTime.Text = elapsedMs.ToString();

                    database.connectdb.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot connect to database : " + ex);
                }

            }
            else
            {
                MessageBox.Show("Please select a fingerprint first!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridFingerprint.DataSource = null;
            dataGridFingerprint.Rows.Clear();
            LoadData();

            imgFingerPrint.Image = null;
            imgFingerPrint.Invalidate();

            fileLocation = "";
            Pictures.path = "";
            txtPath.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var formAdd = new FormNewData();
            formAdd.ShowDialog();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = $"Process {e.ProgressPercentage} %";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Matching complete! ";
        }
    }
}
