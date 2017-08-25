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
    public partial class Add_Category : Form
    {
        ShopDataBaseDataContext database = new ShopDataBaseDataContext();
        BindingSource src = new BindingSource();
        public Add_Category()
        {
            InitializeComponent();
        }
        
        private void Add_Category_Load(object sender, EventArgs e)
        {
            
            src.DataSource = from C in database.Categories
                             select C;
            categoryDataGridView.DataSource = src;
            
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataBaseDataSet);

        }

        private void btn_Add_Category_Click(object sender, EventArgs e)
        {
            if (txb_Category_Name.Text.ToString() == "")
            {
                MessageBox.Show("No Category was entered");
                return;
            }
            Category new_Category = new Category();
            new_Category.Name = txb_Category_Name.Text.ToString();
            try
            {
                database.Categories.InsertOnSubmit(new_Category);
                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                
            }
            MessageBox.Show("Category was inserted successfully");
            src.DataSource = from C in database.Categories
                             select C;
            categoryDataGridView.DataSource = src;
        }

        private void txb_Search_Category_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_Delete_Category_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in categoryDataGridView.SelectedRows)
            {
                var category = row.DataBoundItem as Category;
                database.Categories.DeleteOnSubmit(category);
                try
                {
                    database.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Category Deleted Successfully");
                search();
            }
        }
        private void search()
        {
            string insertedCategoryValue = txb_Search_Category.Text.ToString();
            src.DataSource = from C in database.Categories
                             where C.Name.Contains(insertedCategoryValue)
                             select C;
            categoryDataGridView.DataSource = src;
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
