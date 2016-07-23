namespace Admin_Toolroom
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.lstRacunara1 = new System.Windows.Forms.ListBox();
            this.txtImeRacunara1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbReboot = new System.Windows.Forms.CheckBox();
            this.btnJoinDomain = new System.Windows.Forms.Button();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.txtDomainAdminUser = new System.Windows.Forms.TextBox();
            this.txtDomainAdminPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDomainOU = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtLocalAdminUsr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalAdminPwd = new System.Windows.Forms.TextBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRacunara1
            // 
            this.lstRacunara1.AllowDrop = true;
            this.lstRacunara1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstRacunara1.FormattingEnabled = true;
            this.lstRacunara1.ItemHeight = 17;
            this.lstRacunara1.Location = new System.Drawing.Point(10, 29);
            this.lstRacunara1.Margin = new System.Windows.Forms.Padding(5);
            this.lstRacunara1.Name = "lstRacunara1";
            this.lstRacunara1.Size = new System.Drawing.Size(214, 242);
            this.lstRacunara1.TabIndex = 99;
            // 
            // txtImeRacunara1
            // 
            this.txtImeRacunara1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtImeRacunara1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtImeRacunara1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImeRacunara1.Location = new System.Drawing.Point(10, 29);
            this.txtImeRacunara1.Margin = new System.Windows.Forms.Padding(5);
            this.txtImeRacunara1.Name = "txtImeRacunara1";
            this.txtImeRacunara1.Size = new System.Drawing.Size(214, 23);
            this.txtImeRacunara1.TabIndex = 0;
            this.txtImeRacunara1.WordWrap = false;
            this.txtImeRacunara1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImeRacunara1_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(10, 69);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(236, 45);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Erase";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Location = new System.Drawing.Point(236, 118);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtImeRacunara1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(374, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add computer to list";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstRacunara1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.chbReboot);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(14, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(374, 308);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer list";
            // 
            // chbReboot
            // 
            this.chbReboot.AutoSize = true;
            this.chbReboot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbReboot.Location = new System.Drawing.Point(10, 282);
            this.chbReboot.Margin = new System.Windows.Forms.Padding(4);
            this.chbReboot.Name = "chbReboot";
            this.chbReboot.Size = new System.Drawing.Size(79, 21);
            this.chbReboot.TabIndex = 3;
            this.chbReboot.Text = "Reboot";
            this.chbReboot.UseVisualStyleBackColor = true;
            // 
            // btnJoinDomain
            // 
            this.btnJoinDomain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJoinDomain.Location = new System.Drawing.Point(14, 457);
            this.btnJoinDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnJoinDomain.Name = "btnJoinDomain";
            this.btnJoinDomain.Size = new System.Drawing.Size(228, 40);
            this.btnJoinDomain.TabIndex = 4;
            this.btnJoinDomain.Text = "Join to domain";
            this.btnJoinDomain.UseVisualStyleBackColor = false;
            this.btnJoinDomain.Click += new System.EventHandler(this.btnJoinDomain_Click);
            // 
            // txtDomainName
            // 
            this.txtDomainName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainName.Location = new System.Drawing.Point(141, 28);
            this.txtDomainName.Margin = new System.Windows.Forms.Padding(5);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(320, 23);
            this.txtDomainName.TabIndex = 0;
            this.txtDomainName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBtnJoinDomain_KeyPress);
            // 
            // txtDomainAdminUser
            // 
            this.txtDomainAdminUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainAdminUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainAdminUser.Location = new System.Drawing.Point(141, 101);
            this.txtDomainAdminUser.Margin = new System.Windows.Forms.Padding(5);
            this.txtDomainAdminUser.Name = "txtDomainAdminUser";
            this.txtDomainAdminUser.Size = new System.Drawing.Size(320, 23);
            this.txtDomainAdminUser.TabIndex = 2;
            this.txtDomainAdminUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBtnJoinDomain_KeyPress);
            // 
            // txtDomainAdminPwd
            // 
            this.txtDomainAdminPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainAdminPwd.Location = new System.Drawing.Point(141, 141);
            this.txtDomainAdminPwd.Margin = new System.Windows.Forms.Padding(5);
            this.txtDomainAdminPwd.Name = "txtDomainAdminPwd";
            this.txtDomainAdminPwd.PasswordChar = '*';
            this.txtDomainAdminPwd.Size = new System.Drawing.Size(320, 23);
            this.txtDomainAdminPwd.TabIndex = 3;
            this.txtDomainAdminPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBtnJoinDomain_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Domain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDomainOU);
            this.groupBox3.Controls.Add(this.txtDomainName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDomainAdminUser);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDomainAdminPwd);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(452, 148);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(485, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Domain data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Domain OU:";
            // 
            // txtDomainOU
            // 
            this.txtDomainOU.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainOU.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainOU.Location = new System.Drawing.Point(141, 68);
            this.txtDomainOU.Margin = new System.Windows.Forms.Padding(5);
            this.txtDomainOU.Name = "txtDomainOU";
            this.txtDomainOU.Size = new System.Drawing.Size(320, 23);
            this.txtDomainOU.TabIndex = 1;
            this.txtDomainOU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBtnJoinDomain_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtLocalAdminUsr);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtLocalAdminPwd);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(452, 26);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(485, 114);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Local Admin";
            // 
            // txtLocalAdminUsr
            // 
            this.txtLocalAdminUsr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLocalAdminUsr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtLocalAdminUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLocalAdminUsr.Location = new System.Drawing.Point(140, 42);
            this.txtLocalAdminUsr.Margin = new System.Windows.Forms.Padding(5);
            this.txtLocalAdminUsr.Name = "txtLocalAdminUsr";
            this.txtLocalAdminUsr.Size = new System.Drawing.Size(320, 23);
            this.txtLocalAdminUsr.TabIndex = 0;
            this.txtLocalAdminUsr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBtnJoinDomain_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(19, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "User:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(19, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password:";
            // 
            // txtLocalAdminPwd
            // 
            this.txtLocalAdminPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLocalAdminPwd.Location = new System.Drawing.Point(140, 78);
            this.txtLocalAdminPwd.Margin = new System.Windows.Forms.Padding(5);
            this.txtLocalAdminPwd.Name = "txtLocalAdminPwd";
            this.txtLocalAdminPwd.PasswordChar = '*';
            this.txtLocalAdminPwd.Size = new System.Drawing.Size(320, 23);
            this.txtLocalAdminPwd.TabIndex = 1;
            this.txtLocalAdminPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBtnJoinDomain_KeyPress);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(491, 342);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(446, 132);
            this.lstLog.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "log";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(267, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 39);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 505);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 16);
            this.progressBar1.TabIndex = 58;
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.Location = new System.Drawing.Point(830, 492);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(107, 30);
            this.btnSaveLogs.TabIndex = 59;
            this.btnSaveLogs.Text = "Save Logs";
            this.btnSaveLogs.UseVisualStyleBackColor = true;
            this.btnSaveLogs.Click += new System.EventHandler(this.btnSaveLogs_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 537);
            this.Controls.Add(this.btnSaveLogs);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnJoinDomain);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main_form";
            this.Text = "2.0.2 Admin Toolroom - Join computer to domain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRacunara1;
        private System.Windows.Forms.TextBox txtImeRacunara1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnJoinDomain;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.TextBox txtDomainAdminUser;
        private System.Windows.Forms.TextBox txtDomainAdminPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDomainOU;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtLocalAdminUsr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalAdminPwd;
        private System.Windows.Forms.CheckBox chbReboot;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSaveLogs;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

