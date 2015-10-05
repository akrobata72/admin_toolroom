using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;

namespace Admin_Toolroom
{
    public partial class Unjoin_domain : Form
    {
        public Unjoin_domain()
        {
            InitializeComponent();
            this.txtDomainName.Text = Properties.Settings.Default.sDomainName;
            this.txtLocalAdminUsr.Text = Properties.Settings.Default.sLocAdminName;
            this.txtLocalAdminPwd.Text = Properties.Settings.Default.sLocAdminPwd;
            this.txtWorkgroupName.Text = Properties.Settings.Default.sWorkgroupName;
            this.txtDomainAdminUser.Text = Properties.Settings.Default.sDomUsrName;
            this.txtDomainAdminPwd.Text = Properties.Settings.Default.sDomUsrPwd;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtImeRacunara1.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Please enter computer name or IP address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtImeRacunara1.Focus();
                return;
            }

            try
            {

                Ping ping = new Ping();
                PingReply pingReply = ping.Send(this.txtImeRacunara1.Text);
                if (pingReply.Status == IPStatus.Success)
                {
                    lstRacunara1.Items.Add(this.txtImeRacunara1.Text);
                    this.txtImeRacunara1.Clear();
                    this.txtImeRacunara1.Focus();
                }
            }
            catch
            {
                MessageBox.Show(txtImeRacunara1.Text + " - Computer is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtImeRacunara1.Focus();
                return;
            }

        }

        private void txtImeRacunara1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lstRacunara1.SelectedIndex >= 0)
            {
                this.lstRacunara1.Items.RemoveAt(this.lstRacunara1.SelectedIndex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.lstRacunara1.SelectedIndex >= 0)
            {
                txtImeRacunara1.Text = lstRacunara1.SelectedItem.ToString();
                this.lstRacunara1.Items.RemoveAt(this.lstRacunara1.SelectedIndex);
                this.txtImeRacunara1.Focus();
            }
        }

        private void btnUnjoinDomain_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();

            if (txtWorkgroupName.Text != "" && txtDomainName.Text !="")
            {
                ManagementScope managementScope;

                foreach (string computer in lstRacunara1.Items)
                {
                    //MessageBox.Show(computer);
                    try
                    {
                        ConnectionOptions remoteConnectionOptions = new ConnectionOptions();
                        remoteConnectionOptions.Impersonation = ImpersonationLevel.Impersonate;
                        remoteConnectionOptions.EnablePrivileges = true;
                        //remoteConnectionOptions.Authentication = AuthenticationLevel.Packet;
                        remoteConnectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
                        remoteConnectionOptions.Username = computer + @"\" + txtLocalAdminUsr.Text;
                        remoteConnectionOptions.Password = txtLocalAdminPwd.Text;

                        managementScope = new ManagementScope(@"\\" + computer + @"\root\CIMV2", remoteConnectionOptions);
                        managementScope.Connect();
                        lstLog.Items.Add(computer + " - Connected");

                        ManagementClass networkTask = new ManagementClass(managementScope, new ManagementPath("Win32_ComputerSystem"), new ObjectGetOptions());
                        ManagementObjectCollection mc = networkTask.GetInstances();

                        foreach (ManagementObject m in mc)
                        {

                            ManagementBaseObject myDomain = m.GetMethodParameters("UnjoinDomainOrWorkgroup");
                                                        
                            myDomain["FUnjoinOptions"] = 4;
                            myDomain["Password"] = txtDomainAdminPwd.Text;
                            myDomain["UserName"] = txtDomainName.Text + @"\" + txtDomainAdminUser.Text;
                            
                            ManagementBaseObject unjoin = m.InvokeMethod("UnjoinDomainOrWorkgroup", myDomain, null);
                            uint join2 = (uint)(unjoin.Properties["ReturnValue"].Value);
                            if (join2 == 0)

                            {
                                goto Nastavak;
                            }

                            else
                            {
                                string strErrorDescription = " ";
                                switch (join2)
                                {
                                    case 5:
                                        strErrorDescription = "Access is denied";
                                        break;
                                    case 87:
                                        strErrorDescription = "The parameter is incorrect";
                                        break;
                                    case 110:
                                        strErrorDescription = "The system cannot open the specified object";
                                        break;
                                    case 1323:
                                        strErrorDescription = "Unable to update the password";
                                        break;
                                    case 1326:
                                        strErrorDescription = "Logon failure: unknown username or bad password";
                                        break;
                                    case 1355:
                                        strErrorDescription = "The specified domain either does not exist or could not be contacted";
                                        break;
                                    case 2224:
                                        strErrorDescription = "The account already exists";
                                        break;
                                    case 2691:
                                        strErrorDescription = "The machine is already joined to the domain";
                                        break;
                                    case 2692:
                                        strErrorDescription = "The machine is not currently joined to a domain";
                                        break;
                                }
                                lstLog.Items.Add(computer + " " + strErrorDescription);
                                return;
                            }
                        }
                        Nastavak:
                        foreach (ManagementObject n in mc)
                        {
                            ManagementBaseObject myDomain1 = n.GetMethodParameters("JoinDomainOrWorkgroup");

                            

                                myDomain1["Password"] = txtLocalAdminPwd.Text;
                            myDomain1["UserName"] = computer + @"\" + txtLocalAdminUsr.Text;
                            myDomain1["Name"] = txtWorkgroupName.Text;
                            myDomain1["FJoinOptions"] = 2;
                            ManagementBaseObject unjoin1 = n.InvokeMethod("JoinDomainOrWorkgroup", myDomain1, null);
                            uint join3 = (uint)(unjoin1.Properties["ReturnValue"].Value);
                            if (join3 == 0)
                            {
                                lstLog.Items.Add(computer + " - Welcome to workgroup - " + txtWorkgroupName.Text);
                            }

                            else
                            {
                                string strErrorDescription = " ";
                                switch (join3)
                                {
                                    case 5:
                                        strErrorDescription = "Access is denied";
                                        break;
                                    case 87:
                                        strErrorDescription = "The parameter is incorrect";
                                        break;
                                    case 110:
                                        strErrorDescription = "The system cannot open the specified object";
                                        break;
                                    case 1323:
                                        strErrorDescription = "Unable to update the password";
                                        break;
                                    case 1326:
                                        strErrorDescription = "Logon failure: unknown username or bad password";
                                        break;
                                    case 1355:
                                        strErrorDescription = "The specified domain either does not exist or could not be contacted";
                                        break;
                                    case 2224:
                                        strErrorDescription = "The account already exists";
                                        break;
                                    case 2691:
                                        strErrorDescription = "The machine is already joined to the domain";
                                        break;
                                    case 2692:
                                        strErrorDescription = "The machine is not currently joined to a domain";
                                        break;
                                }
                                lstLog.Items.Add(computer + " " + strErrorDescription);
                                return;
                            }
                        }
                    


                        //Reboot

                        ObjectQuery objectQuery = null;
                        ManagementObjectSearcher objectSearcher = null;

                        objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                        objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
                        foreach (ManagementObject os in objectSearcher.Get())

                            if (chbReboot.Checked == true)
                            {
                                ManagementBaseObject outparam = os.InvokeMethod("Reboot", null, null);
                            }

                    }

                    catch
                    {
                        lstLog.Items.Add(computer + " - WMI connection is NOT success!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Must enter WORKGROUP and DOMAIN name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void opcijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuration f4 = new configuration();
            f4.ShowDialog();
        }
    }
}
