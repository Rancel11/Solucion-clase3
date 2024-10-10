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
    public partial class AllSuppliers : Form
    {
        public AllSuppliers()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void AllSuppliers_Load(object sender, EventArgs e)
        {
            var connection = new SqlConnection(Conexion.Connectionstring);
            connection.Open();


            dataGridView1.DataSource = GetDataTable("Select * from Suppliers");
            dataGridView1.Refresh();

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

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var supplierform = new SUPLIDOR();
            supplierform.Show();
        }
    }
}
