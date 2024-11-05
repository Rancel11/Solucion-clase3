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
    public partial class Order : Form
    {
        private readonly NorthwindContext _context;
        private int selectedProductId;
        private List<Data.OrderDetail> orderDetails = new List<Data.OrderDetail>();
        public Order(NorthwindContext context)

        {
            InitializeComponent();
            _context = context;
            dataGridView1.AutoGenerateColumns = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPostalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadEmployees();
            LoadDatagridview();
            LoadShippers();



        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menupricipal = new MenuPrincipal();
            menupricipal.Show();
            this.Hide();
        }

        private void LoadCustomer()
        {
            var customers = _context.customers
           .Select(c => new
           {
               c.CustomerID,
               c.CompanyName

           }).ToList();

            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = nameof(Customer.CustomerID);
            comboBoxCustomer.ValueMember = nameof(Customer.CustomerID);
            comboBoxCustomer.Refresh();






        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadEmployees()
        {




            var employees = _context.Employees
                .Select(e => new
                {
                    e.EmployeeID,
                    e.FirstName
                }).ToArray();
            comboBoxEmployee.DataSource = employees;
            comboBoxEmployee.ValueMember = "EmployeeID";
            comboBoxEmployee.DisplayMember = "FirstName";
            comboBoxEmployee.Refresh();

        }
        private void LoadDatagridview()
        {
            var orders = _context.orderDetails
                .Include(o => o.Product)
                .ThenInclude(p => p.Supplier)
                .Include(o => o.Product.Category)
                .Select(o => new
                {
                    
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

        private void LoadShippers()
        {
            var shippers = _context.shippers
                .Select(s => new
                {
                    s.ShipperID,
                    s.CompanyName
                }).ToList();

            comboBoxShipVIa.DataSource = shippers;
            comboBoxShipVIa.DisplayMember = nameof(Shipper.CompanyName);
            comboBoxShipVIa.ValueMember = nameof(Shipper.ShipperID);
        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(textBoxAddress.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCity.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPostalCode.Text) ||
                    string.IsNullOrWhiteSpace(textBoxRegion.Text) ||
                    string.IsNullOrWhiteSpace(textBoxShipCountry.Text) ||
                    comboBoxCustomer.SelectedValue == null ||
                    comboBoxEmployee.SelectedValue == null ||
                    comboBoxShipVIa.SelectedValue == null)
                {
                    MessageBox.Show("Todos los campos son obligatorios y deben seleccionarse correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                var newOrder = new Data.Order
                {
                    CustomerID = (string)comboBoxCustomer.SelectedValue,
                    EmployeeID = (int)comboBoxEmployee.SelectedValue,
                    ShipVia = (int)comboBoxShipVIa.SelectedValue,
                    ShipAddress = textBoxAddress.Text,
                    ShipCity = textBoxCity.Text,
                    ShipPostalCode = textBoxPostalCode.Text,
                    ShipCountry = textBoxShipCountry.Text,
                    ShipRegion = textBoxRegion.Text,
                    ShipName = textBoxShipName.Text,
                    Freight = decimal.Parse(textBoxFrieght.Text),
                    OrderDate = dateTimePicker1.Value,
                    RequiredDate = dateTimePicker2.Value,
                    ShippedDate = dateTimePicker3.Value
                };


                var neworderdetails = new Data.OrderDetail
                {

                    ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()),
                    UnitPrice = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value.ToString()),
                    Quantity = Convert.ToInt16(dataGridView1.CurrentRow.Cells[3].Value.ToString()),
                    Discount = Convert.ToSingle(dataGridView1.CurrentRow.Cells[4].Value.ToString()),

                    Order = newOrder

                };





                _context.orderDetails.Add(neworderdetails);
                _context.orders.Add(newOrder);
                _context.SaveChanges();


                MessageBox.Show("Orden ingresada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al ingresar la orden: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public class OrderDetalisData
        {
            private readonly OrderDetail _orderDetail;

            public int ProductID => _orderDetail.ProductID;

            public string ProductName => _orderDetail.Product.ProductName;

            public decimal UnitPrice => _orderDetail.UnitPrice;

            public short Quantity => _orderDetail.Quantity;

            public OrderDetail OrderDetail => _orderDetail;

            public OrderDetalisData(OrderDetail orderDetail)
            {
                this._orderDetail = orderDetail;
            }
        }






        private void buttonDELETE_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        



        }



    }
}
