using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleLoginUsingGlobalVariable
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            /*
             * kita set nilai dari global variable username dengan value dr lblUserName, dengan ini brti nilai 
             * username akan selalu sama dengan lblUserName, ini juga bisa diisi dengan nilai dari databasenya. 
             * tinggal nanti where username = program.UserName
             */

            Program.UserName = lblUserName.Text; 
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.UserName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmChild f = new fmChild();
            f.ShowDialog();
        }
    }
}
