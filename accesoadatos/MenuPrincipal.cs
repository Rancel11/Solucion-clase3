
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using accesoadatos.Clases;
using NORTHWIND.INFRACTUTURE;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace accesoadatos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
           var lista = new List<Productos>();


            var Orders = new Order(context, lista);
            Orders.Show();
            this.Hide();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var supplierRepository = new suppliersrReporitory(context);

            var suppliers = new SUPLIDOR(context,supplierRepository);
            suppliers.Show();
            this.Hide();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var categoryrepository = new Categoryrepository(context);
            var category = new CATEGORIA(context,categoryrepository);
            category.Show();
            this.Hide();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var products = new ACCESOADATOSFORM(context);
            products.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var context = new NorthwindContext.NorthwindContext();

            var lista = new List<Productos>();




            var Orders = new Order(context,lista);
            Orders.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var supplierRepository = new suppliersrReporitory(context);
            var suppliers = new SUPLIDOR(context, supplierRepository);
            suppliers.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var categoryrepository = new Categoryrepository(context);
            var category = new CATEGORIA(context,categoryrepository);
            category.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var products = new ACCESOADATOSFORM(context);
            products.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
