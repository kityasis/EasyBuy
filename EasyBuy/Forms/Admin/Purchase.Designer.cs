namespace EasyBuy.Forms.Product_Items
{
    partial class Purchase
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
            components = new System.ComponentModel.Container();
            txtQunatity = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            txtSGstAmount = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            PurchaseDataGridView = new System.Windows.Forms.DataGridView();
            productBindingSource = new System.Windows.Forms.BindingSource(components);
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
            txtTotalPrice = new System.Windows.Forms.TextBox();
            txtDiscount = new System.Windows.Forms.TextBox();
            txtFinalPrice = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            cmbSupplier = new System.Windows.Forms.ComboBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            txtCGstAmount = new System.Windows.Forms.TextBox();
            purchaseBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalBaseBuyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            discountOnBaseBuyPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            inputGSTPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            inputSGSTAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            inputCGSTAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtQunatity
            // 
            txtQunatity.Location = new System.Drawing.Point(98, 113);
            txtQunatity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtQunatity.Name = "txtQunatity";
            txtQunatity.Size = new System.Drawing.Size(201, 27);
            txtQunatity.TabIndex = 5;
            txtQunatity.TextChanged += txtQunatity_TextChanged;
            txtQunatity.KeyPress += txtQunatity_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(22, 120);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 18);
            label7.TabIndex = 37;
            label7.Text = "Quantity";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(414, 28);
            cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(201, 28);
            cmbCategory.TabIndex = 2;
            cmbCategory.Text = "---Select---";
            // 
            // txtSGstAmount
            // 
            txtSGstAmount.AcceptsReturn = true;
            txtSGstAmount.Location = new System.Drawing.Point(119, 68);
            txtSGstAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSGstAmount.Name = "txtSGstAmount";
            txtSGstAmount.ReadOnly = true;
            txtSGstAmount.Size = new System.Drawing.Size(105, 27);
            txtSGstAmount.TabIndex = 854;
            txtSGstAmount.KeyPress += txtGstAmount_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(329, 35);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 18);
            label5.TabIndex = 34;
            label5.Text = "Category";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(1431, 172);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(96, 41);
            btnClear.TabIndex = 9;
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
            btnAdd.Location = new System.Drawing.Point(1431, 113);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(96, 41);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btn_add_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(98, 61);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(201, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(39, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 18);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(72, 52, 212);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1598, 44);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(11, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Purchase";
            // 
            // PurchaseDataGridView
            // 
            PurchaseDataGridView.AllowUserToAddRows = false;
            PurchaseDataGridView.AllowUserToDeleteRows = false;
            PurchaseDataGridView.AutoGenerateColumns = false;
            PurchaseDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            PurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PurchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn, catagoryDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, basePriceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, totalBaseBuyPriceDataGridViewTextBoxColumn, discountOnBaseBuyPriceDataGridViewTextBoxColumn, totalPurchaseDiscountAmountDataGridViewTextBoxColumn, totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn, inputGSTPercentageDataGridViewTextBoxColumn, inputSGSTAmountDataGridViewTextBoxColumn, inputCGSTAmountDataGridViewTextBoxColumn, totalPurchaseCostInclGSTDataGridViewTextBoxColumn, Edit, Delete });
            PurchaseDataGridView.DataSource = purchaseBindingSource;
            PurchaseDataGridView.Location = new System.Drawing.Point(27, 239);
            PurchaseDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PurchaseDataGridView.Name = "PurchaseDataGridView";
            PurchaseDataGridView.ReadOnly = true;
            PurchaseDataGridView.RowHeadersVisible = false;
            PurchaseDataGridView.RowHeadersWidth = 51;
            PurchaseDataGridView.RowTemplate.Height = 24;
            PurchaseDataGridView.Size = new System.Drawing.Size(1500, 513);
            PurchaseDataGridView.TabIndex = 39;
            PurchaseDataGridView.CellContentClick += ProductDataGridView_CellContentClick;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(414, 68);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(201, 27);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(358, 80);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 18);
            label4.TabIndex = 40;
            label4.Text = "Price";
            // 
            // txtGST
            // 
            txtGST.Location = new System.Drawing.Point(119, 26);
            txtGST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtGST.Name = "txtGST";
            txtGST.Size = new System.Drawing.Size(209, 27);
            txtGST.TabIndex = 7;
            txtGST.TextChanged += txtGST_TextChanged;
            txtGST.KeyPress += txtGST_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(57, 28);
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
            txtTotalPriceAfterDiscount.ReadOnly = true;
            txtTotalPriceAfterDiscount.Size = new System.Drawing.Size(125, 27);
            txtTotalPriceAfterDiscount.TabIndex = 54;
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
            txtDiscountAmount.Location = new System.Drawing.Point(213, 61);
            txtDiscountAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new System.Drawing.Size(125, 27);
            txtDiscountAmount.TabIndex = 745;
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
            label12.Location = new System.Drawing.Point(318, 123);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(90, 18);
            label12.TabIndex = 50;
            label12.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new System.Drawing.Point(414, 117);
            txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new System.Drawing.Size(201, 27);
            txtTotalPrice.TabIndex = 88;
            txtTotalPrice.KeyPress += texPrice_KeyPress;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(213, 25);
            txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(125, 27);
            txtDiscount.TabIndex = 6;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new System.Drawing.Point(119, 109);
            txtFinalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.ReadOnly = true;
            txtFinalPrice.Size = new System.Drawing.Size(209, 27);
            txtFinalPrice.TabIndex = 54;
            txtFinalPrice.KeyPress += txtFinalPrice_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(25, 117);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(88, 18);
            label13.TabIndex = 52;
            label13.Text = "Final Price";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(cmbSupplier);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtTotalPrice);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtQunatity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Location = new System.Drawing.Point(27, 52);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(639, 163);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(23, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 18);
            label2.TabIndex = 52;
            label2.Text = "Supplier";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new System.Drawing.Point(98, 24);
            cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new System.Drawing.Size(201, 28);
            cmbSupplier.TabIndex = 1;
            cmbSupplier.Text = "---Select---";
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
            groupBox2.Size = new System.Drawing.Size(369, 163);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Discount Details";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtCGstAmount);
            groupBox3.Controls.Add(txtFinalPrice);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtSGstAmount);
            groupBox3.Controls.Add(txtGST);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new System.Drawing.Point(1091, 52);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(334, 163);
            groupBox3.TabIndex = 57;
            groupBox3.TabStop = false;
            groupBox3.Text = "GST Details";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(25, 72);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(75, 18);
            label6.TabIndex = 857;
            label6.Text = "S/C GST";
            // 
            // txtCGstAmount
            // 
            txtCGstAmount.AcceptsReturn = true;
            txtCGstAmount.Location = new System.Drawing.Point(230, 68);
            txtCGstAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCGstAmount.Name = "txtCGstAmount";
            txtCGstAmount.ReadOnly = true;
            txtCGstAmount.Size = new System.Drawing.Size(98, 27);
            txtCGstAmount.TabIndex = 856;
            // 
            // purchaseBindingSource
            // 
            purchaseBindingSource.DataSource = typeof(Models.Purchase);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            supplierDataGridViewTextBoxColumn.ReadOnly = true;
            supplierDataGridViewTextBoxColumn.Width = 125;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            catagoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            catagoryDataGridViewTextBoxColumn.ReadOnly = true;
            catagoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            basePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            basePriceDataGridViewTextBoxColumn.ReadOnly = true;
            basePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalBaseBuyPriceDataGridViewTextBoxColumn
            // 
            totalBaseBuyPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalBaseBuyPrice";
            totalBaseBuyPriceDataGridViewTextBoxColumn.HeaderText = "TotalBaseBuyPrice";
            totalBaseBuyPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalBaseBuyPriceDataGridViewTextBoxColumn.Name = "totalBaseBuyPriceDataGridViewTextBoxColumn";
            totalBaseBuyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            totalBaseBuyPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountOnBaseBuyPriceDataGridViewTextBoxColumn
            // 
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.DataPropertyName = "DiscountOnBaseBuyPrice";
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.HeaderText = "DiscountOnBaseBuyPrice";
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.Name = "discountOnBaseBuyPriceDataGridViewTextBoxColumn";
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPurchaseDiscountAmountDataGridViewTextBoxColumn
            // 
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalPurchaseDiscountAmount";
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.HeaderText = "TotalPurchaseDiscountAmount";
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.Name = "totalPurchaseDiscountAmountDataGridViewTextBoxColumn";
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.ReadOnly = true;
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn
            // 
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.DataPropertyName = "TotalBaseBuyPriceAfterDiscount";
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.HeaderText = "TotalBaseBuyPriceAfterDiscount";
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.Name = "totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn";
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.Width = 125;
            // 
            // inputGSTPercentageDataGridViewTextBoxColumn
            // 
            inputGSTPercentageDataGridViewTextBoxColumn.DataPropertyName = "InputGSTPercentage";
            inputGSTPercentageDataGridViewTextBoxColumn.HeaderText = "InputGSTPercentage";
            inputGSTPercentageDataGridViewTextBoxColumn.MinimumWidth = 6;
            inputGSTPercentageDataGridViewTextBoxColumn.Name = "inputGSTPercentageDataGridViewTextBoxColumn";
            inputGSTPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            inputGSTPercentageDataGridViewTextBoxColumn.Width = 125;
            // 
            // inputSGSTAmountDataGridViewTextBoxColumn
            // 
            inputSGSTAmountDataGridViewTextBoxColumn.DataPropertyName = "InputSGSTAmount";
            inputSGSTAmountDataGridViewTextBoxColumn.HeaderText = "InputSGSTAmount";
            inputSGSTAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            inputSGSTAmountDataGridViewTextBoxColumn.Name = "inputSGSTAmountDataGridViewTextBoxColumn";
            inputSGSTAmountDataGridViewTextBoxColumn.ReadOnly = true;
            inputSGSTAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // inputCGSTAmountDataGridViewTextBoxColumn
            // 
            inputCGSTAmountDataGridViewTextBoxColumn.DataPropertyName = "InputCGSTAmount";
            inputCGSTAmountDataGridViewTextBoxColumn.HeaderText = "InputCGSTAmount";
            inputCGSTAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            inputCGSTAmountDataGridViewTextBoxColumn.Name = "inputCGSTAmountDataGridViewTextBoxColumn";
            inputCGSTAmountDataGridViewTextBoxColumn.ReadOnly = true;
            inputCGSTAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPurchaseCostInclGSTDataGridViewTextBoxColumn
            // 
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.DataPropertyName = "TotalPurchaseCostInclGST";
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.HeaderText = "TotalPurchaseCostInclGST";
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.Name = "totalPurchaseCostInclGSTDataGridViewTextBoxColumn";
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.ReadOnly = true;
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.Width = 125;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // Purchase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1598, 786);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(PurchaseDataGridView);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Purchase";
            Text = "Purchase";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PurchaseDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)purchaseBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtQunatity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtSGstAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PurchaseDataGridView;
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
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGSTAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCGstAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBaseBuyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountOnBaseBuyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchaseDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGSTPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputSGSTAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputCGSTAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchaseCostInclGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}