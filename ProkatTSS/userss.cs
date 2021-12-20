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
    public partial class userss : Form
    {
        public userss()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kyrsachDataSet1);

        }

        private void userss_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet2.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter1.Fill(this.kyrsachDataSet2.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kyrsachDataSet1.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.kyrsachDataSet1.users);

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
