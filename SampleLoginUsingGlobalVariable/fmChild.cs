﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleLoginUsingGlobalVariable
{
    public partial class fmChild : Form
    {
        public fmChild()
        {
            InitializeComponent();
        }

        private void btnCheckTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.UserName);
        }
    }
}
