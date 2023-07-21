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
        int id = 0;
        public BuyNewProductForm()
        {
            InitializeComponent();
        }

        public BuyNewProductForm(DataGridViewRow _row)
        {
            InitializeComponent();
            row = _row;
            using (DatabaseEntities db = new DatabaseEntities())
            {
                string productName = row.Cells[0].Value.ToString();
                Product product = db.Products.Where(p => p.ProductName == productName).
                    FirstOrDefault();
                if (product != null)
                {
                    id = product.Id;
                }
            };
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
                measureTypeBox.Text != "")
            {
                if (id != 0)
                {
                    using (DatabaseEntities db = new DatabaseEntities())
                    {
                        if ((db.Products.Where(p => p.ProductName == productNameBox.Text).Count() == 1 &&
                            db.Products.Where(p => p.ProductName == productNameBox.Text).FirstOrDefault().Id == id) ||
                            (db.Products.Where(p => p.ProductName == productNameBox.Text).Count()  == 0))
                        {
                            Product product = db.Products.Find(id);
                            product.ProductName = productNameBox.Text;
                            product.SaleOrRent = "Satış";
                            product.MeasurementUnit = measureTypeBox.Text;
                            product.Measure = Math.Round(measure,2);
                            product.BuyingPrice = Math.Round(buyingPrice, 2);
                            product.SalePrice = Math.Round(salePrice, 2);

                            db.SaveChanges();
                            MessageBox.Show("Dəyişiklər qeyd olundu!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Bu adda məhsul mövcuddur!");
                        }
                    }
                }
                else
                {
                    using (DatabaseEntities db = new DatabaseEntities())
                    {
                        if (db.Products.Where(p => p.ProductName == productNameBox.Text).FirstOrDefault() == null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Məhsulu anbara əlavə etmək istədiyinizə əminsiniz?", "Məhsul alışı", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                DateTime date = DateTime.Now.Date;


                                Product product = new Product()
                                {
                                    ProductName = productNameBox.Text,
                                    SaleOrRent = "Satış",
                                    MeasurementUnit = measureTypeBox.Text,
                                    Measure = Math.Round(measure, 2),
                                    BuyingPrice = Math.Round(buyingPrice, 2),
                                    SalePrice = Math.Round(salePrice, 2)
                                };

                                Report report = db.Reports.Where(r => r.Date == date).FirstOrDefault();


                                if (report == null)
                                {
                                    report = new Report();
                                    report.Date = date;
                                    report.Benefit = 0;
                                    report.SaleAmount = 0;
                                    report.BuyAmount = Math.Round(buyingPrice, 2) * Math.Round(measure, 2);

                                    db.Reports.Add(report);
                                }
                                else
                                {
                                    report.BuyAmount += Math.Round(buyingPrice, 2) * Math.Round(measure, 2);
                                }

                                db.Products.Add(product);

                                db.SaveChanges();
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Bu adda məhsul mövcuddur!");
                        }
                    }
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
                measureTypeBox.Text = row.Cells[1].Value.ToString();
                measureBox.Text = row.Cells[2].Value.ToString();
                buyPriceBox.Text = row.Cells[3].Value.ToString();
                salePriceBox.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
