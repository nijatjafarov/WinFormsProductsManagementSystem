using ProductManagement.App_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class LoginForm : Form
    {
        DataGridViewSelectedRowCollection rows = null;
        DataGridViewRow row = null;
        Report report = null;
        string task = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(DataGridViewSelectedRowCollection _rows, string _task)
        {
            InitializeComponent();
            rows = _rows;
            task = _task;
        }

        public LoginForm(Report _report, DataGridViewRow _row)
        {
            InitializeComponent();
            report = _report;
            row = _row;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if (usernameBox.Text == "randomname")
            {
                if (passwordBox.Text == "randompassword994")
                {
                    if (task == "update")
                    {
                        Form updateForm = new BuyNewProductForm(rows[0]);
                        updateForm.Text = "Məhsul məlumatlarını redaktə et";
                        updateForm.Show();
                        this.Close();
                    }
                    else if (task == "delete")
                    {
                        using (DatabaseEntities db = new DatabaseEntities())
                        {
                            foreach (DataGridViewRow row in rows)
                            {
                                string productName = row.Cells[0].Value.ToString();
                                Product product = db.Products.Where(p => p.ProductName == productName).
                                    FirstOrDefault();
                                if (product != null)
                                {
                                    db.Products.Remove(product);
                                }
                            }
                            db.SaveChanges();
                        }
                        this.Close();
                    }
                    if (report != null & row != null)
                    {
                        using (DatabaseEntities db = new DatabaseEntities())
                        {
                            Report updatedReport = db.Reports.Find(report.Id);
                            double buy;
                            double sale;
                            double benefit;

                            if(double.TryParse(row.Cells[1].Value.ToString(), out buy))
                            {
                                updatedReport.BuyAmount = Math.Round(buy, 2);
                            }
                            if (double.TryParse(row.Cells[2].Value.ToString(), out sale))
                            {
                                updatedReport.SaleAmount = Math.Round(sale, 2);
                            }
                            if (double.TryParse(row.Cells[3].Value.ToString(), out benefit))
                            {
                                updatedReport.Benefit = Math.Round(benefit, 2);
                            }
                            db.SaveChanges();
                        }
                        MessageBox.Show("Dəyişiklər qeyd olundu! Görmək üçün hesabata yenidən daxil olun!");
                        this.Close();
                        Application.OpenForms["ReportForm"].Close();
                    }
                }
                else
                {
                    MessageBox.Show("Şifrə yalnışdır!");
                }
            }
            else
            {
                MessageBox.Show("İstifadəçi adı yalnışdır!");
            }
        }
    }
}
