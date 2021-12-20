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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        Point lastPoint;
        

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (logField.Text == "Admin" && passField.Text == "123")
            {
                this.Hide();
                MainFormAdmin mfa = new MainFormAdmin();
                mfa.Show();
            }
            else
            {

                String loginUser = logField.Text;
                String passUser = passField.Text;


                DB db = new DB();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainFormUser MainFormUser = new MainFormUser();
                    MainFormUser.Show();
                }
                else
                {
                    MessageBox.Show("No");
                }
            }

            //String loginUser = logField.Text;
            //String passUser = passField.Text;


            //DB db = new DB();

            //DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.GetConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
            //    this.Hide();
            //    MainFormAdmin MainFormAdmin = new MainFormAdmin();
            //    MainFormAdmin.Show();
            //}
                

            //else
            //    MessageBox.Show("No");

            
            //if (logField.Text != "admin")
            //{
            //    this.Hide();
            //    MainFormUser mfu = new MainFormUser();
            //    mfu.Show();
            //}
            //else
            //{
            //    this.Hide();
            //    MainFormUser mfu = new MainFormUser();
            //    mfu.Show();
            //}


        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
