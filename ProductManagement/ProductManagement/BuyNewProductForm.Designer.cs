
namespace ProductManagement
{
    partial class BuyNewProductForm
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
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.measureTypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saleRentBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buyPriceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.measureBox = new System.Windows.Forms.TextBox();
            this.salePriceBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(68, 86);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(197, 31);
            this.productNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Məhsulun adı";
            // 
            // measureTypeBox
            // 
            this.measureTypeBox.FormattingEnabled = true;
            this.measureTypeBox.Items.AddRange(new object[] {
            "metr",
            "ədəd",
            "kq",
            "metr^2",
            "dəstə",
            "metr^3",
            "paket",
            "litr"});
            this.measureTypeBox.Location = new System.Drawing.Point(369, 86);
            this.measureTypeBox.Name = "measureTypeBox";
            this.measureTypeBox.Size = new System.Drawing.Size(197, 33);
            this.measureTypeBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Məhsulun miqdarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Məhsulun ölçü vahidi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Satış/İcarə";
            // 
            // saleRentBox
            // 
            this.saleRentBox.FormattingEnabled = true;
            this.saleRentBox.Items.AddRange(new object[] {
            "Satış",
            "İcarə"});
            this.saleRentBox.Location = new System.Drawing.Point(68, 201);
            this.saleRentBox.Name = "saleRentBox";
            this.saleRentBox.Size = new System.Drawing.Size(197, 33);
            this.saleRentBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Məhsulun satış qiyməti";
            // 
            // buyPriceBox
            // 
            this.buyPriceBox.Location = new System.Drawing.Point(68, 313);
            this.buyPriceBox.Name = "buyPriceBox";
            this.buyPriceBox.Size = new System.Drawing.Size(197, 31);
            this.buyPriceBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Məhsulun alış qiyməti";
            // 
            // measureBox
            // 
            this.measureBox.Location = new System.Drawing.Point(369, 201);
            this.measureBox.Name = "measureBox";
            this.measureBox.Size = new System.Drawing.Size(197, 31);
            this.measureBox.TabIndex = 0;
            // 
            // salePriceBox
            // 
            this.salePriceBox.Location = new System.Drawing.Point(369, 313);
            this.salePriceBox.Name = "salePriceBox";
            this.salePriceBox.Size = new System.Drawing.Size(197, 31);
            this.salePriceBox.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(68, 405);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(498, 42);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Təsdiqlə";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // BuyNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 509);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.saleRentBox);
            this.Controls.Add(this.measureTypeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.measureBox);
            this.Controls.Add(this.salePriceBox);
            this.Controls.Add(this.buyPriceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BuyNewProductForm";
            this.Text = "Yeni məhsul alışı";
            this.Load += new System.EventHandler(this.BuyNewProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox measureTypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox saleRentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buyPriceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox measureBox;
        private System.Windows.Forms.TextBox salePriceBox;
        private System.Windows.Forms.Button confirmButton;
    }
}