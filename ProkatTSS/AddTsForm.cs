using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProkatTSS
{
    public partial class AddTsForm : Form
    {
        public AddTsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DB db = new DB();
            
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `vehicles` (`number`, `type`, `name`) VALUES (@number, @type, @name)", db.GetConnection());
                command.Parameters.Add("number", MySqlDbType.VarChar).Value = NoTsField.Text;
                command.Parameters.Add("type", MySqlDbType.VarChar).Value = TypeTSField.Text;
                command.Parameters.Add("name", MySqlDbType.VarChar).Value = NameTsField.Text;
            
            
                db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("ТС добавлено в БД");
                    }
                    else
                    {
                        MessageBox.Show("не получилось");
                    }

                db.closeConnection();
            

            

        }
                
           
            
            

            
        
    }
}
