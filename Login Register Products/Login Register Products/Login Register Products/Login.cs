using Login_Register_Products.CLasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Login_Register_Products
{
       
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void SignInBtn_CLick(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
             if(UserNameBox.Text.ToLower() == "sattar@code.edu.az" && PasswordBox.Text.ToLower() == "test123")
                {
                    new Products().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Please register");
                }
                
            }
            else
            {
                MessageBox.Show("Fill out all the form");
            }
        }
        private void UserNameBox_Validating(object sender, CancelEventArgs e)
        {
            if(UserNameBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void PasswordBox_Validating(object sender, CancelEventArgs e)
        {
            if (PasswordBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
