namespace accesoadatos
{
    partial class AllSuppliers
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
            dataGridView1 = new DataGridView();
            ColumnCompanyName = new DataGridViewTextBoxColumn();
            ColumnContactName = new DataGridViewTextBoxColumn();
            ColumnContactTitle = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            atrasToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnCompanyName, ColumnContactName, ColumnContactTitle, ColumnPhone });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 521);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnCompanyName
            // 
            ColumnCompanyName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCompanyName.DataPropertyName = "CompanyName";
            ColumnCompanyName.HeaderText = "CompanyName";
            ColumnCompanyName.MinimumWidth = 6;
            ColumnCompanyName.Name = "ColumnCompanyName";
            // 
            // ColumnContactName
            // 
            ColumnContactName.DataPropertyName = "ContactName";
            ColumnContactName.HeaderText = "ContactName";
            ColumnContactName.MinimumWidth = 6;
            ColumnContactName.Name = "ColumnContactName";
            ColumnContactName.Width = 125;
            // 
            // ColumnContactTitle
            // 
            ColumnContactTitle.DataPropertyName = "ContactTitle";
            ColumnContactTitle.HeaderText = "ContactTitle";
            ColumnContactTitle.MinimumWidth = 6;
            ColumnContactTitle.Name = "ColumnContactTitle";
            ColumnContactTitle.Width = 125;
            // 
            // ColumnPhone
            // 
            ColumnPhone.DataPropertyName = "Phone";
            ColumnPhone.HeaderText = "Phone";
            ColumnPhone.MinimumWidth = 6;
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.Width = 125;
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
            // AllSuppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllSuppliers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllSuppliers";
            Load += AllSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnCompanyName;
        private DataGridViewTextBoxColumn ColumnContactName;
        private DataGridViewTextBoxColumn ColumnContactTitle;
        private DataGridViewTextBoxColumn ColumnPhone;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem atrasToolStripMenuItem;
    }
}