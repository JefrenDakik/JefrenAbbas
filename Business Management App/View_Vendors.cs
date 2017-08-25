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
    public partial class View_Vendors : Form
    {
        ShopDataBaseDataContext database = new ShopDataBaseDataContext();
        BindingSource src = new BindingSource();
        public View_Vendors()
        {
            InitializeComponent();
        }

        private void vendorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataBaseDataSet);

        }

        private void View_Vendors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopDataBaseDataSet.Vendor' table. You can move, or remove it, as needed.
            comboBox1.Items.Insert(0, "First Name");
            comboBox1.Items.Add("Last Name");
            comboBox1.Items.Add("Phone Number");
            comboBox1.Items.Add("Address");
            comboBox1.SelectedIndex = 0;
            this.vendorTableAdapter.Fill(this.shopDataBaseDataSet.Vendor);
            vendorDataGridView.DataSource = from A in database.Vendors
                                            select A;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?","Save Changes",MessageBoxButtons.YesNo);
        }

        private void txb_Search_Vendors_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void search() 
        {
            string SearchValue = txb_Search_Vendors.Text.ToString();
            if (comboBox1.Text == "First Name")
            {
                src.DataSource = from A in database.Vendors
                                 where A.First_Name.Contains(SearchValue)
                                 select A;
            }
            else if (comboBox1.Text == "Last Name")
            {
                src.DataSource = from A in database.Vendors
                                 where A.Last_Name.Contains(SearchValue)
                                 select A;
            }
            else if (comboBox1.Text == "Phone Number")
            {
                src.DataSource = from A in database.Vendors
                                 where A.Phone_Number.Contains(SearchValue)
                                 select A;
            }
            else if (comboBox1.Text == "Address")
            {
                src.DataSource = from A in database.Vendors
                                 where A.Address.Contains(SearchValue)
                                 select A;
            }
            vendorDataGridView.DataSource = src;
        }

        private void btn_Delete_Vendors_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in vendorDataGridView.SelectedRows)
            {
                var vendor = row.DataBoundItem as Vendor;
                database.Vendors.DeleteOnSubmit(vendor);
                try
                {
                    database.SubmitChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Vendor Deleted Successfully");
                search();
            }
        }
    }
}
