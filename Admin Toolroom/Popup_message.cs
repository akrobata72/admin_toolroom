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
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Diagnostics;

namespace Admin_Toolroom
{
    public partial class Popup_message : Form
    {
        public Popup_message()
        {
            InitializeComponent();
            //load settings
            this.txtDomainName.Text = Properties.Settings.Default.sDomainName;
            this.txtDomainAdminUser.Text = Properties.Settings.Default.sDomUsrName;
            //this.txtDomainAdminPwd.Text = Properties.Settings.Default.sDomUsrPwd;
            //set form name
            string version = Application.ProductVersion;
            this.Text = String.Format("Admin Toolroom {0}" + " - " + "SEND POPUP MESSAGE", version);
            //decode and load password
            this.txtDomainAdminPwd.Text = Encoding.Unicode.GetString(Convert.FromBase64String(Properties.Settings.Default.sDomUsrPwd));


            //default settings for computer list
            string settings = Properties.Settings.Default.sCompList;
            string[] settings1 = settings.Split(new[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            lstRacunara1.Items.AddRange(settings1.ToArray());

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtImeRacunara1.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Please enter computer name or IP adress!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void EnterbtnSend_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendPopupMsg_Click(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lstRacunara1.SelectedIndex >= 0)
            {
                this.lstRacunara1.Items.RemoveAt(this.lstRacunara1.SelectedIndex);

                if (lstRacunara1.Items.Count > 0)
                {
                    lstRacunara1.Focus();
                    lstRacunara1.SelectedIndex = 0;
                }
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

        private void btnSendPopupMsg_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Getting Text from Clip board
                string s = Clipboard.GetText();
                //Parsing criteria: New Line
                string[] lines = s.Split('\n');
                foreach (string ln in lines)
                {
                    lstRacunara1.Items.Add(ln.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lstRacunara1.SelectedItems.Clear();
                for (int i = 0; i < lstRacunara1.Items.Count; i++)
                {
                    lstRacunara1.SetSelected(i, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstRacunara1.Items.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                foreach (object row in lstRacunara1.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();
                }
                sb.Remove(sb.Length - 1, 1); // Just to avoid copying last empty row
                Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                // we use this collection to keep all the Selected Items
                List<object> selectedItemList = new List<object>();
                foreach (object row in lstRacunara1.SelectedItems)
                {
                    sb.Append(row.ToString());
                    sb.AppendLine();

                    // Keep on adding selected item into a new List of Object
                    selectedItemList.Add(row);
                }
                sb.Remove(sb.Length - 1, 1);    // Just to avoid copying last empty row
                Clipboard.SetData(System.Windows.Forms.DataFormats.Text, sb.ToString());
                // Removing selected items from the ListBox
                foreach (object ln in selectedItemList)
                {
                    lstRacunara1.Items.Remove(ln);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            if (txtDomainName.Text != "")
            {
                ManagementScope managementScope;

                foreach (string computer in lstRacunara1.Items)
                {
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        //MessageBox.Show(computer);
                        try
                        {


                            ConnectionOptions remoteConnectionOptions = new ConnectionOptions();
                            remoteConnectionOptions.Impersonation = ImpersonationLevel.Impersonate;
                            remoteConnectionOptions.EnablePrivileges = true;
                            //remoteConnectionOptions.Authentication = AuthenticationLevel.Packet;
                            remoteConnectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
                            remoteConnectionOptions.Username = txtDomainName.Text + @"\" + txtDomainAdminUser.Text;
                            remoteConnectionOptions.Password = txtDomainAdminPwd.Text;

                            managementScope = new ManagementScope(@"\\" + computer + @"\root\CIMV2", remoteConnectionOptions);
                            managementScope.Connect();
                            //MessageBox.Show(computer + " - Connected", computer + " - WMI obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            object[] ProcessToRun = { "msg * /time:" + txtExpireTime.Text + " " + txtPopupMsg.Text };
                            ManagementClass networkTask = new ManagementClass(managementScope, new ManagementPath("Win32_Process"), new ObjectGetOptions());
                            object popup = networkTask.InvokeMethod("Create", ProcessToRun);
                            //MessageBox.Show(popup.ToString());
                            uint popup1 = (uint)(popup);
                            if (popup1 == 0)
                            {
                                this.Invoke(new MethodInvoker(delegate ()
                                {
                                    //MessageBox.Show(computer + " - Poruka je poslata", computer + " - WMI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lstLog.Items.Add(computer + " - Message sent -   Date:  " + DateTime.Now.ToShortDateString() + ";   Time: " + DateTime.Now.ToShortTimeString());

                                }));
                            }

                            else
                            {
                              this.Invoke(new MethodInvoker(delegate ()
                            {
                                lstLog.Items.Add(computer + " - Message NOT sent -   Date:  " + DateTime.Now.ToShortDateString() + ";   Time: " + DateTime.Now.ToShortTimeString());
                            }));
                            }

                        }
                        catch
                        {
                            //MessageBox.Show("WMI konekcija nije uspela!!!", "WMI obaveštenje - " + computer, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                lstLog.Items.Add(computer + " - WMI connection ERROR -   Date:  " + DateTime.Now.ToShortDateString() + ";   Time: " + DateTime.Now.ToShortTimeString());
                            }));
                        }
                    }
                    backgroundWorker.ReportProgress(lstRacunara1.Items.Count);

                }
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

        private void btnSaveLogs_Click(object sender, EventArgs e)
        {
            if (lstRacunara1.Items.Count > 0)
            {
                using (TextWriter TW = new StreamWriter("SendMsgLog.txt"))
                {
                    foreach (string LstText in lstLog.Items)
                    {
                        TW.WriteLine(LstText);
                    }
                }

                Process.Start("SendMsgLog.txt");
            }
        }

 
    }
}
