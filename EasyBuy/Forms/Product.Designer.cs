namespace EasyBuy.Forms.Product_Items
{
    partial class Product
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
            txtQunatity = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            txtGstAmount = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            txtBarcode = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            productDataGridView = new System.Windows.Forms.DataGridView();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PriceAfterDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GSTAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FinalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            txtPrice = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtGST = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtTotalPriceAfterDiscount = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtDiscountAmount = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            texPrice = new System.Windows.Forms.TextBox();
            txtDiscount = new System.Windows.Forms.TextBox();
            txtFinalPrice = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            btnPrint = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            textNoOfPrint = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txtQunatity
            // 
            txtQunatity.Location = new System.Drawing.Point(413, 64);
            txtQunatity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtQunatity.Name = "txtQunatity";
            txtQunatity.Size = new System.Drawing.Size(201, 27);
            txtQunatity.TabIndex = 4;
            txtQunatity.KeyPress += txtQunatity_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(337, 71);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 18);
            label7.TabIndex = 37;
            label7.Text = "Quantity";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(123, 23);
            cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(201, 28);
            cmbCategory.TabIndex = 1;
            cmbCategory.Text = "---Select---";
            // 
            // txtGstAmount
            // 
            txtGstAmount.AcceptsReturn = true;
            txtGstAmount.Location = new System.Drawing.Point(102, 67);
            txtGstAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtGstAmount.Name = "txtGstAmount";
            txtGstAmount.Size = new System.Drawing.Size(125, 27);
            txtGstAmount.TabIndex = 10;
            txtGstAmount.KeyPress += txtGstAmount_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(25, 25);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 18);
            label5.TabIndex = 34;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(29, 71);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(65, 18);
            label6.TabIndex = 33;
            label6.Text = "Amount";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(817, 268);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(96, 41);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btn_clear_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Location = new System.Drawing.Point(699, 268);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(96, 41);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btn_add_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(414, 25);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(201, 27);
            txtName.TabIndex = 2;
            // 
            // txtBarcode
            // 
            txtBarcode.Enabled = false;
            txtBarcode.Location = new System.Drawing.Point(14, 35);
            txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new System.Drawing.Size(125, 27);
            txtBarcode.TabIndex = 14;
            txtBarcode.Text = "Barcode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(355, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 18);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(163, 203, 56);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1378, 44);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(11, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // productDataGridView
            // 
            productDataGridView.AllowUserToAddRows = false;
            productDataGridView.AllowUserToDeleteRows = false;
            productDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Name, Qty, Price, TotalPrice, Discount, DiscountAmount, PriceAfterDiscount, GST, GSTAmount, FinalPrice, Actions });
            productDataGridView.Location = new System.Drawing.Point(27, 333);
            productDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.ReadOnly = true;
            productDataGridView.RowHeadersVisible = false;
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.RowTemplate.Height = 24;
            productDataGridView.Size = new System.Drawing.Size(1320, 590);
            productDataGridView.TabIndex = 39;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 125;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            Qty.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 125;
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount(%)";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.Width = 125;
            // 
            // DiscountAmount
            // 
            DiscountAmount.HeaderText = "Discount Amount";
            DiscountAmount.MinimumWidth = 6;
            DiscountAmount.Name = "DiscountAmount";
            DiscountAmount.ReadOnly = true;
            DiscountAmount.Width = 125;
            // 
            // PriceAfterDiscount
            // 
            PriceAfterDiscount.HeaderText = "Total Price After Discount";
            PriceAfterDiscount.MinimumWidth = 6;
            PriceAfterDiscount.Name = "PriceAfterDiscount";
            PriceAfterDiscount.ReadOnly = true;
            PriceAfterDiscount.Width = 125;
            // 
            // GST
            // 
            GST.HeaderText = "GST";
            GST.MinimumWidth = 6;
            GST.Name = "GST";
            GST.ReadOnly = true;
            GST.Width = 125;
            // 
            // GSTAmount
            // 
            GSTAmount.HeaderText = "GST Amount";
            GSTAmount.MinimumWidth = 6;
            GSTAmount.Name = "GSTAmount";
            GSTAmount.ReadOnly = true;
            GSTAmount.Width = 125;
            // 
            // FinalPrice
            // 
            FinalPrice.HeaderText = "Final Price";
            FinalPrice.MinimumWidth = 6;
            FinalPrice.Name = "FinalPrice";
            FinalPrice.ReadOnly = true;
            FinalPrice.Width = 125;
            // 
            // Actions
            // 
            Actions.HeaderText = "Actions";
            Actions.MinimumWidth = 6;
            Actions.Name = "Actions";
            Actions.ReadOnly = true;
            Actions.Width = 125;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(123, 64);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(201, 27);
            txtPrice.TabIndex = 3;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(54, 71);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 18);
            label4.TabIndex = 40;
            label4.Text = "Price";
            // 
            // txtGST
            // 
            txtGST.Location = new System.Drawing.Point(102, 25);
            txtGST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtGST.Name = "txtGST";
            txtGST.Size = new System.Drawing.Size(125, 27);
            txtGST.TabIndex = 9;
            txtGST.KeyPress += txtGST_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(38, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(56, 18);
            label8.TabIndex = 42;
            label8.Text = "GST%";
            // 
            // txtTotalPriceAfterDiscount
            // 
            txtTotalPriceAfterDiscount.Location = new System.Drawing.Point(213, 109);
            txtTotalPriceAfterDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTotalPriceAfterDiscount.Name = "txtTotalPriceAfterDiscount";
            txtTotalPriceAfterDiscount.Size = new System.Drawing.Size(125, 27);
            txtTotalPriceAfterDiscount.TabIndex = 8;
            txtTotalPriceAfterDiscount.KeyPress += txtTotalPriceAfterDiscount_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(7, 117);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(207, 18);
            label9.TabIndex = 44;
            label9.Text = "Total  Price After Discount";
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new System.Drawing.Point(213, 62);
            txtDiscountAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new System.Drawing.Size(125, 27);
            txtDiscountAmount.TabIndex = 7;
            txtDiscountAmount.KeyPress += txtDiscountAmount_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(70, 68);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(137, 18);
            label10.TabIndex = 46;
            label10.Text = "Discount Amount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(113, 29);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(94, 18);
            label11.TabIndex = 48;
            label11.Text = "Discount %";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(14, 113);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(90, 18);
            label12.TabIndex = 50;
            label12.Text = "Total Price";
            // 
            // texPrice
            // 
            texPrice.Location = new System.Drawing.Point(123, 113);
            texPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            texPrice.Name = "texPrice";
            texPrice.Size = new System.Drawing.Size(201, 27);
            texPrice.TabIndex = 5;
            texPrice.KeyPress += texPrice_KeyPress;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(213, 25);
            txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(125, 27);
            txtDiscount.TabIndex = 6;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new System.Drawing.Point(102, 104);
            txtFinalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.Size = new System.Drawing.Size(125, 27);
            txtFinalPrice.TabIndex = 11;
            txtFinalPrice.KeyPress += txtFinalPrice_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(6, 113);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(88, 18);
            label13.TabIndex = 52;
            label13.Text = "Final Price";
            // 
            // btnPrint
            // 
            btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPrint.Location = new System.Drawing.Point(355, 21);
            btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(126, 41);
            btnPrint.TabIndex = 16;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(texPrice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtQunatity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Location = new System.Drawing.Point(27, 52);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(639, 162);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtDiscount);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDiscountAmount);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtTotalPriceAfterDiscount);
            groupBox2.Location = new System.Drawing.Point(699, 52);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(369, 162);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Discount Details";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtFinalPrice);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtGstAmount);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtGST);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new System.Drawing.Point(1091, 52);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(256, 162);
            groupBox3.TabIndex = 57;
            groupBox3.TabStop = false;
            groupBox3.Text = "GST Details";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textNoOfPrint);
            groupBox4.Controls.Add(btnPrint);
            groupBox4.Controls.Add(txtBarcode);
            groupBox4.Location = new System.Drawing.Point(27, 237);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Size = new System.Drawing.Size(639, 78);
            groupBox4.TabIndex = 58;
            groupBox4.TabStop = false;
            groupBox4.Text = "Barcode";
            // 
            // textNoOfPrint
            // 
            textNoOfPrint.Location = new System.Drawing.Point(173, 35);
            textNoOfPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textNoOfPrint.Name = "textNoOfPrint";
            textNoOfPrint.Size = new System.Drawing.Size(125, 27);
            textNoOfPrint.TabIndex = 15;
            textNoOfPrint.Text = "No. of Print";
            // 
            // Product
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1378, 969);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(productDataGridView);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);         
            Text = "Products";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtQunatity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtGstAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productDataGridView;
        //private Keels_SuperMarket_DatabaseDataSet3TableAdapters.Product_TableTableAdapter product_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodcutQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPriceAfterDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox texPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textNoOfPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceAfterDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GST;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn Actions;
    }
}