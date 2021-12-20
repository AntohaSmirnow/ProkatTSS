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
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (RentTsForm rtf = new RentTsForm())
            {
                rtf.ShowDialog();
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
        

        private void Cars_Click(object sender, EventArgs e)
        {
            using (carsForm cF = new carsForm())
            {
                cF.ShowDialog();
            }
            // this.Hide();
            //carsForm carsForm = new carsForm();
            // carsForm.Show();
        }

        

        

        private void Velo_Click_1(object sender, EventArgs e)
        {
            using (VeloForm vf = new VeloForm())
            {
                vf.ShowDialog();
            }
        }

        private void Moto_Click_1(object sender, EventArgs e)
        {
            using (MotoForm mf = new MotoForm())
            {
                mf.ShowDialog();
            }
        }

        private void Giros_Click_1(object sender, EventArgs e)
        {
            using (GirosForm gf = new GirosForm())
            {
                gf.ShowDialog();
            }
        }
    }
}
