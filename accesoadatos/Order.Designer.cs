namespace accesoadatos
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            panel2 = new Panel();
            comboBoxCustomer = new ComboBox();
            textBoxShipCountry = new TextBox();
            textBox1 = new TextBox();
            textBoxPostalCode = new TextBox();
            comboBoxEmployee = new ComboBox();
            textBoxRegion = new TextBox();
            textBoxCity = new TextBox();
            textBoxAddress = new TextBox();
            label13 = new Label();
            label19 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            ColumnProductID = new DataGridViewTextBoxColumn();
            ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnUnitPrice = new DataGridViewTextBoxColumn();
            ColumnQuantityPerUnit = new DataGridViewTextBoxColumn();
            ColumnDiscount = new DataGridViewTextBoxColumn();
            ColumnProductCategoryName = new DataGridViewTextBoxColumn();
            ColumnCompanyName = new DataGridViewTextBoxColumn();
            ColumnExtendedPrice = new DataGridViewTextBoxColumn();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            textBoxShipName = new TextBox();
            comboBoxShipVIa = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxSubtotal = new TextBox();
            textBoxFrieght = new TextBox();
            textBoxTotal = new TextBox();
            menuStrip1 = new MenuStrip();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            buttonOK = new Button();
            buttonCANCEL = new Button();
            buttonOrdersMade = new Button();
            buttonAdditems = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxCustomer);
            panel2.Controls.Add(textBoxShipCountry);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBoxPostalCode);
            panel2.Controls.Add(comboBoxEmployee);
            panel2.Controls.Add(textBoxRegion);
            panel2.Controls.Add(textBoxCity);
            panel2.Controls.Add(textBoxAddress);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label18);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(12, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(1235, 313);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.Font = new Font("Segoe UI", 10.2F);
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(158, 25);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(166, 31);
            comboBoxCustomer.TabIndex = 2;
            // 
            // textBoxShipCountry
            // 
            textBoxShipCountry.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxShipCountry.Location = new Point(158, 250);
            textBoxShipCountry.Name = "textBoxShipCountry";
            textBoxShipCountry.Size = new Size(238, 30);
            textBoxShipCountry.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(116, 643);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 30);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBoxPostalCode_TextChanged;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPostalCode.Location = new Point(158, 203);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(238, 30);
            textBoxPostalCode.TabIndex = 1;
            textBoxPostalCode.TextChanged += textBoxPostalCode_TextChanged;
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.Font = new Font("Segoe UI", 10.2F);
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(158, 75);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(166, 31);
            comboBoxEmployee.TabIndex = 1;
            // 
            // textBoxRegion
            // 
            textBoxRegion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRegion.Location = new Point(158, 145);
            textBoxRegion.Name = "textBoxRegion";
            textBoxRegion.Size = new Size(238, 30);
            textBoxRegion.TabIndex = 1;
            // 
            // textBoxCity
            // 
            textBoxCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCity.Location = new Point(823, 227);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(238, 30);
            textBoxCity.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(823, 25);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(318, 171);
            textBoxAddress.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(27, 83);
            label13.Name = "label13";
            label13.Size = new Size(93, 23);
            label13.TabIndex = 0;
            label13.Text = "Employee:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(27, 255);
            label19.Name = "label19";
            label19.Size = new Size(121, 23);
            label19.TabIndex = 0;
            label19.Text = "Ship Country:";
            label19.Click += label7_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(27, 206);
            label14.Name = "label14";
            label14.Size = new Size(108, 23);
            label14.TabIndex = 0;
            label14.Text = "Postal Code:";
            label14.Click += label7_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(27, 148);
            label15.Name = "label15";
            label15.Size = new Size(71, 23);
            label15.TabIndex = 0;
            label15.Text = "Region:";
            label15.Click += label7_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(672, 234);
            label16.Name = "label16";
            label16.Size = new Size(47, 23);
            label16.TabIndex = 0;
            label16.Text = "City:";
            label16.Click += label7_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(672, 33);
            label17.Name = "label17";
            label17.Size = new Size(79, 23);
            label17.TabIndex = 0;
            label17.Text = "Address:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(27, 33);
            label18.Name = "label18";
            label18.Size = new Size(93, 23);
            label18.TabIndex = 0;
            label18.Text = "Customer:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnProductID, ColumnProductName, ColumnUnitPrice, ColumnQuantityPerUnit, ColumnDiscount, ColumnProductCategoryName, ColumnCompanyName, ColumnExtendedPrice });
            dataGridView1.Location = new Point(12, 549);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1235, 229);
            dataGridView1.TabIndex = 2;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 88);
            label3.Name = "label3";
            label3.Size = new Size(104, 38);
            label3.TabIndex = 0;
            label3.Text = "Orders";
            label3.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 801);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 0;
            label4.Text = "Ship Name:";
            label4.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 851);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 0;
            label5.Text = "Ship Via:";
            label5.Click += label7_Click;
            // 
            // textBoxShipName
            // 
            textBoxShipName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxShipName.Location = new Point(151, 798);
            textBoxShipName.Name = "textBoxShipName";
            textBoxShipName.Size = new Size(268, 30);
            textBoxShipName.TabIndex = 1;
            // 
            // comboBoxShipVIa
            // 
            comboBoxShipVIa.FormattingEnabled = true;
            comboBoxShipVIa.Location = new Point(151, 850);
            comboBoxShipVIa.Name = "comboBoxShipVIa";
            comboBoxShipVIa.Size = new Size(176, 28);
            comboBoxShipVIa.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(942, 798);
            label6.Name = "label6";
            label6.Size = new Size(84, 23);
            label6.TabIndex = 0;
            label6.Text = "Subtotal:";
            label6.Click += label7_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(942, 843);
            label7.Name = "label7";
            label7.Size = new Size(73, 23);
            label7.TabIndex = 0;
            label7.Text = "Frieght:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(942, 886);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 0;
            label8.Text = "Total:";
            label8.Click += label7_Click;
            // 
            // textBoxSubtotal
            // 
            textBoxSubtotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSubtotal.Location = new Point(1080, 795);
            textBoxSubtotal.Name = "textBoxSubtotal";
            textBoxSubtotal.Size = new Size(134, 30);
            textBoxSubtotal.TabIndex = 1;
            textBoxSubtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxFrieght
            // 
            textBoxFrieght.Enabled = false;
            textBoxFrieght.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFrieght.Location = new Point(1080, 840);
            textBoxFrieght.Name = "textBoxFrieght";
            textBoxFrieght.Size = new Size(134, 30);
            textBoxFrieght.TabIndex = 1;
            textBoxFrieght.Text = "1000";
            textBoxFrieght.TextAlign = HorizontalAlignment.Right;
            textBoxFrieght.TextChanged += textBoxFrieght_TextChanged;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTotal.Location = new Point(1080, 886);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(134, 30);
            textBoxTotal.TabIndex = 1;
            textBoxTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { atrasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MaximumSize = new Size(50, 50);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(50, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            atrasToolStripMenuItem.Image = (Image)resources.GetObject("atrasToolStripMenuItem.Image");
            atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            atrasToolStripMenuItem.Size = new Size(34, 24);
            atrasToolStripMenuItem.Click += atrasToolStripMenuItem_Click;
            // 
            // buttonOK
            // 
            buttonOK.Cursor = Cursors.Hand;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(1012, 950);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 6;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += button1_Click;
            // 
            // buttonCANCEL
            // 
            buttonCANCEL.Cursor = Cursors.Hand;
            buttonCANCEL.FlatStyle = FlatStyle.Flat;
            buttonCANCEL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCANCEL.Location = new Point(1126, 950);
            buttonCANCEL.Name = "buttonCANCEL";
            buttonCANCEL.Size = new Size(94, 29);
            buttonCANCEL.TabIndex = 6;
            buttonCANCEL.Text = "Cancel";
            buttonCANCEL.UseVisualStyleBackColor = true;
            buttonCANCEL.Click += buttonCANCEL_Click;
            // 
            // buttonOrdersMade
            // 
            buttonOrdersMade.FlatStyle = FlatStyle.Flat;
            buttonOrdersMade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOrdersMade.Location = new Point(1072, 97);
            buttonOrdersMade.Name = "buttonOrdersMade";
            buttonOrdersMade.Size = new Size(148, 29);
            buttonOrdersMade.TabIndex = 9;
            buttonOrdersMade.Text = "Orders Made";
            buttonOrdersMade.UseVisualStyleBackColor = true;
            buttonOrdersMade.Click += buttonOrdersMade_Click;
            // 
            // buttonAdditems
            // 
            buttonAdditems.FlatStyle = FlatStyle.Popup;
            buttonAdditems.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdditems.Location = new Point(12, 504);
            buttonAdditems.Name = "buttonAdditems";
            buttonAdditems.Size = new Size(133, 30);
            buttonAdditems.TabIndex = 0;
            buttonAdditems.Text = "Add Items";
            buttonAdditems.UseVisualStyleBackColor = true;
            buttonAdditems.Click += buttonAdditems_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(184, 504);
            button1.Name = "button1";
            button1.Size = new Size(160, 30);
            button1.TabIndex = 10;
            button1.Text = "Filter Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1259, 992);
            Controls.Add(button1);
            Controls.Add(buttonAdditems);
            Controls.Add(buttonOrdersMade);
            Controls.Add(buttonCANCEL);
            Controls.Add(buttonOK);
            Controls.Add(comboBoxShipVIa);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxFrieght);
            Controls.Add(textBoxSubtotal);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(textBoxShipName);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Order";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += Order_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label13;
        private Label label19;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textBoxShipCountry;
        private TextBox textBoxPostalCode;
        private TextBox textBoxRegion;
        private TextBox textBoxCity;
        private TextBox textBoxAddress;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBoxShipName;
        private ComboBox comboBoxShipVIa;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxSubtotal;
        private TextBox textBoxFrieght;
        private TextBox textBoxTotal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atrasToolStripMenuItem;
        private ComboBox comboBoxEmployee;
        private ComboBox comboBoxCustomer;
        private Button buttonOK;
        private Button buttonCANCEL;
        private Button buttonOrdersMade;
        private Button buttonAdditems;
        private DataGridViewTextBoxColumn ColumnProductID;
        private DataGridViewTextBoxColumn ColumnProductName;
        private DataGridViewTextBoxColumn ColumnUnitPrice;
        private DataGridViewTextBoxColumn ColumnQuantityPerUnit;
        private DataGridViewTextBoxColumn ColumnDiscount;
        private DataGridViewTextBoxColumn ColumnProductCategoryName;
        private DataGridViewTextBoxColumn ColumnCompanyName;
        private DataGridViewTextBoxColumn ColumnExtendedPrice;
        private Button button1;
    }
}