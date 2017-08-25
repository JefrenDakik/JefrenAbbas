namespace Business_Management_App
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CustomersMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VendorsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Purchase_OrderMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCAAtegoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomersMenuStrip,
            this.ProductsMenuStrip,
            this.VendorsMenuStrip,
            this.Purchase_OrderMenuStrip,
            this.addCAAtegoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1305, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CustomersMenuStrip
            // 
            this.CustomersMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.CustomersMenuStrip.Name = "CustomersMenuStrip";
            this.CustomersMenuStrip.Size = new System.Drawing.Size(172, 45);
            this.CustomersMenuStrip.Text = "Customers";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(310, 46);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(310, 46);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // ProductsMenuStrip
            // 
            this.ProductsMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductsToolStripMenuItem});
            this.ProductsMenuStrip.Name = "ProductsMenuStrip";
            this.ProductsMenuStrip.Size = new System.Drawing.Size(147, 45);
            this.ProductsMenuStrip.Text = "Products";
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(285, 46);
            this.viewProductsToolStripMenuItem.Text = "View Products";
            // 
            // VendorsMenuStrip
            // 
            this.VendorsMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVendorsToolStripMenuItem,
            this.viewVendorsToolStripMenuItem});
            this.VendorsMenuStrip.Name = "VendorsMenuStrip";
            this.VendorsMenuStrip.Size = new System.Drawing.Size(139, 45);
            this.VendorsMenuStrip.Text = "Vendors";
            // 
            // addVendorsToolStripMenuItem
            // 
            this.addVendorsToolStripMenuItem.Name = "addVendorsToolStripMenuItem";
            this.addVendorsToolStripMenuItem.Size = new System.Drawing.Size(277, 46);
            this.addVendorsToolStripMenuItem.Text = "Add Vendors";
            this.addVendorsToolStripMenuItem.Click += new System.EventHandler(this.addVendorsToolStripMenuItem_Click);
            // 
            // viewVendorsToolStripMenuItem
            // 
            this.viewVendorsToolStripMenuItem.Name = "viewVendorsToolStripMenuItem";
            this.viewVendorsToolStripMenuItem.Size = new System.Drawing.Size(277, 46);
            this.viewVendorsToolStripMenuItem.Text = "View Vendors";
            this.viewVendorsToolStripMenuItem.Click += new System.EventHandler(this.viewVendorsToolStripMenuItem_Click);
            // 
            // Purchase_OrderMenuStrip
            // 
            this.Purchase_OrderMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPurchaseOrderToolStripMenuItem,
            this.viewPurchaseOrdersToolStripMenuItem});
            this.Purchase_OrderMenuStrip.Name = "Purchase_OrderMenuStrip";
            this.Purchase_OrderMenuStrip.Size = new System.Drawing.Size(247, 45);
            this.Purchase_OrderMenuStrip.Text = "Purchase Orders";
            // 
            // addPurchaseOrderToolStripMenuItem
            // 
            this.addPurchaseOrderToolStripMenuItem.Name = "addPurchaseOrderToolStripMenuItem";
            this.addPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(385, 46);
            this.addPurchaseOrderToolStripMenuItem.Text = "Add Purchase Order";
            this.addPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.addPurchaseOrderToolStripMenuItem_Click);
            // 
            // viewPurchaseOrdersToolStripMenuItem
            // 
            this.viewPurchaseOrdersToolStripMenuItem.Name = "viewPurchaseOrdersToolStripMenuItem";
            this.viewPurchaseOrdersToolStripMenuItem.Size = new System.Drawing.Size(385, 46);
            this.viewPurchaseOrdersToolStripMenuItem.Text = "View Purchase Orders";
            this.viewPurchaseOrdersToolStripMenuItem.Click += new System.EventHandler(this.viewPurchaseOrdersToolStripMenuItem_Click);
            // 
            // addCAAtegoryToolStripMenuItem
            // 
            this.addCAAtegoryToolStripMenuItem.Name = "addCAAtegoryToolStripMenuItem";
            this.addCAAtegoryToolStripMenuItem.Size = new System.Drawing.Size(214, 45);
            this.addCAAtegoryToolStripMenuItem.Text = "Add Category";
            this.addCAAtegoryToolStripMenuItem.Click += new System.EventHandler(this.addCAAtegoryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 883);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Business Management App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CustomersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VendorsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Purchase_OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCAAtegoryToolStripMenuItem;
    }
}

