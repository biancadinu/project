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
            DataAccess da = new DataAccess();
            BindingSource bSource = new BindingSource();
            int time;
            time = Convert.ToInt32(getHour.Value) * 60 + Convert.ToInt32(getMinutes.Value);
            bSource.DataSource = da.getFreeRoomsByDateAndTime(dateTimePicker, time);
            rezervariTable.DataSource = bSource;
        }


        private void bookRoomButton_Click(object sender, EventArgs e)
        {
            int time;
            time = Convert.ToInt32(getHour.Value) * 60 + Convert.ToInt32(getMinutes.Value);
            DataAccess da = new DataAccess();
            DataTable dataTable = new DataTable();
            dataTable = da.getFreeRoomsByDateAndTime(dateTimePicker, time, nameOfRoomTextBox.Text.ToString());
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Room and Time are not compatible");
            }
            else
            {
                da.insertIntoRezervari(dateTimePicker, time, nameOfRoomTextBox.Text.ToString(), userData.Username);
                nameOfRoomTextBox.ResetText();
                getHour.ResetText();
                getMinutes.ResetText();
                dateTimePicker.ResetText();
                BindingSource bSource = new BindingSource();
                bSource.DataSource = da.getRezervari();
                rezervariTable.DataSource = bSource;


            }
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
