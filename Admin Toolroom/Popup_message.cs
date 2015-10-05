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
using System.Threading.Tasks;
using System.Configuration;

namespace Admin_Toolroom
{
    public partial class Popup_message : Form
    {
        public Popup_message()
        {
            InitializeComponent();
            this.txtDomainName.Text = Properties.Settings.Default.sDomainName;
            this.txtDomainAdminUser.Text = Properties.Settings.Default.sDomUsrName;
            this.txtDomainAdminPwd.Text = Properties.Settings.Default.sDomUsrPwd;

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
                        //remoteConnectionOptions.Authentication = AuthenticationLevel.Packet;
                        remoteConnectionOptions.Authentication = System.Management.AuthenticationLevel.PacketPrivacy;
                        remoteConnectionOptions.Username = txtDomainName.Text + @"\" + txtDomainAdminUser.Text;
                        remoteConnectionOptions.Password = txtDomainAdminPwd.Text;

                        managementScope = new ManagementScope(@"\\" + computer + @"\root\CIMV2", remoteConnectionOptions);
                        managementScope.Connect();
                        //MessageBox.Show(computer + " - Connected", computer + " - WMI obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        object[] ProcessToRun = {"msg * /time:"+txtExpireTime.Text+" "+txtPopupMsg.Text};
                        ManagementClass networkTask = new ManagementClass(managementScope, new ManagementPath("Win32_Process"), new ObjectGetOptions());
                        object popup = networkTask.InvokeMethod("Create", ProcessToRun);
                        //MessageBox.Show(popup.ToString());
                        uint popup1 = (uint)(popup);
                        if (popup1==0)
                        {
                            //MessageBox.Show(computer + " - Poruka je poslata", computer + " - WMI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lstLog.Items.Add(computer + " - Message sent -   Date:  " + DateTime.Now.ToShortDateString() + ";   Time: " + DateTime.Now.ToShortTimeString());
                        }
                        else
                        {
                            lstLog.Items.Add(computer + " - Message NOT sent -   Date:  " + DateTime.Now.ToShortDateString() + ";   Time: " + DateTime.Now.ToShortTimeString());
                        }

                    }
                    catch
                    {
                        //MessageBox.Show("WMI konekcija nije uspela!!!", "WMI obaveštenje - " + computer, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        lstLog.Items.Add(computer + " - WMI connection ERROR -   Date:  " + DateTime.Now.ToShortDateString() + ";   Time: " + DateTime.Now.ToShortTimeString());
                    }
                }
            }
        }
    }
}