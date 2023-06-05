namespace FingerPrintCRUD
{
    partial class FormEditData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            btnScan = new Button();
            imgFingerPrint = new PictureBox();
            txtPath = new TextBox();
            btnChooseFile = new Button();
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            comboBoxJenisJari = new ComboBox();
            label3 = new Label();
            btnUpdate = new Button();
            txtNomorInduk = new TextBox();
            txtNamaLengkap = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFingerPrint).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnScan);
            groupBox2.Controls.Add(imgFingerPrint);
            groupBox2.Controls.Add(txtPath);
            groupBox2.Controls.Add(btnChooseFile);
            groupBox2.Location = new Point(12, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 358);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select Fingerprint";
            // 
            // btnScan
            // 
            btnScan.BackColor = SystemColors.InactiveCaption;
            btnScan.Enabled = false;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnScan.Location = new Point(49, 289);
            btnScan.Margin = new Padding(3, 4, 3, 4);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(155, 51);
            btnScan.TabIndex = 18;
            btnScan.Text = "Scan Fingerprint";
            btnScan.UseVisualStyleBackColor = false;
            // 
            // imgFingerPrint
            // 
            imgFingerPrint.BackColor = Color.White;
            imgFingerPrint.BorderStyle = BorderStyle.FixedSingle;
            imgFingerPrint.Location = new Point(18, 23);
            imgFingerPrint.Margin = new Padding(3, 4, 3, 4);
            imgFingerPrint.Name = "imgFingerPrint";
            imgFingerPrint.Size = new Size(221, 224);
            imgFingerPrint.SizeMode = PictureBoxSizeMode.Zoom;
            imgFingerPrint.TabIndex = 14;
            imgFingerPrint.TabStop = false;
            // 
            // txtPath
            // 
            txtPath.BackColor = Color.White;
            txtPath.BorderStyle = BorderStyle.FixedSingle;
            txtPath.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPath.Location = new Point(124, 246);
            txtPath.Margin = new Padding(3, 4, 3, 4);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(115, 31);
            txtPath.TabIndex = 16;
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = Color.White;
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnChooseFile.Location = new Point(18, 246);
            btnChooseFile.Margin = new Padding(3, 4, 3, 4);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(107, 31);
            btnChooseFile.TabIndex = 15;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(comboBoxJenisJari);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtNomorInduk);
            groupBox1.Controls.Add(txtNamaLengkap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(287, 14);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(382, 357);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Fingerprint";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSteelBlue;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(202, 288);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 51);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboBoxJenisJari
            // 
            comboBoxJenisJari.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJenisJari.FlatStyle = FlatStyle.System;
            comboBoxJenisJari.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxJenisJari.ForeColor = Color.Black;
            comboBoxJenisJari.Items.AddRange(new object[] { "Jempol Kanan", "Telunjuk Kanan", "Tengah Kanan", "Manis Kanan", "Kelingking Kanan", "Jempol Kiri", "Telunjuk Kiri", "Tengah Kiri", "Manis Kiri", "Kelingking Kiri" });
            comboBoxJenisJari.Location = new Point(155, 155);
            comboBoxJenisJari.Margin = new Padding(3, 4, 3, 4);
            comboBoxJenisJari.Name = "comboBoxJenisJari";
            comboBoxJenisJari.Size = new Size(202, 27);
            comboBoxJenisJari.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 159);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 6;
            label3.Text = "Jenis Jari";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSteelBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(23, 288);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 51);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtNomorInduk
            // 
            txtNomorInduk.BorderStyle = BorderStyle.FixedSingle;
            txtNomorInduk.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomorInduk.Location = new Point(155, 53);
            txtNomorInduk.Margin = new Padding(3, 4, 3, 4);
            txtNomorInduk.Name = "txtNomorInduk";
            txtNomorInduk.ReadOnly = true;
            txtNomorInduk.Size = new Size(202, 27);
            txtNomorInduk.TabIndex = 2;
            // 
            // txtNamaLengkap
            // 
            txtNamaLengkap.BorderStyle = BorderStyle.FixedSingle;
            txtNamaLengkap.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamaLengkap.Location = new Point(155, 102);
            txtNamaLengkap.Margin = new Padding(3, 4, 3, 4);
            txtNamaLengkap.Name = "txtNamaLengkap";
            txtNamaLengkap.Size = new Size(202, 27);
            txtNamaLengkap.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 4;
            label2.Text = "Nama Lengkap";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 56);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 3;
            label1.Text = "Nomor Induk";
            // 
            // FormEditData
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(681, 384);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEditData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Data Fingerprint";
            Load += FormEditData_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFingerPrint).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnScan;
        private PictureBox imgFingerPrint;
        private TextBox txtPath;
        private Button btnChooseFile;
        private GroupBox groupBox1;
        private Button btnCancel;
        private ComboBox comboBoxJenisJari;
        private Label label3;
        private Button btnUpdate;
        private TextBox txtNomorInduk;
        private TextBox txtNamaLengkap;
        private Label label2;
        private Label label1;
    }
}