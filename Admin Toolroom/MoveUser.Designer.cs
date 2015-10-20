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
            this.cmbOU = new System.Windows.Forms.ComboBox();
            this.btnPremesti = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblAdminUser = new System.Windows.Forms.Label();
            this.lblDName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOU
            // 
            this.cmbOU.FormattingEnabled = true;
            this.cmbOU.Location = new System.Drawing.Point(14, 90);
            this.cmbOU.Margin = new System.Windows.Forms.Padding(5);
            this.cmbOU.Name = "cmbOU";
            this.cmbOU.Size = new System.Drawing.Size(756, 33);
            this.cmbOU.TabIndex = 0;
            // 
            // btnPremesti
            // 
            this.btnPremesti.Location = new System.Drawing.Point(14, 161);
            this.btnPremesti.Margin = new System.Windows.Forms.Padding(5);
            this.btnPremesti.Name = "btnPremesti";
            this.btnPremesti.Size = new System.Drawing.Size(308, 83);
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
            this.lblDName.Location = new System.Drawing.Point(26, 49);
            this.lblDName.Name = "lblDName";
            this.lblDName.Size = new System.Drawing.Size(0, 25);
            this.lblDName.TabIndex = 8;
            // 
            // MoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 285);
            this.Controls.Add(this.lblDName);
            this.Controls.Add(this.lblAdminUser);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnPremesti);
            this.Controls.Add(this.cmbOU);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MoveUser";
            this.Text = "MoveUser";
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
    }
}