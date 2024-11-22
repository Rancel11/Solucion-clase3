using accesoadatos.Data;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Windows.Forms;
using Serilog;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace accesoadatos
{

    public partial class CATEGORIA : Form
    {

        private readonly NorthwindContext _context;


        public CATEGORIA(NorthwindContext context)
        {

            InitializeComponent();
            _context = context;

        }

        private void CATEGORIA_Load(object sender, EventArgs e)
        {

            LoadComboBox();

        }


        private void Cleartextfilds()
        {
            textBoxCategoryName.Clear();
            textBoxDescription.Clear();
        }
        private void LoadComboBox()
        {

            var category = _context.Categories
                .Select(c => new
                {
                    c.CategoryID,
                    c.CategoryName,
                }).ToList();


            comboBox1.DataSource = category;
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.Refresh();
        }




        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxCategoryName.Text) || string.IsNullOrWhiteSpace(textBoxDescription.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newCategory = new Data.Category()
                {
                    CategoryName = textBoxCategoryName.Text,
                    Description = textBoxDescription.Text
                };
                _context.Categories.Add(newCategory);
                _context.SaveChanges();

                MessageBox.Show("Los datos se insertaron correctamente");

                LoadComboBox();


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

                        _context.Categories.Update(category);
                        _context.SaveChanges();
                        MessageBox.Show("Los datos se actualizaron correctamente");

                        LoadComboBox();
                        Cleartextfilds();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                            LoadComboBox();


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
                        _context.Categories.Remove(category);
                        _context.SaveChanges();
                        MessageBox.Show("El registro se eliminó correctamente");

                        LoadComboBox();
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

            var context = new NorthwindContext();
            this.Hide();
            var supplidor = new SUPLIDOR(context);

            supplidor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            var allcategory = new AllCategory(context);
            allcategory.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            var Products = new ACCESOADATOSFORM(context);
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
            var context = new NorthwindContext();
            var supplier = new SUPLIDOR(context);
            supplier.Show();
            this.Hide();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new NorthwindContext();
            var productsForm = new ACCESOADATOSFORM(context);
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