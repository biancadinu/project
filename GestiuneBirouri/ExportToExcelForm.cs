using System;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}
