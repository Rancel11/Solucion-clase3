﻿
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Windows.Forms;
using Serilog;
using static System.Runtime.InteropServices.JavaScript.JSType;
using NORTHWIND.INFRACTUTURE;
using NORTHWIND.APLICACTION.Abstrations;


namespace accesoadatos
{

    public partial class CATEGORIA : Form
    {
        private readonly NorthwindContext.NorthwindContext _context;
        private readonly ICategoryRepository _categoryRepository;
       

        public CATEGORIA(NorthwindContext.NorthwindContext context, ICategoryRepository categoryRepository)
        {

            InitializeComponent();
            _context = context;
            _categoryRepository = categoryRepository;

        }

     

      

        private void CATEGORIA_Load(object sender, EventArgs e)
        {

            comboBox1.DataSource = _categoryRepository.LoadCombobox();
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.Refresh();

        }


        private void Cleartextfilds()
        {
            textBoxCategoryName.Clear();
            textBoxDescription.Clear();
        }
       




        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {


                var request = new NorthwindContext.Category();
                request.CategoryName = textBoxCategoryName.Text;    
                request.Description = textBoxDescription.Text;

                _categoryRepository.CreateCategoryValidator(request);

                _categoryRepository.CreateCategory(request);
              

          

                MessageBox.Show("Los datos se insertaron correctamente");

                comboBox1.DataSource = _categoryRepository.LoadCombobox();



                Cleartextfilds();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al insertar la categoria : {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Fatal(ex,"Ocurrió un error al insertar la categoria");

            }
            finally
            {
                Log.CloseAndFlush();
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void buttonupdate_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int categoryId = (int)comboBox1.SelectedValue;

                   
                    var category = _context.Categories.Find(categoryId);

                    if (category != null)
                    {
                        
                        category.CategoryName = textBoxCategoryName.Text;
                        category.Description = textBoxDescription.Text;

                        
                        _categoryRepository.UpdateCategory(category);

                        comboBox1.DataSource = _categoryRepository.LoadCombobox();


                        MessageBox.Show("Los datos se actualizaron correctamente");

                        Cleartextfilds();
                    }
                    else
                    {
                        MessageBox.Show("La categoría no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar los datos de la categoria: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Fatal(ex,"Ocurrió un error al actualizar los datos de la categoria");
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

                    if (dialogResult == DialogResult.Yes)
                    {
                        int categoryId = (int)comboBox1.SelectedValue;

                        var category = _context.Categories
                            .Where(p => p.CategoryID == categoryId)
                            .Select(p => new
                            {
                                p.CategoryName,
                                p.Description
                            }).FirstOrDefault();


                        if (category != null)
                        {
                            textBoxCategoryName.Text = category.CategoryName;
                            textBoxDescription.Text = category.Description;

                            comboBox1.DataSource = _categoryRepository.LoadCombobox();



                            MessageBox.Show("Los datos de la categoria se han cargado correctamente.");


                        }
                        else
                        {
                            MessageBox.Show("No se encontró categoria", "Informacla ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {

                        textBoxCategoryName.Clear();
                        textBoxDescription.Clear();
                    }

                    textBoxCategoryName.Refresh();
                    textBoxDescription.Refresh();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al Filtrar los datos la categoria: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                Log.Fatal(ex,"Ocurrió un error al Filtrar los datos la categoria");
            }
            finally
            {
                Log.CloseAndFlush();
            }
           



        }





        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int categoryId = (int)comboBox1.SelectedValue;
                    var category = _context.Categories.Find(categoryId);

                    if (category != null)
                    {
                       _categoryRepository.DeleteCategory(category);
                        MessageBox.Show("El registro se eliminó correctamente");

                       comboBox1.DataSource = _categoryRepository.LoadCombobox();
                        Cleartextfilds();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Esta categoria no se puede eliminar, ya que esta enlasada a uno o varios productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Fatal(ex,"Ocurrio un error al eliminar el registro");
            }
            finally
            {
                Log.CloseAndFlush();
            }




        }

        private void buttonnew_Click(object sender, EventArgs e)
        {
            textBoxCategoryName.Clear();
            textBoxDescription.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var context = new NorthwindContext.NorthwindContext();
            var supplierRepository = new suppliersrReporitory(context);
            this.Hide();
            var supplidor = new SUPLIDOR(context, supplierRepository);

            supplidor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var categoryrepositorty = new Categoryrepository(context);
            var allcategory = new AllCategory(context,categoryrepositorty);
            allcategory.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var productreposoitory = new ProductRepository(context);
            var Products = new ACCESOADATOSFORM(context, productreposoitory);
            Products.Show();
            this.Hide();
        }

        private void textBoxCategoryName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxCategoryName, "");
        }

        private void textBoxDescription_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxDescription, "");
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var supplierRepository = new suppliersrReporitory(context);
            var supplier = new SUPLIDOR(context, supplierRepository);
            supplier.Show();
            this.Hide();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext.NorthwindContext();
            var productreposoitory = new ProductRepository(context);

            var productsForm = new ACCESOADATOSFORM(context, productreposoitory);
            productsForm.Show();
            this.Hide();
        }

        public class Category
        {
            public string CategoryName { get; set; }
            public string Description { get; set; }

        }

        public class CategoryValidator : AbstractValidator<Category>
        {
            public CategoryValidator()
            {
                RuleFor(Category => Category.CategoryName).NotEmpty().WithMessage("El nombre de la categoria es obligatoria.").Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre de la categoria solo debe contener letras.");

                RuleFor(Category => Category.Description).NotEmpty().WithMessage("La descripcion es obligatoria.").Matches(@"^[a-zA-Z\s]+$").WithMessage("La descripcion de la categoria solo debe contener letras.");

            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}