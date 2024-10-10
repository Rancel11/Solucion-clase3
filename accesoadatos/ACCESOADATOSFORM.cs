using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using FluentValidation;
using static accesoadatos.SUPLIDOR;
using Serilog.Core;
using Serilog;
using Microsoft.Extensions.Configuration;

namespace accesoadatos

{



    public partial class ACCESOADATOSFORM : Form

        
    {





        public ACCESOADATOSFORM()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ACCESOADATOSFORM_Load(object sender, EventArgs e)
        {
            



            dataGridView1.DataSource = GetDataTable("SELECT a.ProductName,a.QuantityPerUnit,a.UnitPrice,b.CompanyName,c.CategoryName FROM Products a inner join Suppliers b on a.SupplierID = b.SupplierID inner join Categories c on a.CategoryID = c.CategoryID ");
            dataGridView1.Refresh();


            comboBox1.DataSource = GetDataTable("SELECT * FROM Suppliers");
            comboBox1.ValueMember = "SupplierID";
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.Refresh();


            listBox1.DataSource = GetDataTable("SELECT * FROM Categories");
            listBox1.ValueMember = "CategoryID";
            listBox1.DisplayMember = "CategoryName";
            listBox1.Refresh();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                textBoxProductName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxQuantityPerUnit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBoxUnitPrice.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
           

            dataGridView1.DataSource = GetDataTable("SELECT a.ProductName,a.QuantityPerUnit,a.UnitPrice,b.CompanyName,c.CategoryName FROM Products a inner join Suppliers b on a.SupplierID = b.SupplierID inner join Categories c on a.CategoryID = c.CategoryID WHERE b.SupplierID = @SupplierID AND c.CategoryID = @CategoryID", new
            {
                SupplierID = int.Parse(comboBox1.SelectedValue.ToString()),
                CategoryID = int.Parse(listBox1.SelectedValue.ToString())
            });
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {




          

            var products = new Products
            {
                ProductName = textBoxProductName.Text,
                QuantityPerUnit = textBoxQuantityPerUnit.Text,
                UnitPrice =  textBoxUnitPrice.Text

            };

            var validator = new ProductValidator();
            var results = validator.Validate(products);

            if (!results.IsValid)
            {
                string error = string.Join(Environment.NewLine, results.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(error, "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (textBoxProductName.Text == "" || textBoxQuantityPerUnit.Text == "" || textBoxUnitPrice.Text == "")
                {
                    MessageBox.Show("Dejate algunos campos vacios");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Deseas insertar un nuevo registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        
                        using (var connection = new SqlConnection(Conexion.Connectionstring))
                        {
                            connection.Open();

                            string insert = "INSERT INTO Products (ProductName, QuantityPerUnit, UnitPrice,SupplierID,CategoryID) VALUES(@ProductName, @QuantityPerUnit, @UnitPrice,@SupplierID,@CategoryID)";

                            using (SqlCommand cmd = new SqlCommand(insert, connection))
                            {
                                cmd.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                                cmd.Parameters.AddWithValue("@QuantityPerUnit", textBoxQuantityPerUnit.Text);
                                cmd.Parameters.AddWithValue("@UnitPrice", textBoxUnitPrice.Text);
                                cmd.Parameters.AddWithValue("@SupplierID", int.Parse(comboBox1.SelectedValue.ToString()));
                                cmd.Parameters.AddWithValue("@CategoryID", int.Parse(listBox1.SelectedValue.ToString()));

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Los datos se insertaron correctamente");
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }


      


            dataGridView1.DataSource = GetDataTable("SELECT a.ProductName,a.QuantityPerUnit,a.UnitPrice,b.CompanyName,c.CategoryName FROM Products a inner join Suppliers b on a.SupplierID = b.SupplierID inner join Categories c on a.CategoryID = c.CategoryID ");
            dataGridView1.Refresh();

            textBoxProductName.Clear();
            textBoxQuantityPerUnit.Clear();
            textBoxUnitPrice.Clear();


            comboBox1.Update();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)

        {


            


            DialogResult result = MessageBox.Show("¿Deseas actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(Conexion.Connectionstring))
                {


                    connection.Open();




                    string update = "UPDATE Products SET ProductName = @ProductName, QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice WHERE SupplierID = @SupplierID AND CategoryID = @CategoryID";

                    using (SqlCommand cmd = new SqlCommand(update, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                        cmd.Parameters.AddWithValue("@QuantityPerUnit", textBoxQuantityPerUnit.Text);
                        cmd.Parameters.AddWithValue("@UnitPrice", textBoxUnitPrice.Text);
                        cmd.Parameters.AddWithValue("@SupplierID", int.Parse(comboBox1.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@CategoryID", int.Parse(listBox1.SelectedValue.ToString()));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Los datos se actualizaron correctamente");




                textBoxProductName.Clear();
                textBoxQuantityPerUnit.Clear();
                textBoxUnitPrice.Clear();
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.DataSource = GetDataTable("SELECT a.ProductName,a.QuantityPerUnit,a.UnitPrice,b.CompanyName,c.CategoryName FROM Products a inner join Suppliers b on a.SupplierID = b.SupplierID inner join Categories c on a.CategoryID = c.CategoryID ");
            dataGridView1.Refresh();




        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxProductName.Clear();
            textBoxQuantityPerUnit.Clear();
            textBoxUnitPrice.Clear();
            textBoxProductName.Focus();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

           

            DialogResult result = MessageBox.Show("¿Deseas eliminar este registro registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(Conexion.Connectionstring))
                {
                    connection.Open();

                    string delete = "DELETE FROM Products WHERE ProductName = @ProductName AND SupplierID = @SupplierID AND CategoryID = @CategoryID";

                    using (SqlCommand cmd = new SqlCommand(delete, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", textBoxProductName.Text);
                        cmd.Parameters.AddWithValue("@SupplierID", int.Parse(comboBox1.SelectedValue.ToString()));
                        cmd.Parameters.AddWithValue("@CategoryID", int.Parse(listBox1.SelectedValue.ToString()));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Los datos se eliminaron correctamente.");
                }

                dataGridView1.DataSource = GetDataTable("SELECT * FROM Products");
                dataGridView1.Refresh();

                textBoxProductName.Clear();
                textBoxQuantityPerUnit.Clear();
                textBoxUnitPrice.Clear();
                comboBox1.Update();
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.DataSource = GetDataTable("SELECT a.ProductName,a.QuantityPerUnit,a.UnitPrice,b.CompanyName,c.CategoryName FROM Products a inner join Suppliers b on a.SupplierID = b.SupplierID inner join Categories c on a.CategoryID = c.CategoryID ");
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var b = new SUPLIDOR();

            b.Show();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var category = new CATEGORIA();
            category.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDataTable("SELECT a.ProductName,a.QuantityPerUnit,a.UnitPrice,b.CompanyName,c.CategoryName FROM Products a inner join Suppliers b on a.SupplierID = b.SupplierID inner join Categories c on a.CategoryID = c.CategoryID ");
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

        public bool ValidateForm()
        {
            bool Isvalid = true;


            if (textBoxProductName.Text.Trim() == "")
            {
                errorProvider1.SetError(textBoxProductName, "Se requiere que este campo no este vacio");
                Isvalid = false;
            }

            if (textBoxQuantityPerUnit.Text.Trim() == "")
            {
                errorProvider1.SetError(textBoxQuantityPerUnit, "Se requiere que este campo no este vacio");
                Isvalid = false;
            }

            if (textBoxUnitPrice.Text.Trim() == "")
            {
                errorProvider1.SetError(textBoxUnitPrice, "Se requiere que este campo no este vacio");
                Isvalid = false;
            }



            return Isvalid;

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var suplidor = new SUPLIDOR();
            suplidor.Show();
            this.Hide();

        }

        public class Products
        {
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public string UnitPrice { get; set; }

        }

        public class ProductValidator : AbstractValidator<Products>
        {
            public ProductValidator()
            {
                RuleFor(Products => Products.ProductName).NotEmpty().WithMessage("El nombre del producto es obligatorio").Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre de la categoria solo debe contener letras.");
                RuleFor(Products => Products.QuantityPerUnit).NotEmpty().WithMessage("La cantidad por unidad es obligatoria");
                RuleFor(Products=> Products.UnitPrice).NotEmpty().WithMessage("El precio unico es obligatorio").Matches(@"^\d+$").WithMessage("El precio unico solo debe tener numeros o digitos");
            }
        }

        public static class Configuracion
        {
            public static string connectionstring => Program.configuration.GetConnectionString("NorthwindConnectionString");
        }
    }



}
