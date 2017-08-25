namespace Business_Management_App
{
    partial class Add_Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Category_Name = new System.Windows.Forms.TextBox();
            this.btn_Add_Category = new System.Windows.Forms.Button();
            this.shopDataBaseDataSet = new Business_Management_App.ShopDataBaseDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Business_Management_App.ShopDataBaseDataSetTableAdapters.CategoryTableAdapter();
            this.tableAdapterManager = new Business_Management_App.ShopDataBaseDataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Search_Category = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Delete_Category = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // txb_Category_Name
            // 
            this.txb_Category_Name.Location = new System.Drawing.Point(132, 73);
            this.txb_Category_Name.Margin = new System.Windows.Forms.Padding(1);
            this.txb_Category_Name.Name = "txb_Category_Name";
            this.txb_Category_Name.Size = new System.Drawing.Size(137, 20);
            this.txb_Category_Name.TabIndex = 1;
            // 
            // btn_Add_Category
            // 
            this.btn_Add_Category.Location = new System.Drawing.Point(66, 237);
            this.btn_Add_Category.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Add_Category.Name = "btn_Add_Category";
            this.btn_Add_Category.Size = new System.Drawing.Size(201, 36);
            this.btn_Add_Category.TabIndex = 2;
            this.btn_Add_Category.Text = "Add Category";
            this.btn_Add_Category.UseVisualStyleBackColor = true;
            this.btn_Add_Category.Click += new System.EventHandler(this.btn_Add_Category_Click);
            // 
            // shopDataBaseDataSet
            // 
            this.shopDataBaseDataSet.DataSetName = "ShopDataBaseDataSet";
            this.shopDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.shopDataBaseDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Arrival_DaysTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.CPL_ProductTableAdapter = null;
            this.tableAdapterManager.Customer_Purchase_ListTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.PPL_ProductTableAdapter = null;
            this.tableAdapterManager.Product_Purchase_ListTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Business_Management_App.ShopDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vendor_Arrival_DaysTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search Category";
            // 
            // txb_Search_Category
            // 
            this.txb_Search_Category.Location = new System.Drawing.Point(387, 73);
            this.txb_Search_Category.Margin = new System.Windows.Forms.Padding(1);
            this.txb_Search_Category.Name = "txb_Search_Category";
            this.txb_Search_Category.Size = new System.Drawing.Size(142, 20);
            this.txb_Search_Category.TabIndex = 6;
            this.txb_Search_Category.TextChanged += new System.EventHandler(this.txb_Search_Category_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AllowUserToAddRows = false;
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.GridColor = System.Drawing.Color.DarkBlue;
            this.categoryDataGridView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.categoryDataGridView.Location = new System.Drawing.Point(44, 110);
            this.categoryDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.categoryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataGridView.RowTemplate.Height = 40;
            this.categoryDataGridView.Size = new System.Drawing.Size(482, 99);
            this.categoryDataGridView.TabIndex = 4;
            this.categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellContentClick);
            // 
            // btn_Delete_Category
            // 
            this.btn_Delete_Category.Location = new System.Drawing.Point(290, 237);
            this.btn_Delete_Category.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Delete_Category.Name = "btn_Delete_Category";
            this.btn_Delete_Category.Size = new System.Drawing.Size(201, 36);
            this.btn_Delete_Category.TabIndex = 7;
            this.btn_Delete_Category.Text = "Delete Category";
            this.btn_Delete_Category.UseVisualStyleBackColor = true;
            this.btn_Delete_Category.Click += new System.EventHandler(this.btn_Delete_Category_Click);
            // 
            // Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 315);
            this.Controls.Add(this.btn_Delete_Category);
            this.Controls.Add(this.txb_Search_Category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.btn_Add_Category);
            this.Controls.Add(this.txb_Category_Name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Add_Category";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.Add_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Category_Name;
        private System.Windows.Forms.Button btn_Add_Category;
        private ShopDataBaseDataSet shopDataBaseDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private ShopDataBaseDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private ShopDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Search_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.Button btn_Delete_Category;
    }
}