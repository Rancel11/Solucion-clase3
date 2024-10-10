namespace accesoadatos
{
    partial class AllCategory
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            ColumnCategoryName = new DataGridViewTextBoxColumn();
            ColumnDescription = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnCategoryName, ColumnDescription });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 592);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnCategoryName
            // 
            ColumnCategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCategoryName.DataPropertyName = "CategoryName";
            ColumnCategoryName.HeaderText = "CategoryName";
            ColumnCategoryName.MinimumWidth = 6;
            ColumnCategoryName.Name = "ColumnCategoryName";
            // 
            // ColumnDescription
            // 
            ColumnDescription.DataPropertyName = "Description";
            dataGridViewCellStyle2.BackColor = Color.White;
            ColumnDescription.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnDescription.HeaderText = "Description";
            ColumnDescription.MinimumWidth = 6;
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { atrasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            atrasToolStripMenuItem.Size = new Size(57, 24);
            atrasToolStripMenuItem.Text = "Atras";
            atrasToolStripMenuItem.Click += atrasToolStripMenuItem_Click;
            // 
            // AllCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 620);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllCategory";
            Load += AllCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCategoryName;
        private DataGridViewTextBoxColumn ColumnDescription;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atrasToolStripMenuItem;
    }
}