﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admin_Toolroom
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.lblVersion.Text = String.Format("Program version: {0}", version);
        }

 
    }
}
