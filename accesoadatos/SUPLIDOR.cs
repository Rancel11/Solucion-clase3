using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using accesoadatos.Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace accesoadatos
{
    public partial class SUPLIDOR : Form
    {
        private readonly NorthwindContext _context;


        public SUPLIDOR(NorthwindContext context)
        {
            InitializeComponent();
            _context = context;
            


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

        private void ClearTextFields()
        {
            textBoxCompanyName.Clear();
            textBoxContactName.Clear();
            textBoxContactTitle.Clear();
            textBoxPhone.Clear();
        }



        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxCompanyName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxContactName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxContactTitle.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPhone.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var newSupplier = new Data.Supplier()
                {
                    CompanyName = textBoxCompanyName.Text,
                    ContactName = textBoxContactName.Text,
                    ContactTitle = textBoxContactTitle.Text,
                    Phone = textBoxPhone.Text
                };


                _context.Suppliers.Add(newSupplier);
                _context.SaveChanges();

                MessageBox.Show("El suplidor se ha insertado correctamente.");

                LoadComboBoxSuppliers();
                ClearTextFields();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al insertar el suplidor: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Fatal(ex,"Ocurrió un error al insertar el suplidor");

            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Vas a actualizar o eliminar un registro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {

                    int supplierId = (int)comboBox1.SelectedValue;


                    var supplier = _context.Suppliers
                        .Where(p => p.SupplierID == supplierId)
                        .Select(p => new
                        {
                            p.CompanyName,
                            p.ContactName,
                            p.ContactTitle,
                            p.Phone
                        }).FirstOrDefault();



                    if (supplier != null)
                    {

                        textBoxCompanyName.Text = supplier.CompanyName;
                        textBoxContactName.Text = supplier.ContactName;
                        textBoxContactTitle.Text = supplier.ContactTitle;
                        textBoxPhone.Text = supplier.Phone.ToString();

                        MessageBox.Show("Los datos del suplidor se han cargado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el suplidor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    ClearTextFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al insertar los datos del suplidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Fatal(ex,"Ocurrió un error al insertar los datos del suplidor");
            }
            finally
            {
                Log.CloseAndFlush();
            }

       


        }



    private void buttonupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Deseas actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int selectedSupplierId = (int)comboBox1.SelectedValue;
                    var supplier = _context.Suppliers.Find(selectedSupplierId);

                    if (supplier != null)
                    {

                        supplier.CompanyName = textBoxCompanyName.Text;
                        supplier.ContactName = textBoxContactName.Text;
                        supplier.ContactTitle = textBoxContactTitle.Text;
                        supplier.Phone = textBoxPhone.Text;

                        _context.Suppliers.Update(supplier);
                        _context.SaveChanges();
                        MessageBox.Show("Los datos se actualizaron correctamente.");

                        ClearTextFields();
                        LoadComboBoxSuppliers();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al actualizar el suplidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Fatal(ex,"currió un error al actualizar el suplidor");
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int selectedSupplierId = (int)comboBox1.SelectedValue;
                    var supplier = _context.Suppliers.Find(selectedSupplierId);

                    if (supplier != null)
                    {
                        _context.Suppliers.Remove(supplier);
                        _context.SaveChanges();

                        MessageBox.Show("El registro ha sido eliminado correctamente.");

                        LoadComboBoxSuppliers();
                        ClearTextFields();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al eliminar el suplidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log.Fatal(ex,"Ocurrió un error al eliminar el suplidor");
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


        private void SUPLIDOR_Load(object sender, EventArgs e)
        {
            LoadComboBoxSuppliers();
           
           
        }









        private void button1_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();

            
            var allsupplier = new AllSuppliers(context);
            allsupplier.Show();
            this.Hide();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonnew_Click(object sender, EventArgs e)
        {
            textBoxCompanyName.Clear();
            textBoxContactName.Clear();
            textBoxPhone.Clear();
            textBoxContactTitle.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            this.Hide();
            var category = new CATEGORIA(context);
            category.Show();
        }



        private void textBoxCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCompanyName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxCompanyName, "");
        }

        private void textBoxContactName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxContactName, "");
        }

        private void textBoxContactTitle_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxContactTitle, "");
        }

        private void textBoxPhone_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPhone, "");
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            var productsForm = new ACCESOADATOSFORM(context);
            productsForm.Show();
            this.Hide();

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var context = new NorthwindContext();
            var category = new CATEGORIA(context);
            category.Show();
            this.Hide();
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        public class Supplier
        {
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Phone { get; set; }
        }


        public class SupplierValidator : AbstractValidator<Supplier>
        {
            public SupplierValidator()
            {
                RuleFor(supplier => supplier.CompanyName).NotEmpty().WithMessage("El nombre de la compañía es obligatorio.").Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre de la compañía solo debe contener letras.");

                RuleFor(supplier => supplier.ContactName).NotEmpty().WithMessage("El nombre del contacto es obligatorio.").Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre de conctato solo debe contener letras.");

                RuleFor(supplier => supplier.ContactTitle).NotEmpty().WithMessage("El título del contacto es obligatorio.").Matches(@"^[a-zA-Z\s]+$").WithMessage("El titulo del conctato solo debe contener letras.");

                RuleFor(supplier => supplier.Phone).NotEmpty().WithMessage("El número de teléfono es obligatorio.").Matches(@"^\d+$").WithMessage("El número de teléfono solo debe contener dígitos.");
            }









        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}














































