namespace Business_Management_App
{
    partial class View_Customers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.shopDataBaseDataSet = new Business_Management_App.ShopDataBaseDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Business_Management_App.ShopDataBaseDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Business_Management_App.ShopDataBaseDataSetTableAdapters.TableAdapterManager();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(29, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1235, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Customers By";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 39);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // shopDataBaseDataSet
            // 
            this.shopDataBaseDataSet.DataSetName = "ShopDataBaseDataSet";
            this.shopDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.shopDataBaseDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Arrival_DaysTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.CPL_ProductTableAdapter = null;
            this.tableAdapterManager.Customer_Purchase_ListTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.PPL_ProductTableAdapter = null;
            this.tableAdapterManager.Product_Purchase_ListTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Business_Management_App.ShopDataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vendor_Arrival_DaysTableAdapter = null;
            this.tableAdapterManager.VendorTableAdapter = null;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(29, 357);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowTemplate.Height = 40;
            this.customerDataGridView.Size = new System.Drawing.Size(1235, 467);
            this.customerDataGridView.TabIndex = 2;
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Phone_Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Phone_Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // View_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 1106);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "View_Customers";
            this.Text = "View_Customers";
            this.Load += new System.EventHandler(this.View_Customers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ShopDataBaseDataSet shopDataBaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private ShopDataBaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private ShopDataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}