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
    public partial class carsForm : Form
    {
        public carsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void autoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.autoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kyrsachDataSet1);

        }

        private void carsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet2.vehicles". При необходимости она может быть перемещена или удалена.
            this.vehiclesTableAdapter.Fill(this.kyrsachDataSet2.vehicles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet1.auto". При необходимости она может быть перемещена или удалена.
            this.autoTableAdapter.Fill(this.kyrsachDataSet1.auto);

        }
    }
}
