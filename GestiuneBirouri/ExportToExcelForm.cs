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
    public partial class ExportToExcelForm : Form
    {
        UserData userData = new UserData();
        public ExportToExcelForm()
        {
            InitializeComponent();
        }
        public ExportToExcelForm(UserData userData)
        {
            this.userData = userData;
            InitializeComponent();
        }

        private void exportEverythingButton_Click(object sender, EventArgs e)
        {
            Exporter export = new Exporter();
            export.exportToEverything();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Exporter export = new Exporter();
            export.exportToEverythingAboutMyself(userData.Username);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exporter export = new Exporter();
            export.exportRoomsNotUsed(userData.Username);
        }
    }
}