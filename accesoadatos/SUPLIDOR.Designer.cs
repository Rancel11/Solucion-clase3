namespace accesoadatos
{
    partial class SUPLIDOR
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUPLIDOR));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            buttonnew = new Button();
            buttonDelete = new Button();
            buttonupdate = new Button();
            buttonInsert = new Button();
            panel2 = new Panel();
            label7 = new Label();
            buttonFilter = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBoxPhone = new TextBox();
            textBoxContactTitle = new TextBox();
            textBoxContactName = new TextBox();
            textBoxCompanyName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.7142849F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.28571F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.94025F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0597544F));
            tableLayoutPanel1.Size = new Size(875, 569);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonnew);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonupdate);
            panel1.Controls.Add(buttonInsert);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(228, 492);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 74);
            panel1.TabIndex = 0;
            // 
            // buttonnew
            // 
            buttonnew.Location = new Point(450, 35);
            buttonnew.Name = "buttonnew";
            buttonnew.Size = new Size(94, 29);
            buttonnew.TabIndex = 0;
            buttonnew.Text = "New";
            buttonnew.UseVisualStyleBackColor = true;
            buttonnew.Click += buttonnew_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(325, 35);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonupdate
            // 
            buttonupdate.Location = new Point(201, 35);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new Size(94, 29);
            buttonupdate.TabIndex = 0;
            buttonupdate.Text = "Update";
            buttonupdate.UseVisualStyleBackColor = true;
            buttonupdate.Click += buttonupdate_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(76, 35);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 0;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(buttonFilter);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxPhone);
            panel2.Controls.Add(textBoxContactTitle);
            panel2.Controls.Add(textBoxContactName);
            panel2.Controls.Add(textBoxCompanyName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(228, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 483);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 44);
            label7.Name = "label7";
            label7.Size = new Size(146, 28);
            label7.TabIndex = 9;
            label7.Text = "Filter Suppliers";
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(497, 43);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(94, 29);
            buttonFilter.TabIndex = 8;
            buttonFilter.Text = "Apply";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(325, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(180, 94);
            label5.Name = "label5";
            label5.Size = new Size(208, 31);
            label5.TabIndex = 5;
            label5.Text = "Registrar Suplidor";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(311, 390);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(202, 27);
            textBoxPhone.TabIndex = 4;
            textBoxPhone.Validated += textBoxPhone_Validated;
            // 
            // textBoxContactTitle
            // 
            textBoxContactTitle.Location = new Point(311, 322);
            textBoxContactTitle.Name = "textBoxContactTitle";
            textBoxContactTitle.Size = new Size(202, 27);
            textBoxContactTitle.TabIndex = 4;
            textBoxContactTitle.Validated += textBoxContactTitle_Validated;
            // 
            // textBoxContactName
            // 
            textBoxContactName.Location = new Point(311, 246);
            textBoxContactName.Name = "textBoxContactName";
            textBoxContactName.Size = new Size(202, 27);
            textBoxContactName.TabIndex = 4;
            textBoxContactName.Validated += textBoxContactName_Validated;
            // 
            // textBoxCompanyName
            // 
            textBoxCompanyName.Location = new Point(311, 192);
            textBoxCompanyName.Name = "textBoxCompanyName";
            textBoxCompanyName.Size = new Size(202, 27);
            textBoxCompanyName.TabIndex = 4;
            textBoxCompanyName.TextChanged += textBoxCompanyName_TextChanged;
            textBoxCompanyName.Validated += textBoxCompanyName_Validated;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(62, 389);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(62, 318);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 2;
            label3.Text = "ContactTitle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(62, 192);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 1;
            label2.Text = "CompanyName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(62, 248);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 0;
            label1.Text = "ContactName";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, productsToolStripMenuItem, categoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(644, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Image = (Image)resources.GetObject("menuToolStripMenuItem.Image");
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(34, 24);
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(80, 24);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(83, 24);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 483);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(27, 425);
            button2.Name = "button2";
            button2.Size = new Size(142, 29);
            button2.TabIndex = 0;
            button2.Text = "Assign category";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 374);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 0;
            button1.Text = "All Suppliers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SUPLIDOR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 569);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SUPLIDOR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suppliers";
            Load += SUPLIDOR_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button buttonnew;
        private Button buttonDelete;
        private Button buttonupdate;
        private Button buttonInsert;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox textBoxPhone;
        private TextBox textBoxContactTitle;
        private TextBox textBoxContactName;
        private TextBox textBoxCompanyName;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Label label5;
        private ComboBox comboBox1;
        private Button buttonFilter;
        private Label label7;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
    }
}