
namespace ProductManagement
{
    partial class BuyExistingProductForm
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
            this.databaseDataSet = new ProductManagement.DatabaseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.measureBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.productTableAdapter = new ProductManagement.DatabaseDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Məhsulu seç";
            // 
            // productsBox
            // 
            this.productsBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductName", true));
            this.productsBox.DataSource = this.productBindingSource;
            this.productsBox.DisplayMember = "ProductName";
            this.productsBox.FormattingEnabled = true;
            this.productsBox.Location = new System.Drawing.Point(53, 79);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(219, 33);
            this.productsBox.TabIndex = 1;
            this.productsBox.ValueMember = "ProductName";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "miqdarı";
            // 
            // measureBox
            // 
            this.measureBox.Location = new System.Drawing.Point(53, 184);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(219, 31);
            this.measureBox.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(53, 260);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(219, 43);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Təsdiqlə";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // BuyExistingProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 349);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.measureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BuyExistingProductForm";
            this.Text = "Mövcud məhsul alışı";
            this.Load += new System.EventHandler(this.BuyExistingProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox measureBox;
        private System.Windows.Forms.Button confirmButton;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DatabaseDataSetTableAdapters.ProductTableAdapter productTableAdapter;
    }
}