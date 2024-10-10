using Dapper;
using FluentValidation;
using Microsoft.Data.SqlClient;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static accesoadatos.SUPLIDOR;

namespace accesoadatos
{
    public partial class CATEGORIA : Form
    {

      
        public CATEGORIA()
        {
            InitializeComponent();

            
        }


      

        private void buttonInsert_Click(object sender, EventArgs e)
        {

           

            var Category = new Category
            {
                CategoryName = textBoxCategoryName.Text,
                Description = textBoxDescription.Text,
            };

            var validator = new CategoryValidator();
            var results = validator.Validate(Category);

            if (!results.IsValid)
            {
                string error = string.Join(Environment.NewLine, results.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(error, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Deseas insertar un nuevo registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(Conexion.Connectionstring))
                    {
                        connection.Open();

                        string insert = "INSERT INTO Categories (CategoryName, Description) VALUES(@CategoryName, @Description)";

                        using (SqlCommand cmd = new SqlCommand(insert, connection))
                        {
                            cmd.Parameters.AddWithValue("@CategoryName", textBoxCategoryName.Text);
                            cmd.Parameters.AddWithValue("@Description", textBoxDescription.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Los datos se insertaron correctamente");
                        }


                        comboBox1.DataSource = GetDataTable("SELECT * FROM Categories");
                        comboBox1.Refresh();


                        textBoxCategoryName.Clear();
                        textBoxDescription.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public DataTable GetDataTable(string sql, object parameters = null)


        {

           
            using (var connection = new SqlConnection(Conexion.Connectionstring))
            {
                connection.Open();


                var reader = connection.ExecuteReader(sql, parameters);


                var dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CATEGORIA_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = GetDataTable("SELECT * FROM Categories");
            comboBox1.ValueMember = "CategoryID";
            comboBox1.DisplayMember = "CategoryName";


            comboBox1.Refresh();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            
            
            DialogResult dialogResult = MessageBox.Show("¿Deseas actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(Conexion.Connectionstring))
                {
                    connection.Open();

                    string update = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description WHERE CategoryID = @CategoryID";

                    using (SqlCommand cmd = new SqlCommand(update, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", textBoxCategoryName.Text);
                        cmd.Parameters.AddWithValue("@Description", textBoxDescription.Text);
                        cmd.Parameters.AddWithValue("@CategoryID", int.Parse(comboBox1.SelectedValue.ToString()));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Los datos se actualizaron correctamente");
                    }

                    comboBox1.DataSource = GetDataTable("SELECT * FROM Categories");
                    comboBox1.Update();

                    textBoxCategoryName.Clear();
                    textBoxDescription.Clear();
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
           
            
            DialogResult dialogResult = MessageBox.Show("Vas a actualizar o eliminar un registro", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {

                DataTable dt = GetDataTable("SELECT CategoryName, Description FROM Categories WHERE CategoryID = @CategoryID", new
                {
                    CategoryID = int.Parse(comboBox1.SelectedValue.ToString())
                });

                MessageBox.Show("Los datos se filtraron correctamente");


                if (dt.Rows.Count > 0)
                {
                    textBoxCategoryName.Text = dt.Rows[0]["CategoryName"].ToString();
                    textBoxDescription.Text = dt.Rows[0]["Description"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            
            DialogResult dialogResult = MessageBox.Show("¿Deseas eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(Conexion.Connectionstring))
                {
                    connection.Open();

                    string delete = "DELETE FROM Categories WHERE CategoryID = @CategoryID";

                    using (SqlCommand cmd = new SqlCommand(delete, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", int.Parse(comboBox1.SelectedValue.ToString()));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("El registro se eliminó correctamente");
                    }


                    comboBox1.DataSource = GetDataTable("SELECT * FROM Categories");
                    comboBox1.Refresh();

                    textBoxCategoryName.Clear();
                    textBoxDescription.Clear();
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void buttonnew_Click(object sender, EventArgs e)
        {
            textBoxCategoryName.Clear();
            textBoxDescription.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var supplidor = new SUPLIDOR();

            supplidor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var allcategory = new AllCategory();
            allcategory.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Products = new ACCESOADATOSFORM();
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
            var supplier = new SUPLIDOR();
            supplier.Show();
            this.Hide();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var products = new ACCESOADATOSFORM();
            products.Show();
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
    }
}
