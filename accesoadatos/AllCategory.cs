
using Dapper;
using Microsoft.Data.SqlClient;
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
    public partial class AllCategory : Form
    {
        public readonly NorthwindContext.NorthwindContext _context;
        public readonly ICategoryRepository _categoryRepository;

        public AllCategory(NorthwindContext.NorthwindContext context, ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _context = context;
            _categoryRepository = categoryRepository;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void AllCategory_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = _categoryRepository.Allcaterory();
            dataGridView1.Refresh();
            
            
           
         







        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var categoryrepository = new Categoryrepository(context);
            var categorias = new CATEGORIA(context, categoryrepository);
            categorias.Show();
            this.Hide();
        }
    }
}
