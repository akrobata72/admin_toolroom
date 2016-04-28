namespace Admin_Toolroom
{
    partial class User_info
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_info));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unlockAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLDAP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomainAdminUser = new System.Windows.Forms.TextBox();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.txtDomainAdminPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLockoutTime = new System.Windows.Forms.Label();
            this.lblBadPasswordCount = new System.Windows.Forms.Label();
            this.lblBadPasswordTime = new System.Windows.Forms.Label();
            this.lblLastLogoff = new System.Windows.Forms.Label();
            this.lblLastLogon = new System.Windows.Forms.Label();
            this.lblPwdLastSet = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblSAMAccountName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbaciIzDomenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JoinToDomainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slanjePorukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteAssistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtSearch.Location = new System.Drawing.Point(36, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(310, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 44);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstResults
            // 
            this.lstResults.AllowDrop = true;
            this.lstResults.ContextMenuStrip = this.contextMenuStrip1;
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(36, 97);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(251, 436);
            this.lstResults.Sorted = true;
            this.lstResults.TabIndex = 3;
            this.lstResults.SelectedIndexChanged += new System.EventHandler(this.lstResults_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unlockAccountToolStripMenuItem,
            this.resetPasswordToolStripMenuItem,
            this.moveUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 76);
            // 
            // unlockAccountToolStripMenuItem
            // 
            this.unlockAccountToolStripMenuItem.Name = "unlockAccountToolStripMenuItem";
            this.unlockAccountToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.unlockAccountToolStripMenuItem.Text = "Unlock Account";
            this.unlockAccountToolStripMenuItem.Click += new System.EventHandler(this.unlockAccountToolStripMenuItem_Click);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // moveUserToolStripMenuItem
            // 
            this.moveUserToolStripMenuItem.Name = "moveUserToolStripMenuItem";
            this.moveUserToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.moveUserToolStripMenuItem.Text = "Move User";
            this.moveUserToolStripMenuItem.Click += new System.EventHandler(this.moveUserToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtDC);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtLDAP);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDomainAdminUser);
            this.groupBox3.Controls.Add(this.txtDomainName);
            this.groupBox3.Controls.Add(this.txtDomainAdminPwd);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(448, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Domain Admin";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(17, 187);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 20);
            this.label14.TabIndex = 117;
            this.label14.Text = "DC (IP or name):";
            // 
            // txtDC
            // 
            this.txtDC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDC.Location = new System.Drawing.Point(169, 181);
            this.txtDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(296, 26);
            this.txtDC.TabIndex = 4;
            this.txtDC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(17, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 115;
            this.label12.Text = "LDAP path:";
            // 
            // txtLDAP
            // 
            this.txtLDAP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLDAP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtLDAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLDAP.Location = new System.Drawing.Point(169, 144);
            this.txtLDAP.Margin = new System.Windows.Forms.Padding(4);
            this.txtLDAP.Name = "txtLDAP";
            this.txtLDAP.Size = new System.Drawing.Size(296, 26);
            this.txtLDAP.TabIndex = 3;
            this.txtLDAP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "User:";
            // 
            // txtDomainAdminUser
            // 
            this.txtDomainAdminUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainAdminUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainAdminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainAdminUser.Location = new System.Drawing.Point(168, 73);
            this.txtDomainAdminUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainAdminUser.Name = "txtDomainAdminUser";
            this.txtDomainAdminUser.Size = new System.Drawing.Size(296, 26);
            this.txtDomainAdminUser.TabIndex = 1;
            this.txtDomainAdminUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyPress);
            // 
            // txtDomainName
            // 
            this.txtDomainName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDomainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainName.Location = new System.Drawing.Point(168, 37);
            this.txtDomainName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(296, 26);
            this.txtDomainName.TabIndex = 0;
            this.txtDomainName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyPress);
            // 
            // txtDomainAdminPwd
            // 
            this.txtDomainAdminPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDomainAdminPwd.Location = new System.Drawing.Point(168, 109);
            this.txtDomainAdminPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainAdminPwd.Name = "txtDomainAdminPwd";
            this.txtDomainAdminPwd.PasswordChar = '*';
            this.txtDomainAdminPwd.Size = new System.Drawing.Size(296, 26);
            this.txtDomainAdminPwd.TabIndex = 2;
            this.txtDomainAdminPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Domain:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(262, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 116;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLockoutTime);
            this.groupBox1.Controls.Add(this.lblBadPasswordCount);
            this.groupBox1.Controls.Add(this.lblBadPasswordTime);
            this.groupBox1.Controls.Add(this.lblLastLogoff);
            this.groupBox1.Controls.Add(this.lblLastLogon);
            this.groupBox1.Controls.Add(this.lblPwdLastSet);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Controls.Add(this.lblSAMAccountName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(314, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 271);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User info";
            // 
            // lblLockoutTime
            // 
            this.lblLockoutTime.AutoSize = true;
            this.lblLockoutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLockoutTime.Location = new System.Drawing.Point(262, 245);
            this.lblLockoutTime.Name = "lblLockoutTime";
            this.lblLockoutTime.Size = new System.Drawing.Size(0, 20);
            this.lblLockoutTime.TabIndex = 133;
            // 
            // lblBadPasswordCount
            // 
            this.lblBadPasswordCount.AutoSize = true;
            this.lblBadPasswordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBadPasswordCount.Location = new System.Drawing.Point(262, 220);
            this.lblBadPasswordCount.Name = "lblBadPasswordCount";
            this.lblBadPasswordCount.Size = new System.Drawing.Size(0, 20);
            this.lblBadPasswordCount.TabIndex = 132;
            // 
            // lblBadPasswordTime
            // 
            this.lblBadPasswordTime.AutoSize = true;
            this.lblBadPasswordTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBadPasswordTime.Location = new System.Drawing.Point(262, 194);
            this.lblBadPasswordTime.Name = "lblBadPasswordTime";
            this.lblBadPasswordTime.Size = new System.Drawing.Size(0, 20);
            this.lblBadPasswordTime.TabIndex = 131;
            // 
            // lblLastLogoff
            // 
            this.lblLastLogoff.AutoSize = true;
            this.lblLastLogoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastLogoff.Location = new System.Drawing.Point(262, 167);
            this.lblLastLogoff.Name = "lblLastLogoff";
            this.lblLastLogoff.Size = new System.Drawing.Size(0, 20);
            this.lblLastLogoff.TabIndex = 130;
            // 
            // lblLastLogon
            // 
            this.lblLastLogon.AutoSize = true;
            this.lblLastLogon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastLogon.Location = new System.Drawing.Point(262, 142);
            this.lblLastLogon.Name = "lblLastLogon";
            this.lblLastLogon.Size = new System.Drawing.Size(0, 20);
            this.lblLastLogon.TabIndex = 129;
            // 
            // lblPwdLastSet
            // 
            this.lblPwdLastSet.AutoSize = true;
            this.lblPwdLastSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPwdLastSet.Location = new System.Drawing.Point(262, 113);
            this.lblPwdLastSet.Name = "lblPwdLastSet";
            this.lblPwdLastSet.Size = new System.Drawing.Size(0, 20);
            this.lblPwdLastSet.TabIndex = 128;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeID.Location = new System.Drawing.Point(262, 81);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(0, 20);
            this.lblEmployeeID.TabIndex = 127;
            // 
            // lblSAMAccountName
            // 
            this.lblSAMAccountName.AutoSize = true;
            this.lblSAMAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSAMAccountName.Location = new System.Drawing.Point(262, 52);
            this.lblSAMAccountName.Name = "lblSAMAccountName";
            this.lblSAMAccountName.Size = new System.Drawing.Size(0, 20);
            this.lblSAMAccountName.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(13, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 125;
            this.label13.Text = "Lockout time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(13, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 20);
            this.label11.TabIndex = 124;
            this.label11.Text = "Bad Password Count:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(13, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 20);
            this.label10.TabIndex = 123;
            this.label10.Text = "Bad password time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(13, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 122;
            this.label9.Text = "Last logoff:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(13, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 121;
            this.label8.Text = "Last logon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(13, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 120;
            this.label7.Text = "Last password set:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(13, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 119;
            this.label6.Text = "EmployeeID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 118;
            this.label5.Text = "samAccountName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 117;
            this.label2.Text = "Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(970, 28);
            this.menuStrip1.TabIndex = 118;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijeToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.opcijeToolStripMenuItem.Text = "Settings";
            this.opcijeToolStripMenuItem.Click += new System.EventHandler(this.opcijeToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.izlazToolStripMenuItem.Text = "Exit";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbaciIzDomenaToolStripMenuItem,
            this.JoinToDomainToolStripMenuItem,
            this.slanjePorukaToolStripMenuItem,
            this.remoteAssistanceToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // izbaciIzDomenaToolStripMenuItem
            // 
            this.izbaciIzDomenaToolStripMenuItem.Name = "izbaciIzDomenaToolStripMenuItem";
            this.izbaciIzDomenaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izbaciIzDomenaToolStripMenuItem.Text = "Unjoin from domain";
            this.izbaciIzDomenaToolStripMenuItem.Click += new System.EventHandler(this.izbaciIzDomenaToolStripMenuItem_Click);
            // 
            // JoinToDomainToolStripMenuItem
            // 
            this.JoinToDomainToolStripMenuItem.Name = "JoinToDomainToolStripMenuItem";
            this.JoinToDomainToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.JoinToDomainToolStripMenuItem.Text = "Join to domain";
            this.JoinToDomainToolStripMenuItem.Click += new System.EventHandler(this.JoinToDomainToolStripMenuItem_Click);
            // 
            // slanjePorukaToolStripMenuItem
            // 
            this.slanjePorukaToolStripMenuItem.Name = "slanjePorukaToolStripMenuItem";
            this.slanjePorukaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.slanjePorukaToolStripMenuItem.Text = "Popup message send";
            this.slanjePorukaToolStripMenuItem.Click += new System.EventHandler(this.slanjePorukaToolStripMenuItem_Click);
            // 
            // remoteAssistanceToolStripMenuItem
            // 
            this.remoteAssistanceToolStripMenuItem.Name = "remoteAssistanceToolStripMenuItem";
            this.remoteAssistanceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.remoteAssistanceToolStripMenuItem.Text = "Remote Assistance";
            this.remoteAssistanceToolStripMenuItem.Click += new System.EventHandler(this.remoteAssistanceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // User_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 555);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_info";
            this.Text = "Domain User Info";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomainAdminUser;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.TextBox txtDomainAdminPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblLockoutTime;
        private System.Windows.Forms.Label lblBadPasswordCount;
        private System.Windows.Forms.Label lblBadPasswordTime;
        private System.Windows.Forms.Label lblLastLogoff;
        private System.Windows.Forms.Label lblLastLogon;
        private System.Windows.Forms.Label lblPwdLastSet;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblSAMAccountName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLDAP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbaciIzDomenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JoinToDomainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slanjePorukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remoteAssistanceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unlockAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.ToolStripMenuItem moveUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}