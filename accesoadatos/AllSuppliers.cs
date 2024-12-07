
using Dapper;
using Microsoft.Data.SqlClient;
using NORTHWIND.APLICACTION;
using NORTHWIND.APLICACTION.Abstrations;
using NORTHWIND.INFRACTUTURE;
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
        public readonly NorthwindContext.NorthwindContext _context;
        public readonly Isuppliersreporitory _suppliersreporitory;
        

        public AllSuppliers(NorthwindContext.NorthwindContext context, Isuppliersreporitory suppliersreporitory)
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            _context = context;
            _suppliersreporitory = suppliersreporitory;
        }

    
     

        private void AllSuppliers_Load(object sender, EventArgs e)
        {
          dataGridView1.DataSource = _suppliersreporitory.GetSuppliers();

        }
       

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var supplierRepository = new suppliersrReporitory(context);
            this.Hide();
            var supplierform = new SUPLIDOR(context,supplierRepository);
            supplierform.Show();
        }

    }
}
