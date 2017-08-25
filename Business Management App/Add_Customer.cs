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
    public partial class Add_Customer : Form
    {
        ShopDataBaseDataContext database = new ShopDataBaseDataContext();
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool EmptyField = false;
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
            Customer new_Customer = new Customer();
            new_Customer.First_Name = txb_Customer_FirstName.Text;
            new_Customer.Last_Name = txb_Customer_LastName.Text;
            new_Customer.Address = txb_Customer_Address.Text;
            new_Customer.Phone_Number = txb_Customer_Phone_Number.Text;
            try
            {
                database.Customers.InsertOnSubmit(new_Customer);
                database.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                
            }
            MessageBox.Show("Customer inserted successfully");
        }

        private void txb_Customer_FirstName_Enter(object sender, EventArgs e)
        {
            txb_Customer_FirstName.BackColor = Color.White;
        }

        private void txb_Customer_LastName_Enter(object sender, EventArgs e)
        {
            txb_Customer_LastName.BackColor = Color.White;
        }

        private void txb_Customer_Phone_Number_Enter(object sender, EventArgs e)
        {
            txb_Customer_Phone_Number.BackColor = Color.White;
        }

        private void txb_Customer_Address_Enter(object sender, EventArgs e)
        {
            txb_Customer_Address.BackColor = Color.White;
        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {

        }

        private void txb_Customer_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
