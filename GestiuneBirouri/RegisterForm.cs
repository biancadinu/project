using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneBirouri
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(isFormOk(usernameTextBox.Text.ToString(),passwordTextBox.Text.ToString()) == true)
            {
                DataAccess dataAccess = new DataAccess();
                if (dataAccess.findCNP(cnpTextBox.Text.ToString(), usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString()))
                {

                }
                else
                {
                    MessageBox.Show("CNP-ul este incorect");
                }
            }
            else
            {
                usernameTextBox.ResetText();
                passwordTextBox.ResetText();
                cnpTextBox.ResetText();
            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            LogInForm openLogInTab = new LogInForm();
            openLogInTab.Show();
            this.Hide();
        }

        private bool isFormOk(string username, string password/*,string CNP*/)
        {
            if (username.Length < 6)
            {
                MessageBox.Show("Username to short");
                return false;
            }
            else if (password.Length < 6)
            {
                MessageBox.Show("Password to short");
                return false;
            }
            return true;
        }
    }
}
