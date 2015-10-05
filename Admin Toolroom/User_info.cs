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
    public partial class User_info : Form
    {
        public User_info()
        {
            InitializeComponent();
            this.txtDomainName.Text = Properties.Settings.Default.sDomainName;
            this.txtDomainAdminUser.Text = Properties.Settings.Default.sDomUsrName;
            this.txtDomainAdminPwd.Text = Properties.Settings.Default.sDomUsrPwd;
            this.txtLDAP.Text = Properties.Settings.Default.sLdapPath;
            this.txtDC.Text = Properties.Settings.Default.sDC;

        }

        private void txtSearch_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            DirectoryEntry de = new DirectoryEntry("LDAP://" + txtLDAP.Text);

            de.Username = txtDomainAdminUser.Text;
            de.Password = txtDomainAdminPwd.Text;
            DirectorySearcher ds = new DirectorySearcher(de);
            ds.SearchScope = SearchScope.Subtree;
            ds.Filter = "(&(objectCategory=User) (samAccountName=" + "*" + txtSearch.Text + "*" + "))";

            ds.PropertiesToLoad.Clear();
            ds.PropertiesToLoad.Add("employeeID");
            ds.PropertiesToLoad.Add("name");
            ds.PropertiesToLoad.Add("samAccountName");
            ds.PropertiesToLoad.Add("LockoutTime");
            ds.PropertiesToLoad.Add("pwdLastSet");
            ds.PropertiesToLoad.Add("lastLogon");
            ds.PropertiesToLoad.Add("lastLogoff");
            ds.PropertiesToLoad.Add("lockoutTime");
            ds.PropertiesToLoad.Add("badPasswordTime");
            ds.PropertiesToLoad.Add("badPwdCount");
            try
            {
                //SearchResultCollection result = ds.FindAll();


                foreach (SearchResult r in ds.FindAll())
                {
                    lstResults.Items.Add(r.Properties["samAccountName"][0].ToString());
                }

            }

            catch (Exception f)
            {
                MessageBox.Show("Error: " + f.Message);

            }

        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstResults.SelectedIndex >= 0)
            {
                string s = lstResults.SelectedItem.ToString();

                string strUsrID = txtDomainAdminUser.Text;
                string strpswrd = txtDomainAdminPwd.Text;

                DirectoryEntry de = new DirectoryEntry("LDAP://" + txtLDAP.Text);

                de.Username = strUsrID;
                de.Password = strpswrd;
                DirectorySearcher ds = new DirectorySearcher(de);
                ds.SearchScope = SearchScope.Subtree;
                ds.Filter = "(&(objectCategory=User) (samAccountName=" + s + "))";

                ds.PropertiesToLoad.Clear();
                ds.PropertiesToLoad.Add("employeeID");
                ds.PropertiesToLoad.Add("name");
                ds.PropertiesToLoad.Add("samAccountName");
                ds.PropertiesToLoad.Add("LockoutTime");
                ds.PropertiesToLoad.Add("pwdLastSet");
                ds.PropertiesToLoad.Add("lastLogon");
                ds.PropertiesToLoad.Add("lastLogoff");
                ds.PropertiesToLoad.Add("badPasswordTime");
                ds.PropertiesToLoad.Add("badPwdCount");

                try
                {
                    SearchResult result = ds.FindOne();

                    if (result != null)
                    {

                        if (result.Properties["name"].Count > 0)
                        {
                            lblName.Text = result.Properties["name"][0].ToString();
                        }
                        else
                        {
                            lblName.Text = "0";
                        }

                        lblSAMAccountName.Text = result.Properties["samAccountName"][0].ToString();

                        if (result.Properties["employeeID"].Count > 0)
                        {
                            lblEmployeeID.Text = result.Properties["employeeID"][0].ToString();
                        }
                        else
                        {
                            lblEmployeeID.Text = "0";
                        }

                        //lblLastLogon.Text = result.Properties["lastLogon"][0].ToString();
                        if (result.Properties["lastLogon"].Count > 0 && result.Properties["lastLogon"][0].ToString() != "0")
                        {

                            long lastlogon = (long)result.Properties["lastLogon"][0];
                            string lastlogon1 = DateTime.FromFileTime(lastlogon).ToString();
                            lblLastLogon.Text = lastlogon1.ToString();
                        }
                        else
                        {
                            lblLastLogon.Text = "0";
                        }

                        //lblLastLogoff.Text = result.Properties["lastLogoff"][0].ToString();
                        if (result.Properties["lastLogoff"].Count > 0 && result.Properties["lastLogoff"][0].ToString() != "0")
                        {
                            long lastlogoff = (long)result.Properties["lastLogoff"][0];
                            string lastlogoff1 = DateTime.FromFileTime(lastlogoff).ToString();
                            lblLastLogoff.Text = lastlogoff1.ToString();
                        }
                        else
                        {
                            lblLastLogoff.Text = "0";
                        }

                        //lblBadPasswordTime.Text = result.Properties["badPasswordTime"][0].ToString();
                        if (result.Properties["badPasswordTime"].Count > 0 && result.Properties["badPasswordTime"][0].ToString() != "0")
                        {

                            long badpwdtime = (long)result.Properties["badPasswordTime"][0];
                            string badpwdtime1 = DateTime.FromFileTime(badpwdtime).ToString();
                            lblBadPasswordTime.Text = badpwdtime1.ToString();
                        }
                        else
                        {
                            lblBadPasswordTime.Text = "0";
                        }
                        if (result.Properties["badPwdCount"].Count > 0)
                        {
                            lblBadPasswordCount.Text = result.Properties["badPwdCount"][0].ToString();
                        }
                        else
                        {
                            lblBadPasswordCount.Text = "0";
                        }

                        //lblLockoutTime.Text=result.Properties["LockoutTime"][0].ToString();
                        if (result.Properties["LockoutTime"].Count > 0 && result.Properties["LockoutTime"][0].ToString() != "0")
                        {

                            long locouttime = (long)result.Properties["LockoutTime"][0];
                            string locouttime1 = DateTime.FromFileTime(locouttime).ToString();
                            lblLockoutTime.Text = locouttime1.ToString();
                        }
                        else
                        {
                            lblLockoutTime.Text = "0";
                        }


                        //lblPwdLastSet.Text = result.Properties["pwdLastSet"][0].ToString();
                        if (result.Properties["pwdLastSet"].Count > 0 && result.Properties["pwdLastSet"][0].ToString() != "0")
                        {

                            long pwdset = (long)result.Properties["pwdLastSet"][0];
                            string pwdset1 = DateTime.FromFileTime(pwdset).ToString();
                            lblPwdLastSet.Text = pwdset1.ToString();
                        }
                        else
                        {
                            lblPwdLastSet.Text = "0";
                        }

                    }
                    else
                        MessageBox.Show(" Error: Not found");
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }

            }
        }

        private void izbaciIzDomenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unjoin_domain f2 = new Unjoin_domain();
            f2.ShowDialog();
        }

        private void opcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuration f3 = new configuration();
            f3.ShowDialog();
        }

        private void slanjePorukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popup_message f4 = new Popup_message();
            f4.ShowDialog();
        }

        private void JoinToDomainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_form f5 = new Main_form();
            f5.ShowDialog();
        }

        private void remoteAssistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RDPViewer f6 = new RDPViewer();
            f6.ShowDialog();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void unlockAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            if (lstResults.SelectedItem==null)
            {
                MessageBox.Show(this, "Select user first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string l = lstResults.SelectedItem.ToString();
            PrincipalContext ctx = new PrincipalContext(ContextType.Domain,
                                         txtDC.Text,
                                         null,
                                         "@"+ txtDomainName.Text + @"\" + txtDomainAdminUser.Text,
                                         txtDomainAdminPwd.Text
                                         );
            UserPrincipal usr = UserPrincipal.FindByIdentity(ctx, l);
            usr.UnlockAccount();
            MessageBox.Show("User Account is now unlocked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstResults.SelectedItem == null)
            {
                MessageBox.Show(this, "Select user first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string l = lstResults.SelectedItem.ToString();
                string dc = txtDC.Text;
                string pwd = txtDomainAdminPwd.Text;
                string domain = txtDomainName.Text;
                string admin = txtDomainAdminUser.Text;

            

            Chg_pass frm = new Chg_pass(l, dc, pwd, domain,admin);
            frm.Show();

        }
        }
    }
       

