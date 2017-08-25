namespace Business_Management_App
{
    partial class Add_Customer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Add_Customer = new System.Windows.Forms.Button();
            this.txb_Customer_Address = new System.Windows.Forms.TextBox();
            this.txb_Customer_Phone_Number = new System.Windows.Forms.TextBox();
            this.txb_Customer_LastName = new System.Windows.Forms.TextBox();
            this.txb_Customer_FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Add_Customer);
            this.groupBox1.Controls.Add(this.txb_Customer_Address);
            this.groupBox1.Controls.Add(this.txb_Customer_Phone_Number);
            this.groupBox1.Controls.Add(this.txb_Customer_LastName);
            this.groupBox1.Controls.Add(this.txb_Customer_FirstName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(288, 270);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // btn_Add_Customer
            // 
            this.btn_Add_Customer.Location = new System.Drawing.Point(44, 184);
            this.btn_Add_Customer.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Add_Customer.Name = "btn_Add_Customer";
            this.btn_Add_Customer.Size = new System.Drawing.Size(204, 31);
            this.btn_Add_Customer.TabIndex = 17;
            this.btn_Add_Customer.Text = "Add Customer";
            this.btn_Add_Customer.UseVisualStyleBackColor = true;
            this.btn_Add_Customer.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_Customer_Address
            // 
            this.txb_Customer_Address.Location = new System.Drawing.Point(135, 146);
            this.txb_Customer_Address.Margin = new System.Windows.Forms.Padding(1);
            this.txb_Customer_Address.Name = "txb_Customer_Address";
            this.txb_Customer_Address.Size = new System.Drawing.Size(114, 20);
            this.txb_Customer_Address.TabIndex = 16;
            this.txb_Customer_Address.Enter += new System.EventHandler(this.txb_Customer_Address_Enter);
            // 
            // txb_Customer_Phone_Number
            // 
            this.txb_Customer_Phone_Number.Location = new System.Drawing.Point(135, 120);
            this.txb_Customer_Phone_Number.Margin = new System.Windows.Forms.Padding(1);
            this.txb_Customer_Phone_Number.Name = "txb_Customer_Phone_Number";
            this.txb_Customer_Phone_Number.Size = new System.Drawing.Size(114, 20);
            this.txb_Customer_Phone_Number.TabIndex = 15;
            this.txb_Customer_Phone_Number.Enter += new System.EventHandler(this.txb_Customer_Phone_Number_Enter);
            // 
            // txb_Customer_LastName
            // 
            this.txb_Customer_LastName.Location = new System.Drawing.Point(135, 86);
            this.txb_Customer_LastName.Margin = new System.Windows.Forms.Padding(1);
            this.txb_Customer_LastName.Name = "txb_Customer_LastName";
            this.txb_Customer_LastName.Size = new System.Drawing.Size(114, 20);
            this.txb_Customer_LastName.TabIndex = 14;
            this.txb_Customer_LastName.Enter += new System.EventHandler(this.txb_Customer_LastName_Enter);
            // 
            // txb_Customer_FirstName
            // 
            this.txb_Customer_FirstName.Location = new System.Drawing.Point(135, 55);
            this.txb_Customer_FirstName.Margin = new System.Windows.Forms.Padding(1);
            this.txb_Customer_FirstName.Name = "txb_Customer_FirstName";
            this.txb_Customer_FirstName.Size = new System.Drawing.Size(114, 20);
            this.txb_Customer_FirstName.TabIndex = 13;
            this.txb_Customer_FirstName.TextChanged += new System.EventHandler(this.txb_Customer_FirstName_TextChanged);
            this.txb_Customer_FirstName.Enter += new System.EventHandler(this.txb_Customer_FirstName_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name";
            // 
            // Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 315);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Add_Customer";
            this.Text = "Add_Customer";
            this.Load += new System.EventHandler(this.Add_Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Add_Customer;
        private System.Windows.Forms.TextBox txb_Customer_Address;
        private System.Windows.Forms.TextBox txb_Customer_Phone_Number;
        private System.Windows.Forms.TextBox txb_Customer_LastName;
        private System.Windows.Forms.TextBox txb_Customer_FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}