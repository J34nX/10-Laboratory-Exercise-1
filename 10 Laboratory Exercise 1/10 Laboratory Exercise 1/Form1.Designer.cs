namespace _10_Laboratory_Exercise_1
{
    partial class frmAddProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProductName = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            gridViewProductList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtQuantity = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtPickerExpDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txtSellPrice = new TextBox();
            btnAddProduct = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(205, 63);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(273, 27);
            txtProductName.TabIndex = 0;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(205, 98);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(273, 29);
            cbCategory.TabIndex = 1;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerMfgDate.Location = new Point(205, 131);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(273, 29);
            dtPickerMfgDate.TabIndex = 2;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(495, 98);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(269, 167);
            richTxtDescription.TabIndex = 3;
            richTxtDescription.Text = "";
            // 
            // gridViewProductList
            // 
            gridViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProductList.Location = new Point(12, 314);
            gridViewProductList.Name = "gridViewProductList";
            gridViewProductList.Size = new Size(752, 183);
            gridViewProductList.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 5;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 8;
            label3.Text = "Category";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(205, 205);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(273, 27);
            txtQuantity.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 9;
            label4.Text = "Mgf. Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 174);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 11;
            label5.Text = "Exp. Date";
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerExpDate.Location = new Point(205, 170);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(273, 29);
            dtPickerExpDate.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 207);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 12;
            label6.Text = "Qty.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 240);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 14;
            label7.Text = "Sell Price";
            // 
            // txtSellPrice
            // 
            txtSellPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSellPrice.Location = new Point(205, 238);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(273, 27);
            txtSellPrice.TabIndex = 13;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.Location = new Point(646, 271);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(118, 37);
            btnAddProduct.TabIndex = 15;
            btnAddProduct.Text = "Add product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(495, 65);
            label8.Name = "label8";
            label8.Size = new Size(108, 25);
            label8.TabIndex = 16;
            label8.Text = "Description";
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 508);
            Controls.Add(label8);
            Controls.Add(btnAddProduct);
            Controls.Add(label7);
            Controls.Add(txtSellPrice);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtPickerExpDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridViewProductList);
            Controls.Add(richTxtDescription);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtProductName);
            Name = "frmAddProduct";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private RichTextBox richTxtDescription;
        private DataGridView gridViewProductList;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtQuantity;
        private Label label4;
        private Label label5;
        private DateTimePicker dtPickerExpDate;
        private Label label6;
        private Label label7;
        private TextBox txtSellPrice;
        private Button btnAddProduct;
        private Label label8;
    }
}
