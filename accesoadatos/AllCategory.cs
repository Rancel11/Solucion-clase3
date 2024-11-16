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
    public partial class AllCategory : Form
    {
        public readonly NorthwindContext _context;
        public AllCategory(NorthwindContext context)
        {
            InitializeComponent();
            _context = context;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void AllCategory_Load(object sender, EventArgs e)
        {


            
            
            
           
            LoadDatagrid();







        }

        private void LoadDatagrid()
        {
            var category = _context.Categories
                .Select(c => new
                {
                    c.CategoryName,
                    c.Description
                }).ToList();

            dataGridView1.DataSource = category;
            dataGridView1.Refresh();
        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            var categorias = new CATEGORIA(context);
            categorias.Show();
            this.Hide();
        }
    }
}
