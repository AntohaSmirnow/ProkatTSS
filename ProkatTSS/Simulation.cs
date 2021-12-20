using MySql.Data.MySqlClient;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProkatTSS
{
    public partial class SimulationForm : Form
    {

        public SimulationForm()
        {
            InitializeComponent();
        }
        DB db = new DB();


        private bool working = false;
        private int countUser = 0;





        public void SimpleGenerateUser()
        {
            string login, password, name, surname;

            string[] Arrlogin = {"a14234", "Abdul228", "Axmed438", "Dudon336", "KireyaBitcoin" };
            string[] Arrpassword = {  "a14234", "Qu3jdh", "okH84N", "Pkijf94", "Fsndb72" };
            string[] Arrname = {  "a14234", "Denis", "Ilya", "Anton", "Nikita" };
            string[] ArrSurname = {  "a14234", "Smirnow", "Ivanov", "Petrov", "Sidorov" };
            

            Random random = new Random();





            while (working)
            {


                login = Arrlogin[random.Next(0, Arrlogin.Length - 1)];
                password = Arrpassword[random.Next(0, Arrpassword.Length - 1)];
                name = Arrname[random.Next(0, Arrname.Length - 1)];
                surname = ArrSurname[random.Next(0, Arrname.Length - 1)];



                countUser++;

                db.RegUser(login, password, name, surname);



                labelCount.Invoke(new Action(() => labelCount.Text = countUser.ToString()));


                Thread.Sleep(1000);



            }
        }


        private void Start()
        {
            working = true;
            Task.Run(() => SimpleGenerateUser());
        }

        private void Stop()
        {
            working = false;
        }

        




        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

       

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Stop();
        }
    }

    
}




