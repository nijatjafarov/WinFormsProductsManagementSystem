using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class BackupForm : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["BackUpEntities"].ConnectionString;
        string[] connectionStringParts;

        public BackupForm()
        {
            InitializeComponent();
            connectionStringParts = connectionString.Split(';');
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                backupButton.Enabled = true;
            }
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Zəhmət olmasa ünvan daxil edin.");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string backupCommand = $"BACKUP DATABASE [{Directory.GetCurrentDirectory()}" + "\\Database.mdf] TO DISK = '" + textBox1.Text + "\\database-" + DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(backupCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Verilənlər bazası uğurla nüsxələndi");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                backupButton.Enabled = false;
            }
            else
            {
                backupButton.Enabled = true;
            }
        }
    }
}
