using accesoadatos.Data;
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
        public readonly NorthwindContext _context;
        public AllSuppliers(NorthwindContext context)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            _context = context;
        }

        private void AllSuppliers_Load(object sender, EventArgs e)
        {
            loaddatagridview();

        }
       

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            this.Hide();
            var supplierform = new SUPLIDOR(context);
            supplierform.Show();
        }

        private void loaddatagridview()
        {
            var suppliers = _context.Suppliers
                .Select(s=> new
                {
                    s.CompanyName,
                    s.ContactName,
                    s.ContactTitle,
                    s.Phone,
                }).ToList();

            dataGridView1 .DataSource = suppliers;
            dataGridView1.Refresh();


        }
    }
}
