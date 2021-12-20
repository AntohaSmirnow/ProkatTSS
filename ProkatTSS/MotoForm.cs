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
    public partial class MotoForm : Form
    {
        public MotoForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
           // Application.Exit();
        }

        private void motoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.motoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kyrsachDataSet1);

        }

        private void MotoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet1.moto". При необходимости она может быть перемещена или удалена.
            this.motoTableAdapter.Fill(this.kyrsachDataSet1.moto);

        }
    }
}
