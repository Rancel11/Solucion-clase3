using accesoadatos.Clases;

using Microsoft.EntityFrameworkCore;
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

   

    public partial class OrderDetails : Form
    {
        private readonly NorthwindContext.NorthwindContext _context;
        private List<Productos> _listaProductos;
        private readonly OrderRepository _orderRepository;

        public OrderDetails(NorthwindContext.NorthwindContext context, List<Productos> listaProductos, OrderRepository orderRepository)
        {

            InitializeComponent();
            _context = context;
            _listaProductos = listaProductos;
            dataGridView1.AutoGenerateColumns = false;
            _orderRepository = orderRepository;
            
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
            dataGridView1.DataSource = _orderRepository.LoadDatagridOrderdetails();
            
            comboBox1.DataSource = _orderRepository.LoadComboboxCategory();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
           
        }

    
        
        public List<Productos> ObtenerProductosGuardados()
        {
            return _listaProductos; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Deseas guardar estos productos seleccionados?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    List<Productos> listaProductos = new List<Productos>();

                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila.Selected)
                        {
                       
                            var productos = new Productos
                            {
                                ProductID = Convert.ToInt32(fila.Cells[0].Value),
                                ProductName = Convert.ToString(fila.Cells[1].Value),
                                CompanyName = Convert.ToString(fila.Cells[6].Value),
                                CategoryName = Convert.ToString(fila.Cells[5].Value),
                                UnitPrice = Convert.ToDecimal(fila.Cells[2].Value),
                                Quantity = Convert.ToInt16(fila.Cells[3].Value),
                                Discount = Convert.ToSingle(fila.Cells[4].Value),
                            };

                          
                            if (productos.Quantity <= 0)
                            {
                                MessageBox.Show("La cantidad debe ser mayor que cero.");
                                return;
                            }

                            if (productos.Discount < 0 || productos.Discount > 1)
                            {
                                MessageBox.Show("El descuento debe estar entre 0 y 1.");
                                return;
                            }

                            
                            productos.ExtendedPrice = productos.UnitPrice * productos.Quantity * (1 - (decimal)productos.Discount);
                            listaProductos.Add(productos);
                        }
                    }

                    if (listaProductos.Count > 0)
                    {
                       
                        this._listaProductos = listaProductos; 
                        this.DialogResult = DialogResult.OK;
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("No se seleccionaron productos.");
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




        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
           var lista = new List<Productos>();
            var orderrepository = new OrderRepository(context);
            var orders = new Order(context,lista,orderrepository);
            orders.Show();
            this.Hide();
        }
    }
}
