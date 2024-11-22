using accesoadatos.Data;
using accesoadatos.Models;
using Microsoft.EntityFrameworkCore;
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



    public partial class OrderDetails : Form
    {
        private readonly NorthwindContext _context;
      

        public OrderDetails(NorthwindContext context)
        {

            InitializeComponent();
            _context = context;
            dataGridView1.AutoGenerateColumns = false;
            
        }

     

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Productos = _context.Products
               .Include(p => p.OrderDetail)
               .Include(p => p.Supplier)
               .Include(p => p.Category)
               .Where(P => P.CategoryID == (int)comboBox1.SelectedValue)
               .Select(p => new
               {
                   p.ProductID,
                   p.ProductName,
                   p.Supplier.CompanyName,
                   p.Category.CategoryName,
                   p.UnitPrice,




               }).ToList();

            dataGridView1.DataSource = Productos;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            LoadDatagridview();
            LoadCombobox();
        }

        private void LoadDatagridview()
        {
            var Productos = _context.Products
                .Include(p => p.OrderDetail)
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .Distinct()
                .Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.Supplier.CompanyName,
                    p.Category.CategoryName,
                    p.UnitPrice,




                }).ToList();

            dataGridView1.DataSource = Productos;

        }
        private void LoadCombobox()
        {
            var categories = _context.Categories
                .Select(c => new
                {
                    c.CategoryID,
                    c.CategoryName
                }).ToList();

            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var order = new Order(_context);


            DialogResult result = MessageBox.Show("¿Deseas cargar la orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    int ProductID = Convert.ToInt32(row.Cells[0].Value);
                    string productName = Convert.ToString(row.Cells[1].Value);
                    string companyName = Convert.ToString(row.Cells[6].Value);
                    string categoryName = Convert.ToString(row.Cells[5].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells[2].Value);
                    int quantity = Convert.ToInt16(row.Cells[3].Value);
                    float discount = Convert.ToSingle(row.Cells[4].Value);

                    if (quantity <= 0)
                    {
                        MessageBox.Show("La cantidad debe ser mayor que cero.");
                        return;
                    }

                    if (discount < 0 || discount > 1)
                    {
                        MessageBox.Show("El descuento debe estar entre 0 y 1.");
                        return;
                    }

                    decimal extendedPrice = unitPrice * quantity * (1 - (decimal)discount);


                    order.AgregarProducto(ProductID, productName, unitPrice, quantity, discount, categoryName, companyName, extendedPrice);
                }
               
              
                order.Show();
  

                this.Close();
            }
            else
            {
                MessageBox.Show("Operacion Cancelada");
            }




        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();

            var orders = new Order(context);
            orders.Show();
            this.Hide();
        }
    }
}
