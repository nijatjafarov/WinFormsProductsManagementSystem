
namespace ProductManagement
{
    partial class SaleForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.productsBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new ProductManagement.DatabaseDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.measureBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saleBox = new System.Windows.Forms.TextBox();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.removeOrderBtn = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.productTableAdapter = new ProductManagement.DatabaseDataSet1TableAdapters.ProductTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.benefit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Məhsul seç";
            // 
            // productsBox
            // 
            this.productsBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductName", true));
            this.productsBox.DataSource = this.productBindingSource;
            this.productsBox.DisplayMember = "ProductName";
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(101, 94);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(234, 33);
            this.productsBox.TabIndex = 1;
            this.productsBox.ValueMember = "ProductName";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Məhsulun miqdarı";
            // 
            // measureBox
            // 
            this.measureBox.Location = new System.Drawing.Point(398, 94);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(234, 31);
            this.measureBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Məhsulun vahid üzrə qiyməti";
            // 
            // saleBox
            // 
            this.saleBox.Location = new System.Drawing.Point(695, 94);
            this.saleBox.Name = "saleBox";
            this.saleBox.Size = new System.Drawing.Size(234, 31);
            this.saleBox.TabIndex = 3;
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Location = new System.Drawing.Point(392, 174);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(87, 75);
            this.addOrderBtn.TabIndex = 4;
            this.addOrderBtn.Text = "+";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Toplam tutar:";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(234, 691);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(0, 37);
            this.amount.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(101, 747);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(235, 56);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Hesabla";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Enabled = false;
            this.confirmButton.Location = new System.Drawing.Point(694, 747);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(235, 56);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Satışı təsdiqlə";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // removeOrderBtn
            // 
            this.removeOrderBtn.Location = new System.Drawing.Point(521, 174);
            this.removeOrderBtn.Name = "removeOrderBtn";
            this.removeOrderBtn.Size = new System.Drawing.Size(87, 75);
            this.removeOrderBtn.TabIndex = 4;
            this.removeOrderBtn.Text = "-";
            this.removeOrderBtn.UseVisualStyleBackColor = true;
            this.removeOrderBtn.Click += new System.EventHandler(this.removeOrderBtn_Click);
            // 
            // orderList
            // 
            this.orderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.orderList.Location = new System.Drawing.Point(101, 331);
            this.orderList.Name = "orderList";
            this.orderList.RowHeadersWidth = 82;
            this.orderList.RowTemplate.Height = 33;
            this.orderList.Size = new System.Drawing.Size(828, 337);
            this.orderList.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Məhsulun adı";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Miqdar";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vahid üzrə qiymət";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ümumi qiymət";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Xeyir";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sifarişlərin siyahısı";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 697);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Xeyir:";
            // 
            // benefit
            // 
            this.benefit.AutoSize = true;
            this.benefit.BackColor = System.Drawing.SystemColors.Control;
            this.benefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benefit.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.benefit.Location = new System.Drawing.Point(441, 691);
            this.benefit.Name = "benefit";
            this.benefit.Size = new System.Drawing.Size(0, 37);
            this.benefit.TabIndex = 5;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 882);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.benefit);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeOrderBtn);
            this.Controls.Add(this.addOrderBtn);
            this.Controls.Add(this.saleBox);
            this.Controls.Add(this.measureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaleForm";
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox measureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saleBox;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button removeOrderBtn;
        private System.Windows.Forms.DataGridView orderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label5;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseDataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label benefit;
    }
}