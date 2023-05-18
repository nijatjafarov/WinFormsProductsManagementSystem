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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ReportForm_Activated(object sender, EventArgs e)
        {
            
        }

        public int day;
        

        private void dailyReports_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dailyReports.Rows[dailyReports.SelectedCells[0].RowIndex];
            Report report;
            day = int.Parse(row.Cells[0].Value.ToString());

            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, day);
            using (DatabaseEntities db = new DatabaseEntities())
            {
                report = db.Reports.Where(r => r.Date == date).FirstOrDefault();
            }
            LoginForm loginForm = new LoginForm(report, row);
            loginForm.Show();
        }

        private void dailyReports_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            day = int.Parse(dailyReports.Rows[dailyReports.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
        }

        private void ReportForm_Load_1(object sender, EventArgs e)
        {
            this.Size = new Size(1054 / 2, 918 / 2);

            double[] monthlySales = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] monthlyBuyes = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] monthlyBenefits = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string[] months = { "Yanvar", "Fevral", "Mart", "Aprel", "May", "Iyun", "Iyul",
                "Avqust", "Sentyabr", "Oktyabr", "Noyabr", "Dekabr" };
            using (DatabaseEntities db = new DatabaseEntities())
            {
                IList<Report> reports = db.Reports.ToList<Report>();

                foreach (Report report in reports)
                {
                    if (report.Date.Year == DateTime.Now.Year)
                    {
                        switch (report.Date.Month)
                        {
                            case 1:
                                monthlySales[0] += report.SaleAmount;
                                monthlyBuyes[0] += report.BuyAmount;
                                monthlyBenefits[0] += report.Benefit;
                                break;
                            case 2:
                                monthlySales[1] += report.SaleAmount;
                                monthlyBuyes[1] += report.BuyAmount;
                                monthlyBenefits[1] += report.Benefit;
                                break;
                            case 3:
                                monthlySales[2] += report.SaleAmount;
                                monthlyBuyes[2] += report.BuyAmount;
                                monthlyBenefits[2] += report.Benefit;
                                break;
                            case 4:
                                monthlySales[3] += report.SaleAmount;
                                monthlyBuyes[3] += report.BuyAmount;
                                monthlyBenefits[3] += report.Benefit;
                                break;
                            case 5:
                                monthlySales[4] += report.SaleAmount;
                                monthlyBuyes[4] += report.BuyAmount;
                                monthlyBenefits[4] += report.Benefit;
                                break;
                            case 6:
                                monthlySales[5] += report.SaleAmount;
                                monthlyBuyes[5] += report.BuyAmount;
                                monthlyBenefits[5] += report.Benefit;
                                break;
                            case 7:
                                monthlySales[6] += report.SaleAmount;
                                monthlyBuyes[6] += report.BuyAmount;
                                monthlyBenefits[6] += report.Benefit;
                                break;
                            case 8:
                                monthlySales[7] += report.SaleAmount;
                                monthlyBuyes[7] += report.BuyAmount;
                                monthlyBenefits[7] += report.Benefit;
                                break;
                            case 9:
                                monthlySales[8] += report.SaleAmount;
                                monthlyBuyes[8] += report.BuyAmount;
                                monthlyBenefits[8] += report.Benefit;
                                break;
                            case 10:
                                monthlySales[9] += report.SaleAmount;
                                monthlyBuyes[9] += report.BuyAmount;
                                monthlyBenefits[9] += report.Benefit;
                                break;
                            case 11:
                                monthlySales[10] += report.SaleAmount;
                                monthlyBuyes[10] += report.BuyAmount;
                                monthlyBenefits[10] += report.Benefit;
                                break;
                            case 12:
                                monthlySales[11] += report.SaleAmount;
                                monthlyBuyes[11] += report.BuyAmount;
                                monthlyBenefits[11] += report.Benefit;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        db.Reports.Remove(report);
                        db.SaveChanges();
                    }

                    if (report.Date.Month == DateTime.Now.Month)
                    {
                        DataGridViewRow dailyRow = (DataGridViewRow)monthlyReports.Rows[0].Clone();

                        dailyRow.Cells[0].Value = report.Date.Day;
                        dailyRow.Cells[1].Value = report.BuyAmount;
                        dailyRow.Cells[2].Value = report.SaleAmount;
                        dailyRow.Cells[3].Value = report.Benefit;
                        dailyReports.Rows.Add(dailyRow);
                    }
                }
            }

            for (int i = 0; i < 12; i++)
            {
                DataGridViewRow monthlyRow = (DataGridViewRow)monthlyReports.Rows[0].Clone();

                monthlyRow.Cells[0].Value = months[i];
                monthlyRow.Cells[1].Value = monthlyBuyes[i];
                monthlyRow.Cells[2].Value = monthlySales[i];
                monthlyRow.Cells[3].Value = monthlyBenefits[i];

                monthlyReports.Rows.Add(monthlyRow);
            }

        }
    }
}
