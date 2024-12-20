﻿using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using accesoadatos.Clases;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using NORTHWIND.APLICACTION.Abstrations;
using NORTHWIND.INFRACTUTURE;
using Serilog;


namespace accesoadatos
{
    public partial class SUPLIDOR : Form
    {
        private readonly NorthwindContext.NorthwindContext _context;
        public readonly Isuppliersreporitory _suppliersreporitory;

        public SUPLIDOR(NorthwindContext.NorthwindContext context, Isuppliersreporitory suppliersreporitory)
        {
            InitializeComponent();
            _context = context;
            _suppliersreporitory = suppliersreporitory;


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

                var request = new NorthwindContext.Supplier();
                request.CompanyName = textBoxCompanyName.Text;
                request.ContactTitle = textBoxContactTitle.Text;
                request.ContactName = textBoxContactName.Text;
                request.Phone = textBoxPhone.Text;

                _suppliersreporitory.CreateSuppliersvalidator(request);

                _suppliersreporitory.CreateSuppliers(request);

                MessageBox.Show("El suplidor se ha insertado correctamente.");

                comboBox1.DataSource = _suppliersreporitory.LoadComboboxfiltro();

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

                        _suppliersreporitory.UpdateSuppliers(supplier);

                        MessageBox.Show("Los datos se actualizaron correctamente.");

                        ClearTextFields();
                        comboBox1.DataSource = _suppliersreporitory.LoadComboboxfiltro();

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
                        _suppliersreporitory.DeleteSuppliers(supplier);

                        MessageBox.Show("El registro ha sido eliminado correctamente.");

                        comboBox1.DataSource = _suppliersreporitory.LoadComboboxfiltro();
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
            comboBox1.DataSource = _suppliersreporitory.LoadComboboxfiltro();
            comboBox1.ValueMember = "SupplierID";
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.Refresh();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var supplierRepository = new suppliersrReporitory(context);

            
           
            var allSuppliersForm = new AllSuppliers(context,supplierRepository);
            allSuppliersForm.Show();
            
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
            var context = new NorthwindContext.NorthwindContext();
            var CategoryRepository = new Categoryrepository(context);
            this.Hide();
            var category = new CATEGORIA(context,CategoryRepository);
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
            var context = new NorthwindContext.NorthwindContext();
            var productreposoitory = new ProductRepository(context);

            var productsForm = new ACCESOADATOSFORM(context, productreposoitory);
            productsForm.Show();
            this.Hide();

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {


            var context = new NorthwindContext.NorthwindContext();
            var categoryrepsoritory = new Categoryrepository(context);   
            var category = new CATEGORIA(context,categoryrepsoritory);
            category.Show();
            this.Hide();
        }






        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}














































