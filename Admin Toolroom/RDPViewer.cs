using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RDPCOMAPILib;

namespace Admin_Toolroom
{
    public partial class RDPViewer : Form
    {
        public RDPViewer()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string file = Properties.Settings.Default.sRDPTxtPath;
            string text = File.ReadAllText(@"\\" + file);
            textBox1.Text = text.ToString();
            string Invitation = textBox1.Text;
            axRDPViewer1.Connect(Invitation, "User1", "");
            axRDPViewer1.SmartSizing = true;
            //axRDPViewer1.RequestColorDepthChange(16);
            //IRDPSRAPISessionProperties RdpProperties = axRDPViewer1.Properties as IRDPSRAPISessionProperties;
            //RdpProperties["session bpp"] = "16";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axRDPViewer1.Disconnect();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.Height = Screen.PrimaryScreen.Bounds.Height - 100;
        }
    }
}
