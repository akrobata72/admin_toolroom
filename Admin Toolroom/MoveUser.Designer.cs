namespace Admin_Toolroom
{
    partial class MoveUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveUser));
            this.cmbOU = new System.Windows.Forms.ComboBox();
            this.btnPremesti = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblAdminUser = new System.Windows.Forms.Label();
            this.lblDName = new System.Windows.Forms.Label();
            this.lblUserCaption = new System.Windows.Forms.Label();
            this.gpbUser = new System.Windows.Forms.GroupBox();
            this.lblMoveToData = new System.Windows.Forms.Label();
            this.lblMoveTo = new System.Windows.Forms.Label();
            this.gpbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOU
            // 
            this.cmbOU.FormattingEnabled = true;
            this.cmbOU.Location = new System.Drawing.Point(12, 139);
            this.cmbOU.Margin = new System.Windows.Forms.Padding(5);
            this.cmbOU.Name = "cmbOU";
            this.cmbOU.Size = new System.Drawing.Size(569, 33);
            this.cmbOU.TabIndex = 0;
            this.cmbOU.SelectedIndexChanged += new System.EventHandler(this.cmbOU_SelectedIndexChanged_1);
            this.cmbOU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterBtn_KeyPress);
            // 
            // btnPremesti
            // 
            this.btnPremesti.Location = new System.Drawing.Point(12, 184);
            this.btnPremesti.Margin = new System.Windows.Forms.Padding(5);
            this.btnPremesti.Name = "btnPremesti";
            this.btnPremesti.Size = new System.Drawing.Size(199, 52);
            this.btnPremesti.TabIndex = 2;
            this.btnPremesti.Text = "MOVE";
            this.btnPremesti.UseVisualStyleBackColor = true;
            this.btnPremesti.Click += new System.EventHandler(this.btnPremesti_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(21, 20);
            this.lblUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 25);
            this.lblUser.TabIndex = 3;
            this.lblUser.Visible = false;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(125, 20);
            this.lblDC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(0, 25);
            this.lblDC.TabIndex = 4;
            this.lblDC.Visible = false;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(228, 20);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(0, 25);
            this.lblPwd.TabIndex = 5;
            this.lblPwd.Visible = false;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(328, 19);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(0, 25);
            this.lblDomain.TabIndex = 6;
            this.lblDomain.Visible = false;
            // 
            // lblAdminUser
            // 
            this.lblAdminUser.AutoSize = true;
            this.lblAdminUser.Location = new System.Drawing.Point(414, 19);
            this.lblAdminUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdminUser.Name = "lblAdminUser";
            this.lblAdminUser.Size = new System.Drawing.Size(0, 25);
            this.lblAdminUser.TabIndex = 7;
            this.lblAdminUser.Visible = false;
            // 
            // lblDName
            // 
            this.lblDName.AutoSize = true;
            this.lblDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDName.Location = new System.Drawing.Point(136, 33);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(0, 24);
            this.lblDName.TabIndex = 8;
            // 
            // lblUserCaption
            // 
            this.lblUserCaption.AutoSize = true;
            this.lblUserCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblUserCaption.Location = new System.Drawing.Point(7, 33);
            this.lblUserCaption.Name = "lblUserCaption";
            this.lblUserCaption.Size = new System.Drawing.Size(102, 24);
            this.lblUserCaption.TabIndex = 9;
            this.lblUserCaption.Text = "Username:";
            // 
            // gpbUser
            // 
            this.gpbUser.Controls.Add(this.lblMoveToData);
            this.gpbUser.Controls.Add(this.lblMoveTo);
            this.gpbUser.Controls.Add(this.lblUserCaption);
            this.gpbUser.Controls.Add(this.lblDName);
            this.gpbUser.Location = new System.Drawing.Point(12, 12);
            this.gpbUser.Name = "gpbUser";
            this.gpbUser.Size = new System.Drawing.Size(569, 106);
            this.gpbUser.TabIndex = 10;
            this.gpbUser.TabStop = false;
            this.gpbUser.Text = "User data";
            // 
            // lblMoveToData
            // 
            this.lblMoveToData.AutoSize = true;
            this.lblMoveToData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMoveToData.Location = new System.Drawing.Point(116, 60);
            this.lblMoveToData.Name = "lblMoveToData";
            this.lblMoveToData.Size = new System.Drawing.Size(0, 20);
            this.lblMoveToData.TabIndex = 11;
            this.lblMoveToData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMoveTo
            // 
            this.lblMoveTo.AutoSize = true;
            this.lblMoveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMoveTo.Location = new System.Drawing.Point(8, 57);
            this.lblMoveTo.Name = "lblMoveTo";
            this.lblMoveTo.Size = new System.Drawing.Size(90, 24);
            this.lblMoveTo.TabIndex = 10;
            this.lblMoveTo.Text = "Move To:";
            // 
            // MoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 256);
            this.Controls.Add(this.gpbUser);
            this.Controls.Add(this.lblAdminUser);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnPremesti);
            this.Controls.Add(this.cmbOU);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MoveUser";
            this.Text = "User Moving";
            this.gpbUser.ResumeLayout(false);
            this.gpbUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOU;
        private System.Windows.Forms.Button btnPremesti;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblAdminUser;
        private System.Windows.Forms.Label lblDName;
        private System.Windows.Forms.Label lblUserCaption;
        private System.Windows.Forms.GroupBox gpbUser;
        private System.Windows.Forms.Label lblMoveToData;
        private System.Windows.Forms.Label lblMoveTo;
    }
}