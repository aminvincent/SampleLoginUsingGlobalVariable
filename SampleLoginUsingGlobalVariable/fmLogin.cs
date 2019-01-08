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
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private bool UserLoginCheck()
        {
            if (txtUserName.Text == "demo" && txtPassword.Text == "demo")
                return true;
            else
                return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (UserLoginCheck())
            {
                this.Hide();
                fmMain f = new fmMain();
                f.lblUserName.Text = txtUserName.Text; //untuk ngisi nilai dari lblusername di form main
                f.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
                
        }
    }
}
