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
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Velo_Click(object sender, EventArgs e)
        {
            using (VeloForm vf = new VeloForm())
            {
                vf.ShowDialog();
            }
            //this.Hide();
            //VeloForm veloForm = new VeloForm();
            //veloForm.Show();

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

        private void Moto_Click(object sender, EventArgs e)
        {
            using (MotoForm mf = new MotoForm())
            {
                mf.ShowDialog();
            }
            //this.Hide();
            //MotoForm motoForm = new MotoForm();
            //motoForm.Show();
        }

        private void Giros_Click(object sender, EventArgs e)
        {
            using (GirosForm gf = new GirosForm())
            {
                gf.ShowDialog();
            }
            //this.Hide();
            //GirosForm giroForm = new GirosForm();
            //giroForm.Show();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddTsForm atf = new AddTsForm())
            {
                atf.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (RentTsForm rtf = new RentTsForm())
            {
                rtf.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SimulationForm SimForm = new SimulationForm();
            SimForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
