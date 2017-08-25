namespace Business_Management_App
{
    partial class Add_Vendor
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
            this.button1 = new System.Windows.Forms.Button();
            this.txb_Vendor_Address = new System.Windows.Forms.TextBox();
            this.txb_Vendor_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txb_Vendor_LastName = new System.Windows.Forms.TextBox();
            this.txb_Vendor_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txb_Vendor_Address);
            this.groupBox1.Controls.Add(this.txb_Vendor_PhoneNumber);
            this.groupBox1.Controls.Add(this.txb_Vendor_LastName);
            this.groupBox1.Controls.Add(this.txb_Vendor_FirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(156, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 615);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(513, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Vendor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_Vendor_Address
            // 
            this.txb_Vendor_Address.Location = new System.Drawing.Point(350, 433);
            this.txb_Vendor_Address.Name = "txb_Vendor_Address";
            this.txb_Vendor_Address.Size = new System.Drawing.Size(283, 38);
            this.txb_Vendor_Address.TabIndex = 8;
            this.txb_Vendor_Address.Enter += new System.EventHandler(this.txb_Vendor_Address_Enter);
            // 
            // txb_Vendor_PhoneNumber
            // 
            this.txb_Vendor_PhoneNumber.Location = new System.Drawing.Point(350, 334);
            this.txb_Vendor_PhoneNumber.Name = "txb_Vendor_PhoneNumber";
            this.txb_Vendor_PhoneNumber.Size = new System.Drawing.Size(283, 38);
            this.txb_Vendor_PhoneNumber.TabIndex = 7;
            this.txb_Vendor_PhoneNumber.Enter += new System.EventHandler(this.txb_Vendor_PhoneNumber_Enter);
            // 
            // txb_Vendor_LastName
            // 
            this.txb_Vendor_LastName.Location = new System.Drawing.Point(350, 231);
            this.txb_Vendor_LastName.Name = "txb_Vendor_LastName";
            this.txb_Vendor_LastName.Size = new System.Drawing.Size(283, 38);
            this.txb_Vendor_LastName.TabIndex = 6;
            this.txb_Vendor_LastName.Enter += new System.EventHandler(this.txb_Vendor_LastName_Enter);
            // 
            // txb_Vendor_FirstName
            // 
            this.txb_Vendor_FirstName.Location = new System.Drawing.Point(350, 140);
            this.txb_Vendor_FirstName.Name = "txb_Vendor_FirstName";
            this.txb_Vendor_FirstName.Size = new System.Drawing.Size(283, 38);
            this.txb_Vendor_FirstName.TabIndex = 5;
            this.txb_Vendor_FirstName.Enter += new System.EventHandler(this.txb_Vendor_FirstName_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // Add_Vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 821);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Vendor";
            this.Text = "Add_Vendor";
            this.Load += new System.EventHandler(this.Add_Vendor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_Vendor_Address;
        private System.Windows.Forms.TextBox txb_Vendor_PhoneNumber;
        private System.Windows.Forms.TextBox txb_Vendor_LastName;
        private System.Windows.Forms.TextBox txb_Vendor_FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}