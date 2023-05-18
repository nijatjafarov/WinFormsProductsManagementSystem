
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reportButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.productList = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleOrRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet = new ProductManagement.ProductsDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.productTableAdapter = new ProductManagement.ProductsDataSetTableAdapters.ProductTableAdapter();
            this.deleteProducts = new System.Windows.Forms.Button();
            this.backUpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(923, 84);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(121, 46);
            this.reportButton.TabIndex = 2;
            this.reportButton.Text = "Hesabat";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.Location = new System.Drawing.Point(1080, 84);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(121, 46);
            this.saleButton.TabIndex = 2;
            this.saleButton.Text = "Satış";
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(1238, 84);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(121, 46);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Alış";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(76, 92);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(315, 31);
            this.searchBox.TabIndex = 3;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // productList
            // 
            this.productList.AutoGenerateColumns = false;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.saleOrRentDataGridViewTextBoxColumn,
            this.measurementUnitDataGridViewTextBoxColumn,
            this.measureDataGridViewTextBoxColumn,
            this.buyingPriceDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn});
            this.productList.DataSource = this.productBindingSource;
            this.productList.Location = new System.Drawing.Point(76, 181);
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.RowHeadersWidth = 82;
            this.productList.RowTemplate.Height = 33;
            this.productList.Size = new System.Drawing.Size(1283, 629);
            this.productList.TabIndex = 4;
            this.productList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productList_RowHeaderMouseClick);
            this.productList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.productList_RowHeaderMouseDoubleClick);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Malın adı";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // saleOrRentDataGridViewTextBoxColumn
            // 
            this.saleOrRentDataGridViewTextBoxColumn.DataPropertyName = "SaleOrRent";
            this.saleOrRentDataGridViewTextBoxColumn.HeaderText = "Satış/İcarə";
            this.saleOrRentDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.saleOrRentDataGridViewTextBoxColumn.Name = "saleOrRentDataGridViewTextBoxColumn";
            this.saleOrRentDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleOrRentDataGridViewTextBoxColumn.Width = 200;
            // 
            // measurementUnitDataGridViewTextBoxColumn
            // 
            this.measurementUnitDataGridViewTextBoxColumn.DataPropertyName = "MeasurementUnit";
            this.measurementUnitDataGridViewTextBoxColumn.HeaderText = "Ölçü vahidi";
            this.measurementUnitDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.measurementUnitDataGridViewTextBoxColumn.Name = "measurementUnitDataGridViewTextBoxColumn";
            this.measurementUnitDataGridViewTextBoxColumn.ReadOnly = true;
            this.measurementUnitDataGridViewTextBoxColumn.Width = 200;
            // 
            // measureDataGridViewTextBoxColumn
            // 
            this.measureDataGridViewTextBoxColumn.DataPropertyName = "Measure";
            this.measureDataGridViewTextBoxColumn.HeaderText = "Miqdar";
            this.measureDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.measureDataGridViewTextBoxColumn.Name = "measureDataGridViewTextBoxColumn";
            this.measureDataGridViewTextBoxColumn.ReadOnly = true;
            this.measureDataGridViewTextBoxColumn.Width = 200;
            // 
            // buyingPriceDataGridViewTextBoxColumn
            // 
            this.buyingPriceDataGridViewTextBoxColumn.DataPropertyName = "BuyingPrice";
            this.buyingPriceDataGridViewTextBoxColumn.HeaderText = "Alış qiyməti";
            this.buyingPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.buyingPriceDataGridViewTextBoxColumn.Name = "buyingPriceDataGridViewTextBoxColumn";
            this.buyingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyingPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Satış qiyməti";
            this.salePriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.salePriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productsDataSet;
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mallar üzrə axtarış et";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // deleteProducts
            // 
            this.deleteProducts.Enabled = false;
            this.deleteProducts.Location = new System.Drawing.Point(642, 84);
            this.deleteProducts.Name = "deleteProducts";
            this.deleteProducts.Size = new System.Drawing.Size(248, 46);
            this.deleteProducts.TabIndex = 2;
            this.deleteProducts.Text = "Seçilmiş məhsulları sil";
            this.deleteProducts.UseVisualStyleBackColor = true;
            this.deleteProducts.Click += new System.EventHandler(this.deleteProducts_Click);
            // 
            // backUpButton
            // 
            this.backUpButton.Location = new System.Drawing.Point(435, 84);
            this.backUpButton.Name = "backUpButton";
            this.backUpButton.Size = new System.Drawing.Size(162, 46);
            this.backUpButton.TabIndex = 7;
            this.backUpButton.Text = "Nüsxələmə";
            this.backUpButton.UseVisualStyleBackColor = true;
            this.backUpButton.Click += new System.EventHandler(this.backUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1435, 884);
            this.Controls.Add(this.backUpButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.deleteProducts);
            this.Controls.Add(this.reportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Məhsulları idarə etmə proqramı";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button saleButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Label label3;
        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductsDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleOrRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteProducts;
        private System.Windows.Forms.Button backUpButton;
    }
}

