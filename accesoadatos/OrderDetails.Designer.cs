namespace accesoadatos
{
    partial class OrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetails));
            dataGridView1 = new DataGridView();
            ColumnProductID = new DataGridViewTextBoxColumn();
            ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnUnitPrice = new DataGridViewTextBoxColumn();
            ColumnQuantity = new DataGridViewTextBoxColumn();
            ColumnDiscount = new DataGridViewTextBoxColumn();
            ColumnCategoryName = new DataGridViewTextBoxColumn();
            ColumnCompanyName = new DataGridViewTextBoxColumn();
            buttonFilter = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnProductID, ColumnProductName, ColumnUnitPrice, ColumnQuantity, ColumnDiscount, ColumnCategoryName, ColumnCompanyName });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1207, 396);
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
            // ColumnUnitPrice
            // 
            ColumnUnitPrice.DataPropertyName = "UnitPrice";
            ColumnUnitPrice.HeaderText = "UnitPrice";
            ColumnUnitPrice.MinimumWidth = 6;
            ColumnUnitPrice.Name = "ColumnUnitPrice";
            ColumnUnitPrice.Width = 125;
            // 
            // ColumnQuantity
            // 
            ColumnQuantity.DataPropertyName = "Quantity";
            ColumnQuantity.HeaderText = "Quantity";
            ColumnQuantity.MinimumWidth = 6;
            ColumnQuantity.Name = "ColumnQuantity";
            ColumnQuantity.Width = 125;
            // 
            // ColumnDiscount
            // 
            ColumnDiscount.DataPropertyName = "Discount";
            ColumnDiscount.HeaderText = "Discount";
            ColumnDiscount.MinimumWidth = 6;
            ColumnDiscount.Name = "ColumnDiscount";
            ColumnDiscount.Width = 125;
            // 
            // ColumnCategoryName
            // 
            ColumnCategoryName.DataPropertyName = "CategoryName";
            ColumnCategoryName.HeaderText = "CategoryName";
            ColumnCategoryName.MinimumWidth = 6;
            ColumnCategoryName.Name = "ColumnCategoryName";
            ColumnCategoryName.Width = 125;
            // 
            // ColumnCompanyName
            // 
            ColumnCompanyName.DataPropertyName = "CompanyName";
            ColumnCompanyName.HeaderText = "CompanyName";
            ColumnCompanyName.MinimumWidth = 6;
            ColumnCompanyName.Name = "ColumnCompanyName";
            ColumnCompanyName.Width = 125;
            // 
            // buttonFilter
            // 
            buttonFilter.Cursor = Cursors.Hand;
            buttonFilter.FlatStyle = FlatStyle.Popup;
            buttonFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonFilter.Location = new Point(452, 65);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(94, 29);
            buttonFilter.TabIndex = 1;
            buttonFilter.Text = "Apply";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(1085, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(4, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new Size(163, 219);
            // 
            // atrasToolStripMenuItem
            // 
            atrasToolStripMenuItem.Image = (Image)resources.GetObject("atrasToolStripMenuItem.Image");
            atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            atrasToolStripMenuItem.Size = new Size(34, 24);
            atrasToolStripMenuItem.Click += atrasToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { atrasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1207, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 6;
            label1.Text = "Filter Category Products";
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1207, 527);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(buttonFilter);
            Controls.Add(dataGridView1);
            MainMenuStrip = menuStrip1;
            Name = "OrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderDetails";
            Load += OrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonFilter;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridViewTextBoxColumn ColumnProductID;
        private DataGridViewTextBoxColumn ColumnProductName;
        private DataGridViewTextBoxColumn ColumnUnitPrice;
        private DataGridViewTextBoxColumn ColumnQuantity;
        private DataGridViewTextBoxColumn ColumnDiscount;
        private DataGridViewTextBoxColumn ColumnCategoryName;
        private DataGridViewTextBoxColumn ColumnCompanyName;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private ToolStripMenuItem atrasToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label label1;
    }
}