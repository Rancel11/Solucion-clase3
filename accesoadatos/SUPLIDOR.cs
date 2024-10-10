using Azure.Messaging;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;

namespace accesoadatos
{
    public partial class SUPLIDOR : Form
    {
        public SUPLIDOR()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            var supplier = new Supplier
            {
                CompanyName = textBoxCompanyName.Text,
                ContactName = textBoxContactName.Text,
                ContactTitle = textBoxContactTitle.Text,
                Phone = textBoxPhone.Text
            };

            var validator = new SupplierValidator();
            var results = validator.Validate(supplier);

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

                        string insert = "INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Phone) VALUES(@CompanyName, @ContactName, @ContactTitle, @Phone)";

                        using (SqlCommand cmd = new SqlCommand(insert, connection))
                        {
                            cmd.Parameters.AddWithValue("@CompanyName", textBoxCompanyName.Text);
                            cmd.Parameters.AddWithValue("@ContactName", textBoxContactName.Text);
                            cmd.Parameters.AddWithValue("@ContactTitle", textBoxContactTitle.Text);
                            cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Los datos se insertaron correctamente");
                        }


                        comboBox1.DataSource = GetDataTable("SELECT * FROM Suppliers");
                        comboBox1.Refresh();

                        textBoxCompanyName.Clear();
                        textBoxContactName.Clear();
                        textBoxPhone.Clear();
                        textBoxContactTitle.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();


            var allsupplier = new AllSuppliers();
            allsupplier.Show();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void SUPLIDOR_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = GetDataTable("SELECT * FROM Suppliers");
            comboBox1.ValueMember = "SupplierID";
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.Refresh();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Vas a actualizar o eliminar un registro", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                DataTable dt = GetDataTable("Select CompanyName,ContactName,ContactTitle,Phone from Suppliers where SupplierID = @SupplierID", new
                {
                    SupplierID = int.Parse(comboBox1.SelectedValue.ToString())
                });

                MessageBox.Show("Los datos se filtraron correctamente");

                if (dt.Rows.Count > 0)
                {

                    textBoxCompanyName.Text = dt.Rows[0]["CompanyName"].ToString();
                    textBoxContactName.Text = dt.Rows[0]["ContactName"].ToString();
                    textBoxContactTitle.Text = dt.Rows[0]["ContactTitle"].ToString();
                    textBoxPhone.Text = dt.Rows[0]["Phone"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            else
            {
                textBoxCompanyName.Text = "";
                textBoxContactName.Text = "";
                textBoxContactTitle.Text = "";
                textBoxPhone.Text = "";

            }




            textBoxCompanyName.Refresh();
            textBoxContactName.Refresh();
            textBoxContactTitle.Refresh();
            textBoxPhone.Refresh();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Deseas actualizar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(Conexion.Connectionstring))
                {
                    connection.Open();

                    string update = "UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, Phone = @Phone WHERE SupplierID = @SupplierID";

                    using (SqlCommand cmd = new SqlCommand(update, connection))
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", textBoxCompanyName.Text);
                        cmd.Parameters.AddWithValue("@ContactName", textBoxContactName.Text);
                        cmd.Parameters.AddWithValue("@ContactTitle", textBoxContactTitle.Text);
                        cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                        cmd.Parameters.AddWithValue("@SupplierID", int.Parse(comboBox1.SelectedValue.ToString()));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Los datos se actualizaron correctamente");
                    }
                }


                textBoxCompanyName.Clear();
                textBoxContactName.Clear();
                textBoxPhone.Clear();
                textBoxContactTitle.Clear();


                comboBox1.Update();
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
                using (var connection = new SqlConnection(Conexion.Connectionstring))
                {
                    connection.Open();

                    string delete = "DELETE FROM Suppliers WHERE CompanyName = @CompanyName AND SupplierID = @SupplierID";

                    using (SqlCommand cmd = new SqlCommand(delete, connection))
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", textBoxCompanyName.Text);
                        cmd.Parameters.AddWithValue("@SupplierID", int.Parse(comboBox1.SelectedValue.ToString()));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Los datos se eliminaron correctamente");
                    }
                }


                comboBox1.DataSource = GetDataTable("SELECT * FROM Suppliers");
                comboBox1.Refresh();


                textBoxCompanyName.Clear();
                textBoxContactName.Clear();
                textBoxPhone.Clear();
                textBoxContactTitle.Clear();
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
            this.Hide();
            var category = new CATEGORIA();
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
            var products = new ACCESOADATOSFORM();

            products.Show();
            this.Hide();

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var category = new CATEGORIA();
            category.Show();
            this.Hide();
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
    }
}
