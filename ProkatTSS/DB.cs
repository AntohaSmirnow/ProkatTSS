using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProkatTSS
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=kyrsach");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
        
        public void GetRoutes(string type)
        {
            DataTable data = new DataTable();

            openConnection();

            string sql = String.Format("SELECT* FROM vehicles WHERE type = @type");
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.Add(@type, MySqlDbType.VarChar).Value = type;

            closeConnection();
        }


        public void RegUser(string login, string password, string name, string surname)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`,`surname` ) VALUES (@login, @pass, @name, @surname)", db.GetConnection());

            command.Parameters.Add("login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("surname", MySqlDbType.VarChar).Value = surname;
            // command.Parameters.Add("surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {

            }
                //MessageBox.Show("Аккаун был создан");
            else
            {

            }
               // MessageBox.Show("Аккаун не был создан");

            db.closeConnection();
        }
    }
}
