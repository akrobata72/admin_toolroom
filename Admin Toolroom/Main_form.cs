﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
using System.IO;
using System.Diagnostics;

namespace Admin_Toolroom
{
    public partial class Main_form : Form
    {
        public Main_form()
        {

            InitializeComponent();
            //load settings
            this.txtDomainName.Text = Properties.Settings.Default.sDomainName;
            this.txtLocalAdminUsr.Text = Properties.Settings.Default.sLocAdminName;
            //this.txtLocalAdminPwd.Text = Properties.Settings.Default.sLocAdminPwd;
            this.txtDomainAdminUser.Text = Properties.Settings.Default.sDomUsrName;
            //this.txtDomainAdminPwd.Text = Properties.Settings.Default.sDomUsrPwd;
            this.txtDomainOU.Text = Properties.Settings.Default.sDomainOU;
            //set form name
            string version = Application.ProductVersion;
            this.Text = String.Format("Admin Toolroom {0}" + " - " + "JOIN COMPUTER TO DOMAIN", version);

            this.txtDomainAdminPwd.Text = Encoding.Unicode.GetString(Convert.FromBase64String(Properties.Settings.Default.sDomUsrPwd));
            this.txtLocalAdminPwd.Text = Encoding.Unicode.GetString(Convert.FromBase64String(Properties.Settings.Default.sLocAdminPwd));
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

        private void EnterBtnJoinDomain_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnJoinDomain_Click(sender, e);
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

        private void btnJoinDomain_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void btnSaveLogs_Click(object sender, EventArgs e)
        {
            if (lstRacunara1.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("UnjoinLog.txt"))
                {
                    foreach (string LstText in lstLog.Items)
                    {
                        TW.WriteLine(LstText);
                    }
                }

                Process.Start("UnjoinLog.txt");
            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                lstLog.Items.Clear();
            }));

            if (txtDomainName.Text != "")
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
                        remoteConnectionOptions.Authentication = AuthenticationLevel.Packet;
                        remoteConnectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
                        remoteConnectionOptions.Username = computer + @"\" + txtLocalAdminUsr.Text;
                        remoteConnectionOptions.Password = txtLocalAdminPwd.Text;

                        managementScope = new ManagementScope(@"\\" + computer + @"\root\CIMV2", remoteConnectionOptions);
                        managementScope.Connect();
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            lstLog.Items.Add(computer + " - Connected");
                        }));
                    ManagementClass networkTask = new ManagementClass(managementScope, new ManagementPath("Win32_ComputerSystem"), new ObjectGetOptions());
                        ManagementObjectCollection mc = networkTask.GetInstances();

                        foreach (ManagementObject m in mc)
                        {

                            ManagementBaseObject myDomain = m.GetMethodParameters("JoinDomainOrWorkgroup");

                            myDomain["Name"] = txtDomainName.Text;
                            myDomain["Password"] = txtDomainAdminPwd.Text;
                            myDomain["UserName"] = txtDomainName.Text + @"\" + txtDomainAdminUser.Text;
                            myDomain["AccountOU"] = txtDomainOU.Text;
                            myDomain["FJoinOptions"] = 3;
                            ManagementBaseObject join = m.InvokeMethod("JoinDomainOrWorkgroup", myDomain, null);

                            uint join2 = (uint)(join.Properties["ReturnValue"].Value);
                            if (join2 == 0)
                            {
                                this.Invoke(new MethodInvoker(delegate ()
                                {
                                    lstLog.Items.Add(computer + " - Welcome to the domain - " + txtDomainName.Text);
                                }));

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
                                this.Invoke(new MethodInvoker(delegate ()
                                {
                                    lstLog.Items.Add(computer + " " + strErrorDescription);
                                }));
                                return;
                            }
                        }


                    }

                    catch
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            lstLog.Items.Add(computer + " - WMI connection is NOT success!");
                        }));
                    }
                    backgroundWorker.ReportProgress(lstRacunara1.Items.Count);
                }

            }
            else
            {
                MessageBox.Show("Must enter domain name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Maximum = lstRacunara1.Items.Count;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Increment(1);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Job stopped!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.progressBar1.Value = 0;
            }
            else
            {
                MessageBox.Show("Job done!", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.progressBar1.Value = 0;
            }
        }
    }
}


