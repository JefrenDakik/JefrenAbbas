namespace Business_Management_App
{
    partial class View_Vendors
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
            this.components = new System.ComponentModel.Container();
            this.shopDataBaseDataSet = new Business_Management_App.ShopDataBaseDataSet();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter = new Business_Management_App.ShopDataBaseDataSetTableAdapters.VendorTableAdapter();
            this.tableAdapterManager = new Business_Management_App.ShopDataBaseDataSetTableAdapters.TableAdapterManager();
            this.btn_Delete_Vendors = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txb_Search_Vendors = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vendorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shopDataBaseDataSet
            // 
            this.shopDataBaseDataSet.DataSetName = "ShopDataBaseDataSet";
            this.shopDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.shopDataBaseDataSet;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Arrival_DaysTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CPL_ProductTableAdapter = null;
            this.tableAdapterManager.Customer_Purchase_ListTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.PPL_ProductTableAdapter = null;
            this.tableAdapterManager.Product_Purchase_ListTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Business_Management_App.ShopDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vendor_Arrival_DaysTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = this.vendorTableAdapter;
            // 
            // btn_Delete_Vendors
            // 
            this.btn_Delete_Vendors.Location = new System.Drawing.Point(555, 812);
            this.btn_Delete_Vendors.Name = "btn_Delete_Vendors";
            this.btn_Delete_Vendors.Size = new System.Drawing.Size(332, 120);
            this.btn_Delete_Vendors.TabIndex = 2;
            this.btn_Delete_Vendors.Text = "Delete";
            this.btn_Delete_Vendors.UseVisualStyleBackColor = true;
            this.btn_Delete_Vendors.Click += new System.EventHandler(this.btn_Delete_Vendors_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(89, 812);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(330, 120);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txb_Search_Vendors
            // 
            this.txb_Search_Vendors.Location = new System.Drawing.Point(996, 430);
            this.txb_Search_Vendors.Name = "txb_Search_Vendors";
            this.txb_Search_Vendors.Size = new System.Drawing.Size(465, 38);
            this.txb_Search_Vendors.TabIndex = 5;
            this.txb_Search_Vendors.TextChanged += new System.EventHandler(this.txb_Search_Vendors_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(996, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(465, 39);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vendorDataGridView
            // 
            this.vendorDataGridView.AllowUserToAddRows = false;
            this.vendorDataGridView.AutoGenerateColumns = false;
            this.vendorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.vendorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vendorDataGridView.DataSource = this.vendorBindingSource;
            this.vendorDataGridView.Location = new System.Drawing.Point(89, 179);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.RowTemplate.Height = 40;
            this.vendorDataGridView.Size = new System.Drawing.Size(799, 414);
            this.vendorDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 63;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 185;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 184;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 144;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone_Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone_Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 238;
            // 
            // View_Vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1061);
            this.Controls.Add(this.vendorDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txb_Search_Vendors);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete_Vendors);
            this.Name = "View_Vendors";
            this.Text = "View_Vendors";
            this.Load += new System.EventHandler(this.View_Vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShopDataBaseDataSet shopDataBaseDataSet;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private ShopDataBaseDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private ShopDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_Delete_Vendors;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txb_Search_Vendors;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView vendorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}