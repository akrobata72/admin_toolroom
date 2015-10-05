﻿namespace Admin_Toolroom
{
    partial class configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configuration));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.txtDomainOU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDomainAdminUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomainAdminPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWorkgroupName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalAdminUsr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocalAdminPwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPopLstComp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLdapPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRdpPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRDPfile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDefaultPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain name:";
            // 
            // txtDomainName
            // 
            this.txtDomainName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainName.Location = new System.Drawing.Point(157, 75);
            this.txtDomainName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(321, 26);
            this.txtDomainName.TabIndex = 0;
            // 
            // txtDomainOU
            // 
            this.txtDomainOU.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainOU.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainOU.Location = new System.Drawing.Point(157, 111);
            this.txtDomainOU.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainOU.Name = "txtDomainOU";
            this.txtDomainOU.Size = new System.Drawing.Size(321, 26);
            this.txtDomainOU.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domain OU:";
            // 
            // txtDomainAdminUser
            // 
            this.txtDomainAdminUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainAdminUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainAdminUser.Location = new System.Drawing.Point(157, 148);
            this.txtDomainAdminUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainAdminUser.Name = "txtDomainAdminUser";
            this.txtDomainAdminUser.Size = new System.Drawing.Size(321, 26);
            this.txtDomainAdminUser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Domain admin:";
            // 
            // txtDomainAdminPwd
            // 
            this.txtDomainAdminPwd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDomainAdminPwd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDomainAdminPwd.Location = new System.Drawing.Point(242, 183);
            this.txtDomainAdminPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomainAdminPwd.Name = "txtDomainAdminPwd";
            this.txtDomainAdminPwd.PasswordChar = '*';
            this.txtDomainAdminPwd.Size = new System.Drawing.Size(236, 26);
            this.txtDomainAdminPwd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Domain admin password:";
            // 
            // txtWorkgroupName
            // 
            this.txtWorkgroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtWorkgroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtWorkgroupName.Location = new System.Drawing.Point(211, 218);
            this.txtWorkgroupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkgroupName.Name = "txtWorkgroupName";
            this.txtWorkgroupName.Size = new System.Drawing.Size(267, 26);
            this.txtWorkgroupName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "WORKGROUP name:";
            // 
            // txtLocalAdminUsr
            // 
            this.txtLocalAdminUsr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLocalAdminUsr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtLocalAdminUsr.Location = new System.Drawing.Point(213, 285);
            this.txtLocalAdminUsr.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalAdminUsr.Name = "txtLocalAdminUsr";
            this.txtLocalAdminUsr.Size = new System.Drawing.Size(265, 26);
            this.txtLocalAdminUsr.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Local machine admin:";
            // 
            // txtLocalAdminPwd
            // 
            this.txtLocalAdminPwd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLocalAdminPwd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtLocalAdminPwd.Location = new System.Drawing.Point(300, 250);
            this.txtLocalAdminPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalAdminPwd.Name = "txtLocalAdminPwd";
            this.txtLocalAdminPwd.PasswordChar = '*';
            this.txtLocalAdminPwd.Size = new System.Drawing.Size(178, 26);
            this.txtLocalAdminPwd.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 746);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "S A V E";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(43, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 29);
            this.label9.TabIndex = 15;
            this.label9.Text = "Settings";
            // 
            // txtPopLstComp
            // 
            this.txtPopLstComp.AllowDrop = true;
            this.txtPopLstComp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPopLstComp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPopLstComp.Location = new System.Drawing.Point(12, 465);
            this.txtPopLstComp.Multiline = true;
            this.txtPopLstComp.Name = "txtPopLstComp";
            this.txtPopLstComp.Size = new System.Drawing.Size(633, 64);
            this.txtPopLstComp.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(13, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Local machine admin password:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 422);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(310, 40);
            this.label10.TabIndex = 17;
            this.label10.Text = " Send popup message computer list\r\n ( delimiter is \";\"  without quotes):";
            // 
            // txtLdapPath
            // 
            this.txtLdapPath.AllowDrop = true;
            this.txtLdapPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLdapPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtLdapPath.Location = new System.Drawing.Point(12, 606);
            this.txtLdapPath.Multiline = true;
            this.txtLdapPath.Name = "txtLdapPath";
            this.txtLdapPath.Size = new System.Drawing.Size(633, 41);
            this.txtLdapPath.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(12, 560);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(257, 40);
            this.label11.TabIndex = 19;
            this.label11.Text = " LDAP path:\r\n(only path, without \"LDAP://\")";
            // 
            // txtRdpPath
            // 
            this.txtRdpPath.AllowDrop = true;
            this.txtRdpPath.Location = new System.Drawing.Point(12, 702);
            this.txtRdpPath.Name = "txtRdpPath";
            this.txtRdpPath.Size = new System.Drawing.Size(490, 26);
            this.txtRdpPath.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(13, 679);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(270, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "RDP viewer invitation file path:";
            // 
            // btnRDPfile
            // 
            this.btnRDPfile.Location = new System.Drawing.Point(508, 701);
            this.btnRDPfile.Name = "btnRDPfile";
            this.btnRDPfile.Size = new System.Drawing.Size(137, 27);
            this.btnRDPfile.TabIndex = 11;
            this.btnRDPfile.Text = "Browse";
            this.btnRDPfile.UseVisualStyleBackColor = true;
            this.btnRDPfile.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDC
            // 
            this.txtDC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDC.Location = new System.Drawing.Point(246, 318);
            this.txtDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(232, 26);
            this.txtDC.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(12, 321);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "DC (name or IP address):";
            // 
            // txtDefaultPassword
            // 
            this.txtDefaultPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDefaultPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtDefaultPassword.Location = new System.Drawing.Point(185, 354);
            this.txtDefaultPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtDefaultPassword.Name = "txtDefaultPassword";
            this.txtDefaultPassword.Size = new System.Drawing.Size(293, 26);
            this.txtDefaultPassword.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(11, 357);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 40);
            this.label14.TabIndex = 25;
            this.label14.Text = "Default Password:\r\n(for password reset)\r\n";
            // 
            // configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(673, 408);
            this.Controls.Add(this.txtDefaultPassword);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRDPfile);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRdpPath);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLdapPath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPopLstComp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLocalAdminPwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocalAdminUsr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWorkgroupName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDomainAdminPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDomainAdminUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDomainOU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDomainName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "configuration";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.TextBox txtDomainOU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDomainAdminUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomainAdminPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWorkgroupName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalAdminUsr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocalAdminPwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPopLstComp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLdapPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRdpPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRDPfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDefaultPassword;
        private System.Windows.Forms.Label label14;
    }
}