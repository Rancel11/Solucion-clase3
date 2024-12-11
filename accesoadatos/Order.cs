
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using System.ComponentModel;
using accesoadatos.Clases;
using System.Data;
using System.Data.SqlTypes;

using NorthwindContext;
using NORTHWIND.APLICACTION.Abstrations;
using NORTHWIND.INFRACTUTURE;



namespace accesoadatos
{
    public partial class Order : Form
    {
        private List<Productos> _listaProductos;

        private readonly NorthwindContext.NorthwindContext _context;
        public readonly IOrderRepository _orderRepository;

       

        public Order(NorthwindContext.NorthwindContext context, List<Productos> listaProductos, IOrderRepository orderRepository)

        {
            InitializeComponent();
            _context = context;
            dataGridView1.AutoGenerateColumns = false;
            _listaProductos = listaProductos;
            _orderRepository = orderRepository;

          
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.File("logs\\log-.txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();

            Log.Information("Formulario Order inicializado.");
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

            comboBoxCustomer.DataSource = _orderRepository.LoadCustomer();
            comboBoxCustomer.DisplayMember = nameof(Customer.CompanyName);
            comboBoxCustomer.ValueMember = nameof(Customer.CustomerID);

            comboBoxEmployee.DataSource = _orderRepository.LoadEnployees();
            comboBoxEmployee.ValueMember = "EmployeeID";
            comboBoxEmployee.DisplayMember = "FirstName";
            comboBoxEmployee.Refresh();

            comboBoxShipVIa.DataSource = _orderRepository.LoadShippers();
            comboBoxShipVIa.DisplayMember = nameof(Shipper.CompanyName);
            comboBoxShipVIa.ValueMember = nameof(Shipper.ShipperID);


           
            dataGridView1.Refresh();

        }



       

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menupricipal = new MenuPrincipal();
            menupricipal.Show();
            this.Hide();
        }

       


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea ingresar la orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {


                    var request = new NorthwindContext.Order();

                    request.ShipAddress = textBoxAddress.Text;
                    request.ShipCity = textBoxCity.Text;
                    request.ShipRegion = textBoxRegion.Text;
                    request.ShipName = textBoxShipName.Text;
                    request.Freight = decimal.Parse(textBoxFrieght.Text);
                    request.ShipPostalCode = textBoxPostalCode.Text;
                    request.ShipCountry = textBoxShipCountry.Text;

                    _orderRepository.CreateOrderValidator(request);




                    OrderDTO orderValidator = new OrderDTO
                    {
                        CustomerId = (string)comboBoxCustomer.SelectedValue,
                        EmployeeId = (int?)comboBoxEmployee.SelectedValue,
                        ShipVia = (int?)comboBoxShipVIa.SelectedValue,
                        ShipAddress = textBoxAddress.Text,
                        ShipCity = textBoxCity.Text,
                        ShipPostalCode = textBoxPostalCode.Text,
                        ShipCountry = textBoxShipCountry.Text,
                        ShipRegion = textBoxRegion.Text,
                        ShipName = textBoxShipName.Text,
                        FreightText = textBoxFrieght.Text
                    };


                   


                    var newOrder = new NorthwindContext.Order()
                    { 
                        CustomerID = orderValidator.CustomerId,
                        EmployeeID = orderValidator.EmployeeId.Value,
                        ShipVia = orderValidator.ShipVia.Value,
                        ShipAddress = orderValidator.ShipAddress,
                        ShipCity = orderValidator.ShipCity,
                        ShipPostalCode = orderValidator.ShipPostalCode,
                        ShipCountry = orderValidator.ShipCountry,
                        ShipRegion = orderValidator.ShipRegion,
                        ShipName = orderValidator.ShipName,
                        Freight = decimal.Parse(orderValidator.FreightText),
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now,
                        ShippedDate = DateTime.Now
                    };

                    newOrder.OrderDetails = new List<NorthwindContext.OrderDetail>();

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

                        var newOrderDetail = new NorthwindContext.OrderDetail
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

                    Log.Information("Orden ingresada exitosamente.");

                    MessageBox.Show("Orden ingresada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al ingresar la orden: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Fatal(ex, "Ocurrió un error al ingresar la orden.");
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
                var context = new NorthwindContext.NorthwindContext();
                var orderrepsoritory = new OrderRepository(context);

                var ordermade = new OrdersMade(context,orderrepsoritory);
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
            try
            {
                DialogResult result = MessageBox.Show("¿Deseas agregar alguna orden?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var context = new NorthwindContext.NorthwindContext();
                    var lista = new List<Productos>();
                    var orderrepository = new OrderRepository(context);
                    var orderdetails = new OrderDetails(context,lista,orderrepository); 

                   
                    if (orderdetails.ShowDialog() == DialogResult.OK)
                    {
                       
                        var listaProductos = orderdetails.ObtenerProductosGuardados(); 

                        if (listaProductos != null && listaProductos.Count > 0)
                        {
                            
                            foreach (var producto in listaProductos)
                            {
                                
                                dataGridView1.Rows.Add(producto.ProductID, producto.ProductName, producto.UnitPrice, producto.Quantity, producto.Discount,producto.CategoryName,producto.CategoryName, producto.ExtendedPrice);
                            }
                            MessageBox.Show("Productos guardados correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se han guardado productos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Operacion cancelada.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

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

        private void Filterorder()
        {


            var customer = (string)comboBoxCustomer.SelectedValue;



            var order = _context.orders

                .Where(o => o.CustomerID == customer)
                .Select(o => new
                {
                    o.CustomerID,
                    ShipAddress = o.ShipAddress ?? string.Empty,
                    ShipCity = o.ShipCity ?? string.Empty,
                    ShipPostalCode = o.ShipPostalCode,
                    ShipCountry = o.ShipCountry ?? string.Empty,
                    ShipName = o.ShipName ?? string.Empty,
                    ShipRegion = o.ShipRegion ?? string.Empty,

                }).FirstOrDefault();


            if (order != null)
            {
                textBoxShipName.Text = order.ShipName ?? string.Empty;
                textBoxAddress.Text = order.ShipAddress ?? string.Empty;
                textBoxCity.Text = order.ShipCity ?? string.Empty;
                textBoxPostalCode.Text = order.ShipPostalCode?.ToString() ?? string.Empty;
                textBoxShipCountry.Text = order.ShipCountry ?? string.Empty;
                textBoxRegion.Text = order.ShipRegion?.ToString() ?? string.Empty;
            }






        }







        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Filterorder();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al filtral la orden: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {




        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }


        

        public class OrderInputValidator : AbstractValidator<OrderDTO>
        {
            public OrderInputValidator()
            {
                RuleFor(x => x.CustomerId)
                    .NotEmpty().WithMessage("El cliente es obligatorio.");

                RuleFor(x => x.EmployeeId)
                    .NotNull().WithMessage("Debe seleccionar un empleado.")
                    .GreaterThan(0).WithMessage("Debe seleccionar un empleado válido.");

                RuleFor(x => x.ShipVia)
                    .NotNull().WithMessage("Debe seleccionar un método de envío.")
                    .GreaterThan(0).WithMessage("Debe seleccionar un método de envío válido.");

                RuleFor(x => x.ShipAddress)
                    .NotEmpty().WithMessage("La dirección de envío es obligatoria.");

                RuleFor(x => x.ShipCity)
                    .NotEmpty().WithMessage("La ciudad de envío es obligatoria.");
                
                RuleFor(x => x.ShipName)
                    .NotEmpty().WithMessage("El nombre del destinatario es obligatoria.");

                RuleFor(x => x.ShipPostalCode)
                    .NotEmpty().WithMessage("El código postal es obligatorio.");

                RuleFor(x => x.ShipCountry)
                    .NotEmpty().WithMessage("El país de envío es obligatorio.");
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView1.Update();
        }
        private void button2_Click_3(object sender, EventArgs e)
        {
          
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow) 
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }



    }
}
