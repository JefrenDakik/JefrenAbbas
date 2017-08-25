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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewPurchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Purchase_Order frm = new Add_Purchase_Order();
            frm.Show();
        }

        private void addCAAtegoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Category frm = new Add_Category();
            frm.Show();
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Customers frm = new View_Customers();
            frm.Show();
        }

        

        private void addVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Vendor frm = new Add_Vendor();
            frm.Show();
        }

        private void viewVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Vendors frm = new View_Vendors();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Customer frm = new Add_Customer();
            frm.Show();
        }

       
    }
}
