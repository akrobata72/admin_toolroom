namespace Admin_Toolroom
{
    partial class Unjoin_domain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unjoin_domain));
            this.txtImeRacunara1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstRacunara1 = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbReboot = new System.Windows.Forms.CheckBox();
            this.btnUnjoinDomain = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtWorkgroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalAdminUsr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalAdminPwd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDomainAdminUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDomainAdminPwd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImeRacunara1
            // 
            this.txtImeRacunara1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtImeRacunara1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtImeRacunara1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImeRacunara1.Location = new System.Drawing.Point(10, 31);
            this.txtImeRacunara1.Margin = new System.Windows.Forms.Padding(4);
            this.txtImeRacunara1.Name = "txtImeRacunara1";
            this.txtImeRacunara1.Size = new System.Drawing.Size(214, 23);
            this.txtImeRacunara1.TabIndex = 0;
            this.txtImeRacunara1.WordWrap = false;
            this.txtImeRacunara1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImeRacunara1_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(10, 69);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImeRacunara1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImeRacunara1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(373, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add computer to list";
            // 
            // lstRacunara1
            // 
            this.lstRacunara1.AllowDrop = true;
            this.lstRacunara1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstRacunara1.FormattingEnabled = true;
            this.lstRacunara1.ItemHeight = 16;
            this.lstRacunara1.Location = new System.Drawing.Point(10, 29);
            this.lstRacunara1.Margin = new System.Windows.Forms.Padding(4);
            this.lstRacunara1.Name = "lstRacunara1";
            this.lstRacunara1.Size = new System.Drawing.Size(214, 244);
            this.lstRacunara1.TabIndex = 106;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(237, 44);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 36);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Erase";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(237, 118);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtDomainName
            // 
            this.txtDomainName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainName.Location = new System.Drawing.Point(122, 37);
            this.txtDomainName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(365, 23);
            this.txtDomainName.TabIndex = 0;
            this.txtDomainName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterbtnUnjoin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Domain:";
            // 
            // chbReboot
            // 
            this.chbReboot.AutoSize = true;
            this.chbReboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbReboot.Location = new System.Drawing.Point(10, 276);
            this.chbReboot.Name = "chbReboot";
            this.chbReboot.Size = new System.Drawing.Size(79, 21);
            this.chbReboot.TabIndex = 5;
            this.chbReboot.Text = "Reboot";
            this.chbReboot.UseVisualStyleBackColor = true;
            // 
            // btnUnjoinDomain
            // 
            this.btnUnjoinDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUnjoinDomain.Location = new System.Drawing.Point(20, 458);
            this.btnUnjoinDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnjoinDomain.Name = "btnUnjoinDomain";
            this.btnUnjoinDomain.Size = new System.Drawing.Size(221, 46);
            this.btnUnjoinDomain.TabIndex = 3;
            this.btnUnjoinDomain.Text = "Unjoin from domain!";
            this.btnUnjoinDomain.UseVisualStyleBackColor = false;
            this.btnUnjoinDomain.Click += new System.EventHandler(this.btnUnjoinDomain_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtWorkgroupName);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtLocalAdminUsr);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtLocalAdminPwd);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(428, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 157);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Local Admin";
            // 
            // txtWorkgroupName
            // 
            this.txtWorkgroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtWorkgroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtWorkgroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWorkgroupName.Location = new System.Drawing.Point(122, 44);
            this.txtWorkgroupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkgroupName.Name = "txtWorkgroupName";
            this.txtWorkgroupName.Size = new System.Drawing.Size(365, 23);
            this.txtWorkgroupName.TabIndex = 0;
            this.txtWorkgroupName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterbtnUnjoin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Workgroup:";
            // 
            // txtLocalAdminUsr
            // 
            this.txtLocalAdminUsr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLocalAdminUsr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtLocalAdminUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLocalAdminUsr.Location = new System.Drawing.Point(121, 79);
            this.txtLocalAdminUsr.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalAdminUsr.Name = "txtLocalAdminUsr";
            this.txtLocalAdminUsr.Size = new System.Drawing.Size(365, 23);
            this.txtLocalAdminUsr.TabIndex = 1;
            this.txtLocalAdminUsr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterbtnUnjoin_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(16, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password:";
            // 
            // txtLocalAdminPwd
            // 
            this.txtLocalAdminPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLocalAdminPwd.Location = new System.Drawing.Point(121, 115);
            this.txtLocalAdminPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalAdminPwd.Name = "txtLocalAdminPwd";
            this.txtLocalAdminPwd.PasswordChar = '*';
            this.txtLocalAdminPwd.Size = new System.Drawing.Size(365, 23);
            this.txtLocalAdminPwd.TabIndex = 2;
            this.txtLocalAdminPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterbtnUnjoin_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstRacunara1);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.chbReboot);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(20, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(374, 305);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista računara";
            // 
            // txtDomainAdminUser
            // 
            this.txtDomainAdminUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainAdminUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainAdminUser.Location = new System.Drawing.Point(122, 73);
            this.txtDomainAdminUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainAdminUser.Name = "txtDomainAdminUser";
            this.txtDomainAdminUser.Size = new System.Drawing.Size(365, 23);
            this.txtDomainAdminUser.TabIndex = 1;
            this.txtDomainAdminUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterbtnUnjoin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 112;
            this.label3.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 113;
            this.label4.Text = "Password:";
            // 
            // txtDomainAdminPwd
            // 
            this.txtDomainAdminPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainAdminPwd.Location = new System.Drawing.Point(122, 109);
            this.txtDomainAdminPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainAdminPwd.Name = "txtDomainAdminPwd";
            this.txtDomainAdminPwd.PasswordChar = '*';
            this.txtDomainAdminPwd.Size = new System.Drawing.Size(365, 23);
            this.txtDomainAdminPwd.TabIndex = 2;
            this.txtDomainAdminPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterbtnUnjoin_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDomainAdminUser);
            this.groupBox3.Controls.Add(this.txtDomainName);
            this.groupBox3.Controls.Add(this.txtDomainAdminPwd);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(428, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 149);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Domain Admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 116;
            this.label7.Text = "log";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(475, 357);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(446, 132);
            this.lstLog.TabIndex = 115;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(257, 462);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 117;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveLogs.Location = new System.Drawing.Point(822, 504);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(99, 30);
            this.btnSaveLogs.TabIndex = 118;
            this.btnSaveLogs.Text = "Save Logs";
            this.btnSaveLogs.UseVisualStyleBackColor = true;
            this.btnSaveLogs.Click += new System.EventHandler(this.btnSaveLogs_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 522);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 12);
            this.progressBar1.TabIndex = 119;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Unjoin_domain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 543);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSaveLogs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUnjoinDomain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Unjoin_domain";
            this.Text = "2.0.2 Admin Toolroom - Unjoin computer from domain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImeRacunara1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstRacunara1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbReboot;
        private System.Windows.Forms.Button btnUnjoinDomain;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLocalAdminUsr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalAdminPwd;
        private System.Windows.Forms.TextBox txtWorkgroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDomainAdminUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDomainAdminPwd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveLogs;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}