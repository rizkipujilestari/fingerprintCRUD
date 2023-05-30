namespace FingerPrintCRUD
{
    partial class FormCRUD
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
            dataGridFingerprint = new DataGridView();
            txtPath = new TextBox();
            btnScan = new Button();
            btnChooseFile = new Button();
            imgFingerPrint = new PictureBox();
            groupBox3 = new GroupBox();
            btnMatchProbe = new Button();
            btnReset = new Button();
            groupBox2 = new GroupBox();
            lblStatus = new Label();
            progressBar = new ProgressBar();
            labelExecTime = new Label();
            btnAddNew = new Button();
            btnEdit = new Button();
            btnExit = new Button();
            label4 = new Label();
            btnDelete = new Button();
            btnTestCon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridFingerprint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFingerPrint).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridFingerprint
            // 
            dataGridFingerprint.AllowUserToAddRows = false;
            dataGridFingerprint.AllowUserToDeleteRows = false;
            dataGridFingerprint.AllowUserToOrderColumns = true;
            dataGridFingerprint.BackgroundColor = Color.LightSlateGray;
            dataGridFingerprint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFingerprint.Location = new Point(15, 60);
            dataGridFingerprint.Margin = new Padding(3, 4, 3, 4);
            dataGridFingerprint.Name = "dataGridFingerprint";
            dataGridFingerprint.ReadOnly = true;
            dataGridFingerprint.RowTemplate.Height = 25;
            dataGridFingerprint.Size = new Size(537, 185);
            dataGridFingerprint.TabIndex = 1;
            // 
            // txtPath
            // 
            txtPath.BackColor = Color.White;
            txtPath.BorderStyle = BorderStyle.FixedSingle;
            txtPath.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPath.Location = new Point(127, 251);
            txtPath.Margin = new Padding(3, 4, 3, 4);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(115, 31);
            txtPath.TabIndex = 13;
            // 
            // btnScan
            // 
            btnScan.BackColor = SystemColors.InactiveCaption;
            btnScan.Enabled = false;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Location = new Point(53, 304);
            btnScan.Margin = new Padding(3, 4, 3, 4);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(155, 51);
            btnScan.TabIndex = 8;
            btnScan.Text = "Scan Fingerprint";
            btnScan.UseVisualStyleBackColor = false;
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = Color.White;
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Location = new Point(21, 251);
            btnChooseFile.Margin = new Padding(3, 4, 3, 4);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(107, 31);
            btnChooseFile.TabIndex = 1;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // imgFingerPrint
            // 
            imgFingerPrint.BackColor = Color.White;
            imgFingerPrint.BorderStyle = BorderStyle.FixedSingle;
            imgFingerPrint.Location = new Point(21, 28);
            imgFingerPrint.Margin = new Padding(3, 4, 3, 4);
            imgFingerPrint.Name = "imgFingerPrint";
            imgFingerPrint.Size = new Size(221, 224);
            imgFingerPrint.SizeMode = PictureBoxSizeMode.Zoom;
            imgFingerPrint.TabIndex = 0;
            imgFingerPrint.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnMatchProbe);
            groupBox3.Controls.Add(txtPath);
            groupBox3.Controls.Add(imgFingerPrint);
            groupBox3.Controls.Add(btnChooseFile);
            groupBox3.Controls.Add(btnScan);
            groupBox3.Location = new Point(12, 13);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(266, 439);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Select Fingerprint";
            // 
            // btnMatchProbe
            // 
            btnMatchProbe.BackColor = Color.LightSteelBlue;
            btnMatchProbe.FlatStyle = FlatStyle.Flat;
            btnMatchProbe.Location = new Point(53, 363);
            btnMatchProbe.Margin = new Padding(3, 4, 3, 4);
            btnMatchProbe.Name = "btnMatchProbe";
            btnMatchProbe.Size = new Size(155, 51);
            btnMatchProbe.TabIndex = 10;
            btnMatchProbe.Text = "Match Fingerprint";
            btnMatchProbe.UseVisualStyleBackColor = false;
            btnMatchProbe.Click += btnMatchProbe_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightSteelBlue;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(196, 364);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(175, 51);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset All";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Controls.Add(progressBar);
            groupBox2.Controls.Add(labelExecTime);
            groupBox2.Controls.Add(btnAddNew);
            groupBox2.Controls.Add(btnReset);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnTestCon);
            groupBox2.Controls.Add(dataGridFingerprint);
            groupBox2.Location = new Point(290, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 440);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Database";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(15, 251);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(114, 19);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Processing... 0%";
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.White;
            progressBar.ForeColor = Color.LightSkyBlue;
            progressBar.Location = new Point(15, 275);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(537, 23);
            progressBar.TabIndex = 17;
            // 
            // labelExecTime
            // 
            labelExecTime.AutoSize = true;
            labelExecTime.Location = new Point(377, 251);
            labelExecTime.Name = "labelExecTime";
            labelExecTime.Size = new Size(0, 19);
            labelExecTime.TabIndex = 16;
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.LightSteelBlue;
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Location = new Point(15, 305);
            btnAddNew.Margin = new Padding(3, 4, 3, 4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(175, 51);
            btnAddNew.TabIndex = 15;
            btnAddNew.Text = "Add New Data";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSteelBlue;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(196, 305);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(175, 51);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit Selected Data";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(377, 364);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(175, 51);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 23);
            label4.Name = "label4";
            label4.Size = new Size(209, 33);
            label4.TabIndex = 12;
            label4.Text = "Daftar Fingerprint";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.InactiveCaption;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(377, 305);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 51);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete Selected Data";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnTestCon
            // 
            btnTestCon.BackColor = Color.LightSteelBlue;
            btnTestCon.FlatStyle = FlatStyle.Flat;
            btnTestCon.Location = new Point(15, 364);
            btnTestCon.Margin = new Padding(3, 4, 3, 4);
            btnTestCon.Name = "btnTestCon";
            btnTestCon.Size = new Size(175, 51);
            btnTestCon.TabIndex = 9;
            btnTestCon.Text = "Test DB Connection";
            btnTestCon.UseVisualStyleBackColor = false;
            btnTestCon.Click += btnTestCon_Click;
            // 
            // FormCRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(869, 464);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCRUD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fingerprint CRUD Net6";
            Load += FormCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridFingerprint).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFingerPrint).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridFingerprint;
        private PictureBox imgFingerPrint;
        private Button btnChooseFile;
        private Button btnScan;
        private GroupBox groupBox2;
        private Button btnTestCon;
        private GroupBox groupBox3;
        private Button btnMatchProbe;
        private Button btnDelete;
        private TextBox txtPath;
        private Label label4;
        private Button btnExit;
        private Button btnEdit;
        private Button btnReset;
        private Button btnAddNew;
        private Label labelExecTime;
        private ProgressBar progressBar;
        private Label lblStatus;
    }
}