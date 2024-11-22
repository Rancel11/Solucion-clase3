using accesoadatos.Data;
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
    public partial class OrdersMade : Form
    {
        private readonly NorthwindContext _context;
        private  string seletecustomer;
        private int orderID;

        public OrdersMade(NorthwindContext context)
        {
            InitializeComponent();
            _context = context;
            dataGridView1.AutoGenerateColumns = false;

        }

        private void OrdersMade_Load(object sender, EventArgs e)
        {
            LoadDatagridview();
            LoadCustomer();







        }
        private void LoadCustomer()
        {
            var customers = _context.customers
           .Select(c => new
           {
               c.CustomerID,
               c.CompanyName

           }).ToList();

            comboBox1.DataSource = customers;
            comboBox1.DisplayMember = nameof(Customer.CompanyName);
            comboBox1.ValueMember = nameof(Customer.CustomerID);
            comboBox1.Refresh();


        }


        private void LoadDatagridview()
        {
            var customerCount = _context.orders
                .Select(o => o.CustomerID)
                .Count();


            textBox1.Text = customerCount.ToString();

            var orders = _context.orderDetails
                .Include(o => o.Order)
                .Include(o => o.Product)
                .ThenInclude(p => p.Supplier)
                .Include(o => o.Product.Category)
                .Select(o => new
                {
                    o.OrderID,
                    o.Order.CustomerID,
                    o.ProductID,
                    o.Product.UnitPrice,
                    o.Quantity,
                    o.Discount,
                    ProductName = o.Product.ProductName,
                    CompanyName = o.Product.Supplier.CompanyName,
                    CategoryName = o.Product.Category.CategoryName,
                    ExtendedPrice = o.Product.UnitPrice * o.Quantity * (1 - (decimal)o.Discount)

                }).ToList();

            dataGridView1.DataSource = orders;
            dataGridView1.Refresh();
        }

        private void fffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            var order = new Order(context);
            order.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customerId = (string)comboBox1.SelectedValue;

            var orderDetailsCount = _context.orderDetails
                .Where(od => od.Order.CustomerID == customerId)
                .Count();

            textBox1.Text = orderDetailsCount.ToString();

            var orders = _context.orderDetails
                .Include(od => od.Order)
                .Include(od => od.Product)
                .ThenInclude(p => p.Supplier)
                .Include(od => od.Product.Category)
                .Where(od => od.Order.CustomerID == customerId)
                .Select(od => new
                {
                    od.OrderID,
                    od.Order.CustomerID,
                    od.ProductID,
                    od.Product.UnitPrice,
                    od.Quantity,
                    Discount = od.Discount,
                    ProductName = od.Product.ProductName,
                    CompanyName = od.Product.Supplier.CompanyName,
                    CategoryName = od.Product.Category.CategoryName,
                    ExtendedPrice = od.Product.UnitPrice * od.Quantity * (1 - (decimal)(od.Discount))
                })
                .ToList();


            dataGridView1.DataSource = orders;
            dataGridView1.Refresh();
        }

        private void fhghToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            var order = new Order(context);
            order.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    
                    var orderDetailsToDelete = _context.orderDetails
                        .Where(od => od.OrderID == orderID)
                        .ToList();

               
                    foreach (var orderDetail in orderDetailsToDelete)
                    {
                        _context.orderDetails.Remove(orderDetail);
                    }

                    _context.SaveChanges();

            
                    transaction.Commit();

                    MessageBox.Show("Los detalles de la orden se han eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Ocurrió un error al intentar eliminar los detalles de la orden: " + ex.Message);
                }

                
                LoadDatagridview();
                dataGridView1.Refresh();
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                seletecustomer = (string)dataGridView1.CurrentRow.Cells[0].Value;
                orderID = (int)dataGridView1.CurrentRow.Cells[9].Value;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar la orden: " + ex.Message);
            }
        }
    }
}
