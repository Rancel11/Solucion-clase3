using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accesoadatos
{
    public partial class AllCategory : Form
    {
        public AllCategory()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void AllCategory_Load(object sender, EventArgs e)
        {
            var conncetion = new SqlConnection(Conexion.Connectionstring);

            conncetion.Open();


            dataGridView1.DataSource = GetDataTable("Select * from Categories");








        }
        public DataTable GetDataTable(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(Conexion.Connectionstring))
            {
                connection.Open();


                var reader = connection.ExecuteReader(sql, parameters);


                var dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var categorias = new CATEGORIA();
            categorias.Show();
            this.Hide();
        }
    }
}
