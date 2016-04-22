using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;

namespace Admin_Toolroom
{
    public partial class Chg_pass : Form
    {
        public Chg_pass(string l, string dc, string pwd, string domain,string admin)
        {
            InitializeComponent();
            lblUser.Text=l;
            lblDC.Text=dc;
            lblPwd.Text=pwd;
            lblDomain.Text=domain;
            lblAdminUser.Text = admin;

            this.txtNewPass.Text = Properties.Settings.Default.sDefaultPassword;
            this.txtRepNewPass.Text = Properties.Settings.Default.sDefaultPassword;

        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                MessageBox.Show(this, "Fields can not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNewPass.Text == txtRepNewPass.Text)
            {


                PrincipalContext ctx = new PrincipalContext(ContextType.Domain,
                                             lblDC.Text,
                                             null,
                                             "@" + lblDomain.Text + @"\" + lblAdminUser.Text,
                                             lblPwd.Text
                                             );
                UserPrincipal usr = UserPrincipal.FindByIdentity(ctx, lblUser.Text);
                string newPass = txtNewPass.Text;
                usr.SetPassword(newPass);
                usr.Save();
                MessageBox.Show(this, "Password has now been reset!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(this, "Passwords in both fields must match! Please re-type them.", "Passwords match error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

                    private void txtRepNewPass_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }
               
    }
         
    }

