namespace accesoadatos
{
    partial class CATEGORIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CATEGORIA));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label7 = new Label();
            buttonFilter = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBoxDescription = new TextBox();
            textBoxCategoryName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            buttonnew = new Button();
            buttonDelete = new Button();
            buttonupdate = new Button();
            buttonInsert = new Button();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0241261F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.9758759F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.5208F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4792013F));
            tableLayoutPanel1.Size = new Size(829, 601);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(buttonFilter);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(textBoxCategoryName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(169, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 520);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(66, 54);
            label7.Name = "label7";
            label7.Size = new Size(159, 28);
            label7.TabIndex = 12;
            label7.Text = "Filter Categories";
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(527, 52);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(94, 29);
            buttonFilter.TabIndex = 11;
            buttonFilter.Text = "Apply";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(355, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 154);
            label4.Name = "label4";
            label4.Size = new Size(229, 31);
            label4.TabIndex = 3;
            label4.Text = "Registrar Categorias";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(338, 313);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(224, 27);
            textBoxDescription.TabIndex = 1;
            textBoxDescription.Validated += textBoxDescription_Validated;
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Location = new Point(338, 247);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.Size = new Size(224, 27);
            textBoxCategoryName.TabIndex = 1;
            textBoxCategoryName.Validated += textBoxCategoryName_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(106, 315);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 0;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(106, 243);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "CategoyName";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { suppliersToolStripMenuItem, productsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(657, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(84, 24);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(80, 24);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonnew);
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonupdate);
            panel2.Controls.Add(buttonInsert);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(169, 529);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 69);
            panel2.TabIndex = 1;
            // 
            // buttonnew
            // 
            buttonnew.Location = new Point(480, 20);
            buttonnew.Name = "buttonnew";
            buttonnew.Size = new Size(94, 29);
            buttonnew.TabIndex = 1;
            buttonnew.Text = "New";
            buttonnew.UseVisualStyleBackColor = true;
            buttonnew.Click += buttonnew_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(355, 20);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonupdate
            // 
            buttonupdate.Location = new Point(231, 20);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new Size(94, 29);
            buttonupdate.TabIndex = 3;
            buttonupdate.Text = "Update";
            buttonupdate.UseVisualStyleBackColor = true;
            buttonupdate.Click += buttonupdate_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(106, 20);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(94, 29);
            buttonInsert.TabIndex = 4;
            buttonInsert.Text = "Insert";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 520);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(20, 465);
            button3.Name = "button3";
            button3.Size = new Size(115, 29);
            button3.TabIndex = 1;
            button3.Text = "Products";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 421);
            button2.Name = "button2";
            button2.Size = new Size(115, 29);
            button2.TabIndex = 1;
            button2.Text = "All Category";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(20, 376);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 1;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CATEGORIA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 601);
            Controls.Add(tableLayoutPanel1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CATEGORIA";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CATEGORIA";
            Load += CATEGORIA_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBoxDescription;
        private TextBox textBoxCategoryName;
        private Panel panel2;
        private Panel panel3;
        private Button buttonnew;
        private Button buttonDelete;
        private Button buttonupdate;
        private Button buttonInsert;
        private Label label7;
        private Button buttonFilter;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
    }
}