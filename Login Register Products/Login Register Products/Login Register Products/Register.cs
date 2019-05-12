using Login_Register_Products.CLasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register_Products
{

    public partial class Register : Form
    {
        List<User> UsersList = new List<User>();
        User NewUser = new User();

        Regex onlyletters = new Regex(@"^[a-zA-Z]+$");
        Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        public Register()
        {
            InitializeComponent();
        }

        
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                //NewUser.UserName = RegUserName.Text;
                //NewUser.Password = RegPass.Text;
                //UsersList.Add(NewUser);
                new Products().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Fill out the form correctly and fully!");
            }
        }

        private void RegName_Validating(object sender, CancelEventArgs e)
        {
            if (RegName.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(RegName.Text, onlyletters.ToString()))
            {
                MessageBox.Show("Please insert name correctly");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void RegSurName_Validating(object sender, CancelEventArgs e)
        {
            if (RegSurName.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(RegSurName.Text, onlyletters.ToString()))
            {
                MessageBox.Show("Please insert surname correctly");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void RegUserName_Validating(object sender, CancelEventArgs e)
        {
            if (RegUserName.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void RegEmail_Validating(object sender, CancelEventArgs e)
        {
            if (RegEmail.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(RegEmail.Text, email.ToString()))
            {
                MessageBox.Show("Please insert email correctly");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void RegPass_Validating(object sender, CancelEventArgs e)
        {

            if (RegPass.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
