using ProductManagement.App_Data;
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
    public partial class BuyExistingProductForm : Form
    {
        public BuyExistingProductForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            float measure = 0;

            if (float.TryParse(measureBox.Text, out measure) &&
                productsBox.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Məhsulu əlavə etmək istədiyinizə əminsiniz?", "Məhsul alışı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime date = DateTime.Now.Date;

                    using (DatabaseEntities db = new DatabaseEntities())
                    {
                        Report report = db.Reports.Where(r => r.Date == date).FirstOrDefault();

                        Product product = db.Products.Where(p => p.ProductName == productsBox.Text).First();
                        product.Measure += measure;

                        if (report == null)
                        {
                            report = new Report();
                            report.BuyAmount = product.BuyingPrice*measure;

                            db.Reports.Add(report);
                        }
                        else
                        {
                            report.BuyAmount = product.BuyingPrice * measure;
                        }
                        
                        db.SaveChanges();
                    };
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Məlumatlarda problem var!");
            }
        }

        private void BuyExistingProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.databaseDataSet.Product);

        }
    }
}
