namespace accesoadatos
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            menuStrip1 = new MenuStrip();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(50, 50);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ordersToolStripMenuItem, suppliersToolStripMenuItem, categoryToolStripMenuItem, productsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(861, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Image = (Image)resources.GetObject("ordersToolStripMenuItem.Image");
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(149, 54);
            ordersToolStripMenuItem.Text = "Orders";
            ordersToolStripMenuItem.Click += ordersToolStripMenuItem_Click;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Image = (Image)resources.GetObject("suppliersToolStripMenuItem.Image");
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(178, 54);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.Image = (Image)resources.GetObject("categoryToolStripMenuItem.Image");
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(175, 54);
            categoryToolStripMenuItem.Text = "Category";
            categoryToolStripMenuItem.Click += categoryToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.Image = (Image)resources.GetObject("productsToolStripMenuItem.Image");
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(173, 54);
            productsToolStripMenuItem.Text = "Products";
            productsToolStripMenuItem.Click += productsToolStripMenuItem_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(861, 595);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
    }
}