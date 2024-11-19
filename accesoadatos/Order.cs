using accesoadatos.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;


namespace accesoadatos
{
    public partial class Order : Form
    {
        private readonly NorthwindContext _context;


        BindingList<OrderDetalisData> _orderDetalis = new BindingList<OrderDetalisData>();

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

            DialogResult dialogResult = MessageBox.Show("¿Desea ingresar la orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
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
                        MessageBox.Show("Todos los campos son obligatorios y deben ingresarse  correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var newOrder = new Data.Order()
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
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now,
                        ShippedDate = DateTime.Now
                    };

                    newOrder.OrderDetails = new List<Data.OrderDetail>();

                    decimal subtotal = 0;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.IsNewRow) continue;
                        decimal unitPrice = Convert.ToDecimal(row.Cells[2].Value);
                        int quantity = Convert.ToInt16(row.Cells[3].Value);
                        float discount = Convert.ToSingle(row.Cells[4].Value);

                        decimal totalPrice = unitPrice * quantity * (1 - (decimal)discount);

                        subtotal += totalPrice;

                        textBoxSubtotal.Text = subtotal.ToString("C2");

                        var newOrderDetail = new Data.OrderDetail
                        {
                            ProductID = Convert.ToInt32(row.Cells[0].Value),
                            UnitPrice = Convert.ToDecimal(row.Cells[2].Value),
                            Quantity = Convert.ToInt16(row.Cells[3].Value),
                            Discount = Convert.ToSingle(row.Cells[4].Value),
                            Order = newOrder
                        };

                        newOrder.OrderDetails.Add(newOrderDetail);
                    }

                    decimal freight = 0;

                    if (!string.IsNullOrEmpty(textBoxFrieght.Text))
                    {
                        freight = Convert.ToDecimal(textBoxFrieght.Text);
                    }

                    decimal total = subtotal + freight;

                    textBoxTotal.Text = total.ToString("C2");

                    _context.orders.Add(newOrder);
                    _context.SaveChanges();

                    MessageBox.Show("Orden ingresada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al ingresar la orden: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Fatal(ex, "Error fatal en la aplicación.");
                }
                finally
                {
                    Log.CloseAndFlush();
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void textBoxFrieght_TextChanged(object sender, EventArgs e)
        {

        }



        private void buttonOrdersMade_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas cargar las orden ordenes hechas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var context = new NorthwindContext();

                var ordermade = new OrdersMade(context);
                ordermade.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Operacion Cancelada", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonAdditems_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("¿Deseas agregar alguna orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                var context = new NorthwindContext();

                var orderdetails = new OrderDetails(context);
                orderdetails.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Operacion Cancelada", "Operacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void AgregarProducto(int ProductID, string productName, decimal unitPrice, int quantity, float discount, string categoryName, string companyName, decimal extendedPrice)
        {

            dataGridView1.Rows.Add(
                ProductID,
                productName,
                unitPrice,
                quantity,
                discount,
                categoryName,
                companyName,
                extendedPrice
            );
            dataGridView1.Refresh();
          

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }




        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddress.Text) &&
                   string.IsNullOrWhiteSpace(textBoxCity.Text) &&
                   string.IsNullOrWhiteSpace(textBoxPostalCode.Text) &&
                   string.IsNullOrWhiteSpace(textBoxRegion.Text) &&
                   string.IsNullOrWhiteSpace(textBoxShipCountry.Text) &&
                   string.IsNullOrWhiteSpace(textBoxSubtotal.Text) &&
                   string.IsNullOrWhiteSpace(textBoxTotal.Text) &&
                   string.IsNullOrWhiteSpace(textBox1.Text) &&
                   string.IsNullOrWhiteSpace(textBoxShipName.Text))
            {
               
                MessageBox.Show("No hay orden para cancelar, todos los campos están vacíos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxAddress.Clear();
                textBoxCity.Clear();
                textBoxPostalCode.Clear();
                textBoxRegion.Clear();
                textBoxShipCountry.Clear();
                textBoxSubtotal.Clear();
                textBoxTotal.Clear();
                textBox1.Clear();
                textBoxShipName.Clear();

     
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show(" Orden Cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                textBoxAddress.Clear();
                textBoxCity.Clear();
                textBoxPostalCode.Clear();
                textBoxRegion.Clear();
                textBoxShipCountry.Clear();
                textBoxSubtotal.Clear();
                textBoxTotal.Clear();
                textBox1.Clear();
                textBoxShipName.Clear();

             
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
                
        
            







        }





        private void button1_Click_1(object sender, EventArgs e)
        {
           
          
        }
    }
}
