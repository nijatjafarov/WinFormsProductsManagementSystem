
namespace ProductManagement
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(865, 71);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(121, 46);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Hesabat";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.Location = new System.Drawing.Point(1052, 71);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(121, 46);
            this.saleButton.TabIndex = 2;
            this.saleButton.Text = "Satış";
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(1238, 71);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(121, 46);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Alış";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(76, 98);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(315, 31);
            this.searchBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(76, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1283, 629);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mallar üzrə axtarış et";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 890);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.reportButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}

