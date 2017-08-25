using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Management_App
{
    public partial class Add_Vendor : Form
    {
        ShopDataBaseDataContext database = new ShopDataBaseDataContext();
        BindingSource src=new BindingSource();
        public Add_Vendor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Add_Vendor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool EmptyField=false;
            foreach (Control control in groupBox1.Controls)//checking if there is a textbox that has null value
            {
                TextBox txb = control as TextBox;
                if (txb != null)
                {
                    if (txb.Text == "")
                    {
                        txb.BackColor = Color.Red;
                        EmptyField = true;
                    }
                }
            }
            if (EmptyField == true)
            {
                MessageBox.Show("please fill the fields colored red");
                return;
            }
            Vendor new_Vendor = new Vendor();
            new_Vendor.First_Name = txb_Vendor_FirstName.Text;
            new_Vendor.Last_Name = txb_Vendor_LastName.Text;
            new_Vendor.Phone_Number = txb_Vendor_PhoneNumber.Text;
            new_Vendor.Address = txb_Vendor_Address.Text;
            try
            {
                database.Vendors.InsertOnSubmit(new_Vendor);
                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
            MessageBox.Show("Vendor was inserted successfully");
        }

        private void txb_Vendor_FirstName_Enter(object sender, EventArgs e)
        {
            txb_Vendor_FirstName.BackColor = Color.White;

        }

        private void txb_Vendor_LastName_Enter(object sender, EventArgs e)
        {
            txb_Vendor_LastName.BackColor = Color.White;
        }

        private void txb_Vendor_PhoneNumber_Enter(object sender, EventArgs e)
        {
            txb_Vendor_PhoneNumber.BackColor = Color.White;
        }

        private void txb_Vendor_Address_Enter(object sender, EventArgs e)
        {
            txb_Vendor_Address.BackColor = Color.White;
        }
    }
}
