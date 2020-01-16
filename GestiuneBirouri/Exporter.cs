using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
namespace GestiuneBirouri
{
    class Exporter
    {
        public void exportToEverything()
        {
            DataAccess da = new DataAccess();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "InfoSali";
            DataTable dtbl = new DataTable();
            dtbl = da.getAllInfo();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string stOutput = "Nume Sala \t Etaj \t Proiector \t CheckIn \t CheckOut \t Username \t Nume \t Prenume \t\r\n";
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    string stline = "";
                    for (int j = 0; j < dtbl.Columns.Count; j++)
                    {
                        stline = stline.ToString() + dtbl.Rows[i][j].ToString() + "\t";
                    }
                    stOutput += stline + "\r\n";
                }

                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                try
                {
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(output, 0, output.Length);
                    bw.Flush();
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


        }


        public void exportToEverything(int floor)
        {
            DataAccess da = new DataAccess();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "InfoSali on floor " + floor;
            DataTable dtbl = new DataTable();
            dtbl = da.getAllInfo(floor);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string stOutput = "Nume Sala \t Etaj \t Proiector \t CheckIn \t CheckOut \t Username \t Nume \t Prenume \t\r\n";
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    string stline = "";
                    for (int j = 0; j < dtbl.Columns.Count; j++)
                    {
                        stline = stline.ToString() + dtbl.Rows[i][j].ToString() + "\t";
                    }
                    stOutput += stline + "\r\n";
                }

                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                try
                {
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(output, 0, output.Length);
                    bw.Flush();
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


        }
        public void exportToEverything(string roomName)
        {
            DataAccess da = new DataAccess();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "InfoSali on room  " + roomName;
            DataTable dtbl = new DataTable();
            dtbl = da.getAllInfo(roomName);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string stOutput = "Nume Sala \t Etaj \t Proiector \t CheckIn \t CheckOut \t Username \t Nume \t Prenume \t\r\n";
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    string stline = "";
                    for (int j = 0; j < dtbl.Columns.Count; j++)
                    {
                        stline = stline.ToString() + dtbl.Rows[i][j].ToString() + "\t";
                    }
                    stOutput += stline + "\r\n";
                }

                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                try
                {
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(output, 0, output.Length);
                    bw.Flush();
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


        }


        public void exportToEverythingAboutMyself(string username)
        {
            DataAccess da = new DataAccess();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "InfoSali on me " + username;
            DataTable dtbl = new DataTable();
            dtbl = da.getAllInfoAboutMyself(username);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string stOutput = "Nume Sala \t Oras \t CheckIn \t CheckOut \t\r\n";
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    string stline = "";
                    for (int j = 0; j < dtbl.Columns.Count; j++)
                    {
                        stline = stline.ToString() + dtbl.Rows[i][j].ToString() + "\t";
                    }
                    stOutput += stline + "\r\n";
                }

                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                try
                {
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(output, 0, output.Length);
                    bw.Flush();
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


        }

        public void exportRoomsNotUsed(string username)
        {
            DataAccess da = new DataAccess();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "InfoSali on me " + username;
            DataTable dtbl = new DataTable();
            dtbl = da.getAllRoomsNotUsed(username);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string stOutput = "Nume Sala \t Oras \t\r\n";
                for (int i = 0; i < dtbl.Rows.Count; i++)
                {
                    string stline = "";
                    for (int j = 0; j < dtbl.Columns.Count; j++)
                    {
                        stline = stline.ToString() + dtbl.Rows[i][j].ToString() + "\t";
                    }
                    stOutput += stline + "\r\n";
                }

                Encoding utf16 = Encoding.GetEncoding(1254);
                byte[] output = utf16.GetBytes(stOutput);
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                try
                {
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(output, 0, output.Length);
                    bw.Flush();
                    bw.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


        }

    }
}