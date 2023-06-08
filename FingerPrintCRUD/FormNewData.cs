using FingerPrintGUI;
using MySql.Data.MySqlClient;
using SourceAFIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrintCRUD
{
    public partial class FormNewData : Form
    {
        bool acceptFile = false;
        string fileLocation = "";

        public readonly FormCRUD obj = (FormCRUD)Application.OpenForms["FormCRUD"];

        public FormNewData()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            obj.LoadData();
            this.Close();
        }

        private void FormNewData_Load(object sender, EventArgs e)
        {
            FormCRUD MainForm = new FormCRUD();
            MainForm.ImageValidation();

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

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog chooseFile = new OpenFileDialog();
            chooseFile.Title = "Browse Image File";
            //chooseFile.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.JPG;*.JPEG;*.PNG|All Files(*.*)|*.*";
            chooseFile.Filter = "Image Files|*.jpg;*.jpeg;*.png";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Pictures.path != "")
            {
                var template = new FingerprintTemplate(new FingerprintImage(File.ReadAllBytes(@"" + Pictures.path + "")));
                byte[] serialized = template.ToByteArray();

                var database = new Database();
                try
                {
                    database.connectdb.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into fingerprint(nomor_induk, nama_lengkap, jenis_jari, image_path, template) " +
                        "values (@nomor_induk, @nama_lengkap," +
                        "@jenis_jari, @image_path, @template) ", database.connectdb);
                    cmd.Parameters.AddWithValue("@nomor_induk", txtNomorInduk.Text);
                    cmd.Parameters.AddWithValue("@nama_lengkap", txtNamaLengkap.Text);
                    cmd.Parameters.AddWithValue("@jenis_jari", comboBoxJenisJari.Text);
                    cmd.Parameters.AddWithValue("@image_path", txtPath.Text);
                    cmd.Parameters.AddWithValue("@template", serialized);
                    cmd.ExecuteNonQuery();

                    database.connectdb.Close();
                    MessageBox.Show("Data successfully saved!");

                    ResetInput();

                    obj.LoadData();

                    this.Close();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message.ToString();
                    MessageBox.Show("Cannot connect to Database! \nPlease check your database credentials.", "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //MessageBox.Show("Please select a fingerprint first!");
                MessageBox.Show("Please select a fingerprint first!", "CAUTION!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void ResetInput()
        {
            imgFingerPrint.Image = null;
            imgFingerPrint.Invalidate();

            fileLocation = "";
            Pictures.path = "";
            txtPath.Text = "";

            txtNomorInduk.Text = "";
            txtNamaLengkap.Text = "";
        }

    }
}
