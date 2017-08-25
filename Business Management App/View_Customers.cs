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
    public partial class View_Customers : Form
    {
        ShopDataBaseDataContext database;
        BindingSource src;
        public View_Customers()
        {
            InitializeComponent();
            database = new ShopDataBaseDataContext();
            src = new BindingSource();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataBaseDataSet);

        }

        private void View_Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataBaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.shopDataBaseDataSet.Customer);
            comboBox1.Items.Insert(0, "First Name");
            comboBox1.Items.Add("Last Name");
            comboBox1.Items.Add("Phone Number");
            comboBox1.Items.Add("Address");
            comboBox1.SelectedIndex = 0;


            src.DataSource = from A in database.Customers
                             select A;
            customerDataGridView.DataSource = src;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                updateCustomerTableOnChange();   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateCustomerTableOnChange();
        }



        //This method to update the customers table after search in the customer view form
        private void updateCustomerTableOnChange()
        {

            string selectedCategotyofCustomerSearch = comboBox1.Text.ToString();// selecting from Customer Attribue
            string insertedValue = textBox1.Text.ToString();
            switch (selectedCategotyofCustomerSearch)
            {

                case "First Name": src.DataSource = from A in database.Customers
                                                    where A.First_Name.Contains(insertedValue)
                                                    select A;
                    break;

                case "Last Name": src.DataSource = from A in database.Customers
                                                   where A.Last_Name.Contains(insertedValue)
                                                   select A;
                    break;
                case "Phone Number": src.DataSource = from A in database.Customers
                                                      where A.Phone_Number.Contains(insertedValue)
                                                      select A;
                    break;
                case "Address": src.DataSource = from A in database.Customers
                                                 where A.Address.Contains(insertedValue)
                                                 select A;
                    break;


            };
            customerDataGridView.DataSource = src;
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
