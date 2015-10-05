using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;

namespace Admin_Toolroom
{
    public partial class configuration : Form
    {
        public configuration()
        {
            InitializeComponent();
            this.txtDomainName.Text = Properties.Settings.Default.sDomainName;
            this.txtLocalAdminUsr.Text = Properties.Settings.Default.sLocAdminName;
            this.txtLocalAdminPwd.Text = Properties.Settings.Default.sLocAdminPwd;
            this.txtWorkgroupName.Text = Properties.Settings.Default.sWorkgroupName;
            this.txtDomainAdminUser.Text = Properties.Settings.Default.sDomUsrName;
            this.txtDomainAdminPwd.Text = Properties.Settings.Default.sDomUsrPwd;
            this.txtDomainOU.Text = Properties.Settings.Default.sDomainOU;
            this.txtPopLstComp.Text = Properties.Settings.Default.sCompList;
            this.txtLdapPath.Text = Properties.Settings.Default.sLdapPath;
            this.txtRdpPath.Text = Properties.Settings.Default.sRDPTxtPath;
            this.txtDC.Text = Properties.Settings.Default.sDC;
            this.txtDefaultPassword.Text = Properties.Settings.Default.sDefaultPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                Properties.Settings.Default.sDomainName = txtDomainName.Text;
                Properties.Settings.Default.sDomainOU = txtDomainOU.Text;
                Properties.Settings.Default.sDomUsrName = txtDomainAdminUser.Text;
                Properties.Settings.Default.sDomUsrPwd = txtDomainAdminPwd.Text;
                Properties.Settings.Default.sWorkgroupName = txtWorkgroupName.Text;
                Properties.Settings.Default.sLocAdminName = txtLocalAdminUsr.Text;
                Properties.Settings.Default.sLocAdminPwd = txtLocalAdminPwd.Text;
                Properties.Settings.Default.sCompList = txtPopLstComp.Text;
                Properties.Settings.Default.sLdapPath = txtLdapPath.Text;
                Properties.Settings.Default.sRDPTxtPath = txtRdpPath.Text;
                Properties.Settings.Default.sDC = txtDC.Text;
                Properties.Settings.Default.sDefaultPassword = txtDefaultPassword.Text;


                Properties.Settings.Default.Save();
                ConfigurationManager.RefreshSection("appSettings");

                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                txtRdpPath.Text = path.ToString();
            }
        }


    }
}
