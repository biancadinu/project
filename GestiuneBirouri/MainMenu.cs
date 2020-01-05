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
    public partial class MainMenu : Form
    {
        UserData userData = new UserData();
        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(UserData userData)
        {
            
            this.userData = userData;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            BindingSource bSource = new BindingSource();
            bSource.DataSource = da.getRezervari(nameOfRoomTextBox.Text.ToString());
            rezervariTable.DataSource = bSource;
        }

        private void freeRoomsButton_Click(object sender, EventArgs e)
        {
            
        }


        private void bookRoomButton_Click(object sender, EventArgs e)
        {
           
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LogInForm openLogIn = new LogInForm();
            openLogIn.Show();
            this.Close();
        }

        private void exportToExcelInfo_Click(object sender, EventArgs e)
        {
            ExportToExcelForm openExportToExcelFormTab = new ExportToExcelForm(userData);
            openExportToExcelFormTab.Show();
        }
    }
}
