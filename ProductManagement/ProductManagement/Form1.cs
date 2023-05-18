using ProductManagement.App_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class Form1 : Form 
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Alınan məhsul anbarda yenidir?", "Məhsul alışı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BuyNewProductForm buyForm = new BuyNewProductForm();
                buyForm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                BuyExistingProductForm buyForm = new BuyExistingProductForm();
                buyForm.Show();
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            saleForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchBox.Text.ToLower();

            productList.CurrentCell = null;

            for (int i = 0; i < productList.Rows.Count-1; i++)
            {
                if (productList.Rows[i].Cells[0].Value.ToString().ToLower().Contains(searchValue))
                {
                    productList.Rows[i].Visible = true;
                }
                else
                {
                    productList.Rows[i].Visible = false;
                }
            }
        }

        public string selectedProduct = "";

        private void productList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoginForm loginForm = new LoginForm(productList.SelectedRows, "update");
            loginForm.Show();
        }

        private void productList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            deleteProducts.Enabled = true;
        }

        private void deleteProducts_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm loginForm = new LoginForm(productList.SelectedRows, "delete");
                loginForm.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Məlumatda problem var");
            }
                
        }

        private void update_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            this.Invalidate();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (productList.SelectedRows.Count == 1)
            {
                deleteProducts.Enabled = true;
            }
            else
            {
                deleteProducts.Enabled = false;
            }
            this.Size = new Size(1461/2, 955/2);
            this.productTableAdapter.Fill(this.productsDataSet.Product);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            productList.Width = this.Size.Width - 90;
            productList.Height = this.Size.Height - 170;
        }

        private void backUpButton_Click(object sender, EventArgs e)
        {
            BackupForm backupForm = new BackupForm();
            backupForm.Show();
        }
    }
}
