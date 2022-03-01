using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
