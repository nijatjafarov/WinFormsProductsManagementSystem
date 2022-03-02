using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManagement.App_Data;

namespace ProductManagement
{
    public partial class BuyNewProductForm : Form
    {
        DataGridViewRow row = null;
        public BuyNewProductForm()
        {
            InitializeComponent();
        }

        public BuyNewProductForm(DataGridViewRow _row)
        {
            InitializeComponent();
            row = _row;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            float measure = 0;
            float buyingPrice = 0;
            float salePrice = 0;

            if (float.TryParse(measureBox.Text, out measure) && 
                float.TryParse(buyPriceBox.Text, out buyingPrice) &&
                float.TryParse(salePriceBox.Text, out salePrice) &&
                productNameBox.Text != "" &&
                saleRentBox.Text != "" &&
                measureTypeBox.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Məhsulu anbara əlavə etmək istədiyinizə əminsiniz?", "Məhsul alışı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DateTime date = DateTime.Now.Date;

                    using (DatabaseEntities db = new DatabaseEntities())
                    {
                        Product product = new Product()
                        {
                            ProductName = productNameBox.Text,
                            SaleOrRent = saleRentBox.Text,
                            MeasurementUnit = measureTypeBox.Text,
                            Measure = measure,
                            BuyingPrice = buyingPrice,
                            SalePrice = salePrice
                        };

                        Report report = db.Reports.Where(r => r.Date == date).FirstOrDefault();


                        if (report == null)
                        {
                            report = new Report();
                            report.BuyAmount = buyingPrice * measure;

                            db.Reports.Add(report);
                        }
                        else
                        {
                            report.BuyAmount += buyingPrice * measure;
                        }

                        db.Products.Add(product);
                        
                        db.SaveChanges();
                    };


                    this.Close();

                    Form1 form = new Form1();
                    form.Show();
                    Application.OpenForms["Form1"].Close();
                }
            }
            else
            {
                MessageBox.Show("Məlumatlarda problem var!");
            }
        }

        private void BuyNewProductForm_Load(object sender, EventArgs e)
        {
            if (row != null)
            {
                productNameBox.Text = row.Cells[0].Value.ToString();
                saleRentBox.Text = row.Cells[1].Value.ToString();
                measureTypeBox.Text = row.Cells[2].Value.ToString();
                measureBox.Text = row.Cells[3].Value.ToString();
                buyPriceBox.Text = row.Cells[4].Value.ToString();
                salePriceBox.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
