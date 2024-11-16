namespace accesoadatos
{
    partial class OrdersMade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersMade));
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnCustomer = new DataGridViewTextBoxColumn();
            ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnProductID = new DataGridViewTextBoxColumn();
            ColumnUnitPrice = new DataGridViewTextBoxColumn();
            ColumnQuantityPerUnit = new DataGridViewTextBoxColumn();
            ColumnDiscount = new DataGridViewTextBoxColumn();
            ColumnProductCategoryName = new DataGridViewTextBoxColumn();
            ColumnCompanyName = new DataGridViewTextBoxColumn();
            ColumnExtendedPrice = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fhghToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(146, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 2;
            label1.Text = "Customer";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnCustomer, ColumnProductName, ColumnProductID, ColumnUnitPrice, ColumnQuantityPerUnit, ColumnDiscount, ColumnProductCategoryName, ColumnCompanyName, ColumnExtendedPrice });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1122, 481);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnCustomer
            // 
            ColumnCustomer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCustomer.DataPropertyName = "CustomerID";
            ColumnCustomer.HeaderText = "Customer";
            ColumnCustomer.MinimumWidth = 6;
            ColumnCustomer.Name = "ColumnCustomer";
            // 
            // ColumnProductName
            // 
            ColumnProductName.DataPropertyName = "ProductName";
            ColumnProductName.HeaderText = "ProductName";
            ColumnProductName.MinimumWidth = 6;
            ColumnProductName.Name = "ColumnProductName";
            ColumnProductName.Width = 194;
            // 
            // ColumnProductID
            // 
            ColumnProductID.DataPropertyName = "ProductID";
            ColumnProductID.HeaderText = "ProductID";
            ColumnProductID.MinimumWidth = 6;
            ColumnProductID.Name = "ColumnProductID";
            ColumnProductID.Visible = false;
            ColumnProductID.Width = 125;
            // 
            // ColumnUnitPrice
            // 
            ColumnUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopRight;
            ColumnUnitPrice.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnUnitPrice.HeaderText = "UnitPrice";
            ColumnUnitPrice.MinimumWidth = 6;
            ColumnUnitPrice.Name = "ColumnUnitPrice";
            ColumnUnitPrice.Width = 125;
            // 
            // ColumnQuantityPerUnit
            // 
            ColumnQuantityPerUnit.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopRight;
            ColumnQuantityPerUnit.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnQuantityPerUnit.HeaderText = "Quantity";
            ColumnQuantityPerUnit.MinimumWidth = 6;
            ColumnQuantityPerUnit.Name = "ColumnQuantityPerUnit";
            ColumnQuantityPerUnit.Width = 125;
            // 
            // ColumnDiscount
            // 
            ColumnDiscount.DataPropertyName = "Discount";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopRight;
            ColumnDiscount.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnDiscount.HeaderText = "Discount";
            ColumnDiscount.MinimumWidth = 6;
            ColumnDiscount.Name = "ColumnDiscount";
            ColumnDiscount.Width = 125;
            // 
            // ColumnProductCategoryName
            // 
            ColumnProductCategoryName.DataPropertyName = "CategoryName";
            ColumnProductCategoryName.HeaderText = "Product Category Name";
            ColumnProductCategoryName.MinimumWidth = 6;
            ColumnProductCategoryName.Name = "ColumnProductCategoryName";
            ColumnProductCategoryName.Width = 125;
            // 
            // ColumnCompanyName
            // 
            ColumnCompanyName.DataPropertyName = "CompanyName";
            ColumnCompanyName.HeaderText = "Pruduct Suppliers Company Name";
            ColumnCompanyName.MinimumWidth = 6;
            ColumnCompanyName.Name = "ColumnCompanyName";
            ColumnCompanyName.Width = 125;
            // 
            // ColumnExtendedPrice
            // 
            ColumnExtendedPrice.DataPropertyName = "ExtendedPrice";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopRight;
            ColumnExtendedPrice.DefaultCellStyle = dataGridViewCellStyle4;
            ColumnExtendedPrice.HeaderText = "ExtendedPrice";
            ColumnExtendedPrice.MinimumWidth = 6;
            ColumnExtendedPrice.Name = "ColumnExtendedPrice";
            ColumnExtendedPrice.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fhghToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1122, 49);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fhghToolStripMenuItem
            // 
            fhghToolStripMenuItem.Image = (Image)resources.GetObject("fhghToolStripMenuItem.Image");
            fhghToolStripMenuItem.Name = "fhghToolStripMenuItem";
            fhghToolStripMenuItem.Size = new Size(77, 45);
            fhghToolStripMenuItem.Text = "Atras";
            fhghToolStripMenuItem.Click += fhghToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(343, 73);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(956, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(775, 78);
            label2.Name = "label2";
            label2.Size = new Size(134, 28);
            label2.TabIndex = 7;
            label2.Text = "Total Orders ";
            // 
            // OrdersMade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 620);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrdersMade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdersMade";
            Load += OrdersMade_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private Button button1;
        private DataGridViewTextBoxColumn ColumnCustomer;
        private DataGridViewTextBoxColumn ColumnProductName;
        private DataGridViewTextBoxColumn ColumnProductID;
        private DataGridViewTextBoxColumn ColumnUnitPrice;
        private DataGridViewTextBoxColumn ColumnQuantityPerUnit;
        private DataGridViewTextBoxColumn ColumnDiscount;
        private DataGridViewTextBoxColumn ColumnProductCategoryName;
        private DataGridViewTextBoxColumn ColumnCompanyName;
        private DataGridViewTextBoxColumn ColumnExtendedPrice;
        private TextBox textBox1;
        private Label label2;
        private ToolStripMenuItem fhghToolStripMenuItem;
    }
}