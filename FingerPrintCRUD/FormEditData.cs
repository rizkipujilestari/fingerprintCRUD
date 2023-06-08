using FingerPrintGUI;
using MySql.Data.MySqlClient;
using SourceAFIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrintCRUD
{
    public partial class FormEditData : Form
    {
        string fileLocation = "";

        public readonly FormCRUD obj = (FormCRUD)Application.OpenForms["FormCRUD"];

        public FormEditData()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            obj.LoadData();
            this.Close();
        }

        private void FormEditData_Load(object sender, EventArgs e)
        {
            obj.ImageValidation();

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

        public void nomor_induk(object Value)
        {
            txtNomorInduk.Text = Value.ToString();
        }

        public void nama_lengkap(object Value)
        {
            txtNamaLengkap.Text = Value.ToString();
        }

        public void jenis_jari(object Value)
        {
            comboBoxJenisJari.Text = Value.ToString();
        }

        public void path(object Value)
        {
            txtPath.Text = Value.ToString();

            byte[] data = File.ReadAllBytes(@"" + Value.ToString() + "");
            MemoryStream mem = new MemoryStream(data);
            imgFingerPrint.Image = Image.FromStream(mem);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string imgPath = "";
            if (Pictures.path != "")
            {
                imgPath = Pictures.path;
            }
            else
            {
                imgPath = txtPath.Text;
            }

            var template = new FingerprintTemplate(new FingerprintImage(File.ReadAllBytes(@"" + imgPath + "")));
            byte[] serialized = template.ToByteArray();

            var database = new Database();
            try
            {
                database.connectdb.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE fingerprint set nama_lengkap=@nama_lengkap, jenis_jari=@jenis_jari, " +
                    "image_path=@image_path, template=@template WHERE nomor_induk=@nomor_induk ", database.connectdb);
                cmd.Parameters.AddWithValue("@nomor_induk", txtNomorInduk.Text);
                cmd.Parameters.AddWithValue("@nama_lengkap", txtNamaLengkap.Text);
                cmd.Parameters.AddWithValue("@jenis_jari", comboBoxJenisJari.Text);
                cmd.Parameters.AddWithValue("@image_path", txtPath.Text);
                cmd.Parameters.AddWithValue("@template", serialized);
                cmd.ExecuteNonQuery();

                database.connectdb.Close();

                MessageBox.Show("Data successfully updated!");
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
