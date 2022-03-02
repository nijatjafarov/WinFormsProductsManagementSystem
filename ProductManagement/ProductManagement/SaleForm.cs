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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.databaseDataSet1.Product);

        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            float measure = 0;
            float salePrice = 0;

            using (DatabaseEntities db = new DatabaseEntities())
            {
                Product product = db.Products.Where(p => p.ProductName == productsBox.Text).First();

                bool measureParse = float.TryParse(measureBox.Text, out measure);

                if (measureParse & product.Measure < measure)
                {
                    MessageBox.Show("Anbarda bu qədər məhsul yoxdur");
                }
                else
                {
                    if (measureParse &&
                        float.TryParse(saleBox.Text, out salePrice) &&
                        productsBox.Text != "")
                    {
                        DataGridViewRow row = (DataGridViewRow)orderList.Rows[0].Clone();

                        row.Cells[0].Value = productsBox.Text;
                        row.Cells[1].Value = measureBox.Text;
                        row.Cells[2].Value = saleBox.Text;
                        row.Cells[3].Value = float.Parse(measureBox.Text) * float.Parse(saleBox.Text);
                        row.Cells[4].Value = (float.Parse(saleBox.Text) - product.BuyingPrice) *
                            float.Parse(measureBox.Text);
                        orderList.Rows.Add(row);

                        measureBox.Text = "";
                        saleBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Məlumatlarda problem var!");
                    }
                    product.Measure -= measure;
                }
            };
        }

        private void removeOrderBtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in orderList.SelectedRows)
            {
                orderList.Rows.Remove(row);
            }
        }

        float total = 0;
        float totalBenefit = 0;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < orderList.Rows.Count-1; i++)
            {
                total += float.Parse(orderList.Rows[i].Cells[3].Value.ToString());
                totalBenefit += float.Parse(orderList.Rows[i].Cells[4].Value.ToString());
            }

            amount.Text = total.ToString();
            benefit.Text = totalBenefit.ToString();

            confirmButton.Enabled = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            

            DialogResult dialogResult = MessageBox.Show("Satışı təsdiqləmək istədiyinizə əminsiniz?", "Məhsul satışı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DateTime date = DateTime.Now.Date;

                using (DatabaseEntities db = new DatabaseEntities())
                {
                    Report report = db.Reports.Where(r => r.Date == date).FirstOrDefault();

                    if (report == null)
                    {
                        report = new Report();
                        report.Benefit = totalBenefit;
                        report.SaleAmount = total;

                        db.Reports.Add(report);
                    }
                    else
                    {
                        report.Benefit += totalBenefit;
                        report.SaleAmount += total;
                    }

                    db.SaveChanges();
                }

                for (int i = 0; i < orderList.Rows.Count - 1; i++)
                {
                    using (DatabaseEntities db = new DatabaseEntities())
                    {
                        string productName = orderList.Rows[i].Cells[0].Value.ToString();

                        Product product = db.Products.Where(p => p.ProductName == productName).First();

                        product.Measure -= float.Parse(orderList.Rows[i].Cells[1].Value.ToString());

                        db.SaveChanges();
                    }
                }

                this.Close();
            }
        }
    }
}
