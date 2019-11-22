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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();
            DataAccess da = new DataAccess();
            try 
            {
                userData = da.GetUserData(usernameTextBox.Text.ToString());
                if (verifiyPassword(passwordTextBox.Text.ToString(), userData.Password))
                {
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Username not correct" + ex.ToString());
            }

            
            
        }

        private bool verifiyPassword(string passworToCheck, string databasePassword)
        {
            Encrypter passwordEncryption = new Encrypter();
            if(passwordEncryption.encryptPassword(passworToCheck) == databasePassword)
            {
                return true;
            }
            return false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm openRegisterTab = new RegisterForm();
            openRegisterTab.Show();
            this.Hide();
        }
    }
}
