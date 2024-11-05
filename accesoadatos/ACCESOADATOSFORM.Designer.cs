namespace accesoadatos
{
    partial class ACCESOADATOSFORM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            ColumnProductID = new DataGridViewTextBoxColumn();
            ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnCompanyName = new DataGridViewTextBoxColumn();
            ColumnCategoryName = new DataGridViewTextBoxColumn();
            ColumnQtyPerUnit = new DataGridViewTextBoxColumn();
            ColumnUnitprice = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            buttonInsert = new Button();
            textBoxUnitPrice = new TextBox();
            textBoxQuantityPerUnit = new TextBox();
            textBoxProductName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            menuToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnProductID, ColumnProductName, ColumnCompanyName, ColumnCategoryName, ColumnQtyPerUnit, ColumnUnitprice });
            dataGridView1.Location = new Point(12, 435);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(861, 507);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // ColumnProductName
            // 
            ColumnProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnProductName.DataPropertyName = "ProductName";
            ColumnProductName.HeaderText = "ProductName";
            ColumnProductName.MinimumWidth = 6;
            ColumnProductName.Name = "ColumnProductName";
            // 
            // ColumnCompanyName
            // 
            ColumnCompanyName.DataPropertyName = "CompanyName";
            ColumnCompanyName.HeaderText = "CompanyName";
            ColumnCompanyName.MinimumWidth = 6;
            ColumnCompanyName.Name = "ColumnCompanyName";
            ColumnCompanyName.Width = 125;
            // 
            // ColumnCategoryName
            // 
            ColumnCategoryName.DataPropertyName = "CategoryName";
            ColumnCategoryName.HeaderText = "CategoryName";
            ColumnCategoryName.MinimumWidth = 6;
            ColumnCategoryName.Name = "ColumnCategoryName";
            ColumnCategoryName.Width = 125;
            // 
            // ColumnQtyPerUnit
            // 
            ColumnQtyPerUnit.DataPropertyName = "QuantityPerUnit";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            ColumnQtyPerUnit.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnQtyPerUnit.HeaderText = "QuantityPerUnit";
            ColumnQtyPerUnit.MinimumWidth = 6;
            ColumnQtyPerUnit.Name = "ColumnQtyPerUnit";
            ColumnQtyPerUnit.Width = 125;
            // 
            // ColumnUnitprice
            // 
            ColumnUnitprice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            ColumnUnitprice.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnUnitprice.HeaderText = "UnitPrice";
            ColumnUnitprice.MinimumWidth = 6;
            ColumnUnitprice.Name = "ColumnUnitprice";
            ColumnUnitprice.Width = 125;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 104);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Location = new Point(21, 60);
            button3.Name = "button3";
            button3.Size = new Size(143, 29);
            button3.TabIndex = 5;
            button3.Text = "All Products";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(683, 36);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 4;
            label3.Text = "Suplidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(618, 36);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 3;
            label2.Text = "Filtrar";
            // 
            // button1
            // 
            button1.Location = new Point(961, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(777, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            label1.Click += label1_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 9F);
            buttonDelete.Location = new Point(859, 216);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 9F);
            buttonUpdate.Location = new Point(734, 216);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Controls.Add(buttonInsert);
            groupBox1.Controls.Add(textBoxUnitPrice);
            groupBox1.Controls.Add(textBoxQuantityPerUnit);
            groupBox1.Controls.Add(textBoxProductName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1087, 277);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert Product";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(970, 215);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Font = new Font("Segoe UI", 9F);
            buttonInsert.Location = new Point(611, 216);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(104, 29);
            buttonInsert.TabIndex = 2;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click_1;
            // 
            // textBoxUnitPrice
            // 
            textBoxUnitPrice.Font = new Font("Segoe UI", 10.8F);
            textBoxUnitPrice.Location = new Point(787, 92);
            textBoxUnitPrice.Name = "textBoxUnitPrice";
            textBoxUnitPrice.Size = new Size(155, 31);
            textBoxUnitPrice.TabIndex = 1;
            textBoxUnitPrice.Validated += textBoxUnitPrice_Validated;
            // 
            // textBoxQuantityPerUnit
            // 
            textBoxQuantityPerUnit.Font = new Font("Segoe UI", 12F);
            textBoxQuantityPerUnit.Location = new Point(296, 168);
            textBoxQuantityPerUnit.Name = "textBoxQuantityPerUnit";
            textBoxQuantityPerUnit.Size = new Size(154, 34);
            textBoxQuantityPerUnit.TabIndex = 1;
            textBoxQuantityPerUnit.Validated += textBoxQuantityPerUnit_Validated;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Font = new Font("Segoe UI", 10.8F);
            textBoxProductName.Location = new Point(296, 92);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(155, 31);
            textBoxProductName.TabIndex = 1;
            textBoxProductName.Validated += textBoxProductName_Validated;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(604, 92);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 0;
            label6.Text = "UnitPrice";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(113, 174);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 0;
            label5.Text = "QuantityPerUnit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(113, 92);
            label4.Name = "label4";
            label4.Size = new Size(133, 28);
            label4.TabIndex = 0;
            label4.Text = "ProductName";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(888, 435);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 504);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, atrasToolStripMenuItem, suppliersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1111, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            atrasToolStripMenuItem.Size = new Size(83, 24);
            atrasToolStripMenuItem.Text = "Category";
            atrasToolStripMenuItem.Click += atrasToolStripMenuItem_Click;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(84, 24);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // ACCESOADATOSFORM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 956);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ACCESOADATOSFORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ACCESOADATOSFORM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBoxUnitPrice;
        private TextBox textBoxQuantityPerUnit;
        private TextBox textBoxProductName;
        private Label label6;
        private Label label5;
        private Button buttonInsert;
        private Button buttonDelete;
        private Button buttonUpdate;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atrasToolStripMenuItem;
        private Button button3;
        private ErrorProvider errorProvider1;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private Button button2;
        private DataGridViewTextBoxColumn ColumnProductID;
        private DataGridViewTextBoxColumn ColumnProductName;
        private DataGridViewTextBoxColumn ColumnCompanyName;
        private DataGridViewTextBoxColumn ColumnCategoryName;
        private DataGridViewTextBoxColumn ColumnQtyPerUnit;
        private DataGridViewTextBoxColumn ColumnUnitprice;
        private ToolStripMenuItem menuToolStripMenuItem;
    }
}
