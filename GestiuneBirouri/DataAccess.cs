using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace GestiuneBirouri
{
    public class DataAccess
    {
        public UserData GetUserData(string username)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("connectionString")))
            {
                UserData userData = new UserData();
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("dbo.Utilizatori_GetByUsername @Username = '" + username + "'", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                userData.Username = dataTable.Rows[0][1].ToString();
                userData.Password = dataTable.Rows[0][2].ToString();
                userData.AngajatID = dataTable.Rows[0][3].ToString();
                DataTable dataTable2 = new DataTable();
                SqlCommand sqlCommand2 = new SqlCommand("dbo.Angajati_Utilizatori_GetInfo @username = '" + username + "'", connection);
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(sqlCommand);
                dataAdapter2.Fill(dataTable2);
                userData.DepartamentID = dataTable2.Rows[0][0].ToString();
                userData.Nume = dataTable2.Rows[0][1].ToString();
                userData.Prenume = dataTable2.Rows[0][2].ToString();
                return userData;
            }


        }

        public bool findCNP(string CNP, string username, string password)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("connectionString")))
            {
                UserData userData = new UserData();
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("dbo.Angajati_GetByCNP @CNP = '" + CNP + "'", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    insertUsernameAndPassword(username, password, dataTable.Rows[0][0].ToString());
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public DataTable getFreeRoomsByDateAndTime(DateTimePicker dateAndTime, int time, string nameOfRoom)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("connectionString")))
            {
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("dbo.GetFreeRoomsByName @dateStart ='" + dateAndTime.Value.Year.ToString() + "-" + dateAndTime.Value.Month.ToString() +
                                                                "-" + dateAndTime.Value.Day.ToString() + " " + dateAndTime.Value.Hour.ToString() + ":" +
                                                                                    dateAndTime.Value.Minute.ToString() + ":" + dateAndTime.Value.Second + "',@time = " + time + ",@name = '" + nameOfRoom + "'", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
        }

        public DataTable getRezervari()
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("connectionString")))
            {
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("dbo.GetRezervari", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable getRezervari(string numeSala)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("connectionString")))
            {
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("dbo.GetRezervariByNumeSala @numesala ='" + numeSala + "'", connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void insertIntoRezervari(DateTimePicker dateAndTime, int time, string nameOfRoom, string username)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("connectionString")))
            {
                SqlCommand sqlCommand = new SqlCommand("dbo.InsertInRezervari @dateStart ='" + dateAndTime.Value.Year.ToString() + "-" + dateAndTime.Value.Month.ToString() +
                                                                "-" + dateAndTime.Value.Day.ToString() + " " + dateAndTime.Value.Hour.ToString() + ":" +
                                                                                    dateAndTime.Value.Minute.ToString() + ":" + dateAndTime.Value.Second + "',@time = " + time + ",@name = '" + nameOfRoom + "' " +
                                                                                    ",@username = '" + username + "'", connection);
                try
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("The room " + nameOfRoom + " was booked successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public DataTable getFreeRoomsByDateAndTime(DateTimePicker dateAndTime, int time)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("connectionString")))
            {
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("dbo.GetFreeRooms @dateStart ='" + dateAndTime.Value.Year.ToString() + "-" + dateAndTime.Value.Month.ToString() +
                                                                "-" + dateAndTime.Value.Day.ToString() + " " + dateAndTime.Value.Hour.ToString() + ":" +
                                                                                    dateAndTime.Value.Minute.ToString() + ":" + dateAndTime.Value.Second + "',@time = " + time, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
        }


        private void insertUsernameAndPassword(string username, string password, string angajatID)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("connectionString")))
            {
                connection.Open();
                Encrypter passwordEncrypter = new Encrypter();
                UserData userData = new UserData();
                DataTable dataTable = new DataTable();
                SqlCommand sqlCommand = new SqlCommand("dbo.Angajati_InsertUser @username ='" + username + "' ,@password = '" + passwordEncrypter.encryptPassword(password) +
                    "' ,@angajatID =  " + angajatID, connection);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Utilizatorul exista deja");
                }

            }
        }
    }
}
