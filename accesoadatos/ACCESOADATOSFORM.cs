
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Windows.Forms;
using Serilog;
using NorthwindContext;
using Product = NorthwindContext.Product;
using NORTHWIND.INFRACTUTURE;

namespace accesoadatos
{


    public partial class ACCESOADATOSFORM : Form
    {
        private readonly NorthwindContext.NorthwindContext _context;
        private int selectedProductId;

        public NorthwindContext.NorthwindContext Context { get; }

        public ACCESOADATOSFORM(NorthwindContext.NorthwindContext context)
        {
            InitializeComponent();
            _context = context;
            dataGridView1.AutoGenerateColumns = false;

        }

      

        private void ACCESOADATOSFORM_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBoxSuppliers();
            LoadListBoxCategories();
        }

        private void LoadDataGridView()
        {
            var products = _context.Products
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.QuantityPerUnit,
                    p.UnitPrice,
                    p.Supplier.CompanyName,
                    p.Category.CategoryName,
                    p.CategoryID,
                    p.SupplierID
                }).ToList();

            dataGridView1.DataSource = products;
            dataGridView1.Refresh();
        }

        private void LoadComboBoxSuppliers()
        {
            var suppliers = _context.Suppliers
                 .Select(s => new
                 {
                     s.SupplierID,
                     s.CompanyName
                 }).ToList();


            comboBox1.DataSource = suppliers;
            comboBox1.ValueMember = "SupplierID";
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.Refresh();
        }

        private void LoadListBoxCategories()
        {
            var categories = _context.Categories
                .Select(c => new
                {
                    c.CategoryID,
                    c.CategoryName
                }).ToList();

            listBox1.DataSource = categories;
            listBox1.ValueMember = "CategoryID";
            listBox1.DisplayMember = "CategoryName";
            listBox1.Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var supplierId = (int)comboBox1.SelectedValue;
                var categoryId = (int)listBox1.SelectedValue;

                var filteredProducts = _context.Products
                    .Include(p => p.Supplier)
                    .Include(p => p.Category)
                    .Where(p => p.SupplierID == supplierId && p.CategoryID == categoryId)
                    .Select(p => new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.QuantityPerUnit,
                        p.UnitPrice,
                        p.Supplier.CompanyName,
                        p.Category.CategoryName,
                    }).ToList();

                dataGridView1.DataSource = filteredProducts;
                dataGridView1.Refresh();

                MessageBox.Show("Los datos se filtraron correctamente");
            }
         
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error inesperado al filtral los datos, verifique que haya selecionado la categoria o el suplidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Fatal(ex,"Se produjo un error inesperado al filtral los datos, verifique que haya selecionado la categoria o el suplidor");
            }
            finally
            {
                Log.CloseAndFlush();
            }


        }





        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            try
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductID == selectedProductId);

                if (product != null)
                {

                    product.ProductName = textBoxProductName.Text;
                    product.QuantityPerUnit = textBoxQuantityPerUnit.Text;
                    product.UnitPrice = decimal.Parse(textBoxUnitPrice.Text);
                    product.SupplierID = (int)comboBox1.SelectedValue;
                    product.CategoryID = (int)listBox1.SelectedValue;

                    _context.Products.Update(product);
                    _context.SaveChanges();

                    MessageBox.Show("Los datos se actualizaron correctamente");
                    LoadDataGridView();
                    ClearTextFields();
                }
                else
                {
                    MessageBox.Show("El producto no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                Log.Fatal(ex,"Ocurrio un error al actualizar el producto");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductID == selectedProductId);
                
                

                if (product != null)
                {
                   
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    MessageBox.Show("El producto ha sido eliminado correctamente.");

                    LoadDataGridView();
                    ClearTextFields();
                    selectedProductId = 0;
                }
                else
                {
                    MessageBox.Show("El producto no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el producto: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Fatal(ex,"Ocurrió un error al eliminar el producto");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }




        private void ClearTextFields()
        {
            textBoxProductName.Clear();
            textBoxQuantityPerUnit.Clear();
            textBoxUnitPrice.Clear();
        }





        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxProductName.Clear();
            textBoxQuantityPerUnit.Clear();
            textBoxUnitPrice.Clear();
            textBoxProductName.Focus();

        }

        public class ProductValidator : AbstractValidator<Product>
        {
            public ProductValidator()
            {
                RuleFor(product => product.ProductName)
                    .NotEmpty().WithMessage("El nombre del producto es obligatorio.")
                    .Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre del producto solo debe contener letras.");

                RuleFor(product => product.QuantityPerUnit)
                    .NotEmpty().WithMessage("La cantidad por unidad es obligatoria.");

                RuleFor(product => product.UnitPrice)
                    .NotEmpty().WithMessage("El precio único es obligatorio.")
                    .GreaterThan(0).WithMessage("El precio debe ser mayor que cero.");
            }
        }











        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }











        private void button3_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var supplierRepository = new suppliersrReporitory(context);
            var b = new SUPLIDOR(context, supplierRepository);

            b.Show();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var category = new CATEGORIA(context);
            category.Show();
            this.Hide();
        }




















        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            var products = _context.Products
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .Select(p => new
                {
                    p.ProductID,
                    p.ProductName,
                    p.QuantityPerUnit,
                    p.UnitPrice,
                    p.Supplier.CompanyName,
                    p.Category.CategoryName
                }).ToList();


            dataGridView1.DataSource = products;
            dataGridView1.Refresh();
        }




        private void textBoxProductName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxProductName, "");
        }

        private void textBoxQuantityPerUnit_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxQuantityPerUnit, "");
        }

        private void textBoxUnitPrice_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxUnitPrice, "");
        }






        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var supplierRepository = new suppliersrReporitory(context);
            var suplidor = new SUPLIDOR(context, supplierRepository);
            suplidor.Show();
            this.Hide();

        }



        public static class Configuracion
        {
            public static string connectionstring => Program.configuration.GetConnectionString("NorthwindConnectionString");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedProductId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                textBoxProductName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxQuantityPerUnit.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxUnitPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }
            catch { }
        }

        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBoxProductName.Text) || string.IsNullOrWhiteSpace(textBoxQuantityPerUnit.Text) || string.IsNullOrWhiteSpace(textBoxUnitPrice.Text) ||
                    comboBox1.SelectedValue == null ||
                    listBox1.SelectedValue == null)
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var newProduct = new Product
                {
                    ProductName = textBoxProductName.Text,
                    QuantityPerUnit = textBoxQuantityPerUnit.Text,
                    UnitPrice = decimal.Parse(textBoxUnitPrice.Text),
                    SupplierID = (int)comboBox1.SelectedValue,
                    CategoryID = (int)listBox1.SelectedValue
                };

                _context.Products.Add(newProduct);
                _context.SaveChanges();

                MessageBox.Show("El producto ha sido insertado correctamente.");


                LoadDataGridView();
                ClearTextFields();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error al insertar el producto: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Fatal(ex, "Ocurrió un error al insertar el producto");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }



}







