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
            components = new System.ComponentModel.Container();
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
            ProductDataGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            inputGSTAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            btnPrint = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            cmbSupplier = new System.Windows.Forms.ComboBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            textNoOfPrint = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // txtQunatity
            // 
            txtQunatity.Location = new System.Drawing.Point(86, 85);
            txtQunatity.Name = "txtQunatity";
            txtQunatity.Size = new System.Drawing.Size(176, 23);
            txtQunatity.TabIndex = 5;
            txtQunatity.TextChanged += txtQunatity_TextChanged;
            txtQunatity.KeyPress += txtQunatity_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(19, 90);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(59, 15);
            label7.TabIndex = 37;
            label7.Text = "Quantity";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(362, 21);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(176, 23);
            cmbCategory.TabIndex = 2;
            cmbCategory.Text = "---Select---";
            // 
            // txtGstAmount
            // 
            txtGstAmount.AcceptsReturn = true;
            txtGstAmount.Location = new System.Drawing.Point(89, 50);
            txtGstAmount.Name = "txtGstAmount";
            txtGstAmount.ReadOnly = true;
            txtGstAmount.Size = new System.Drawing.Size(110, 23);
            txtGstAmount.TabIndex = 854;
            txtGstAmount.KeyPress += txtGstAmount_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(288, 26);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 15);
            label5.TabIndex = 34;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(25, 53);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 15);
            label6.TabIndex = 33;
            label6.Text = "Amount";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(715, 201);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(84, 31);
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
            btnAdd.Location = new System.Drawing.Point(612, 201);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(84, 31);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btn_add_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(86, 46);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(176, 23);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtBarcode
            // 
            txtBarcode.Enabled = false;
            txtBarcode.Location = new System.Drawing.Point(12, 26);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new System.Drawing.Size(110, 23);
            txtBarcode.TabIndex = 14;
            txtBarcode.Text = "Barcode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(34, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(163, 203, 56);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1206, 33);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 17);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.AutoGenerateColumns = false;
            ProductDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn, catagoryDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, basePriceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, totalBaseBuyPriceDataGridViewTextBoxColumn, discountOnBaseBuyPriceDataGridViewTextBoxColumn, totalPurchaseDiscountAmountDataGridViewTextBoxColumn, totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn, inputGSTPercentageDataGridViewTextBoxColumn, inputGSTAmountDataGridViewTextBoxColumn, totalPurchaseCostInclGSTDataGridViewTextBoxColumn, Edit, Delete });
            ProductDataGridView.DataSource = productBindingSource;
            ProductDataGridView.Location = new System.Drawing.Point(24, 250);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.RowTemplate.Height = 24;
            ProductDataGridView.Size = new System.Drawing.Size(1155, 442);
            ProductDataGridView.TabIndex = 39;
            ProductDataGridView.CellContentClick += ProductDataGridView_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ReadOnly = true;
            codeDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            supplierDataGridViewTextBoxColumn.ReadOnly = true;
            supplierDataGridViewTextBoxColumn.Visible = false;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            catagoryDataGridViewTextBoxColumn.ReadOnly = true;
            catagoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            basePriceDataGridViewTextBoxColumn.HeaderText = "Price";
            basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            basePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Qty";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalBaseBuyPriceDataGridViewTextBoxColumn
            // 
            totalBaseBuyPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalBaseBuyPrice";
            totalBaseBuyPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            totalBaseBuyPriceDataGridViewTextBoxColumn.Name = "totalBaseBuyPriceDataGridViewTextBoxColumn";
            totalBaseBuyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountOnBaseBuyPriceDataGridViewTextBoxColumn
            // 
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.DataPropertyName = "DiscountOnBaseBuyPrice";
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.HeaderText = "Discount(%)";
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.Name = "discountOnBaseBuyPriceDataGridViewTextBoxColumn";
            discountOnBaseBuyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPurchaseDiscountAmountDataGridViewTextBoxColumn
            // 
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalPurchaseDiscountAmount";
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.HeaderText = "Discount Amount";
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.Name = "totalPurchaseDiscountAmountDataGridViewTextBoxColumn";
            totalPurchaseDiscountAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn
            // 
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.DataPropertyName = "TotalBaseBuyPriceAfterDiscount";
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.HeaderText = "Total Price After Discount";
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.Name = "totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn";
            totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inputGSTPercentageDataGridViewTextBoxColumn
            // 
            inputGSTPercentageDataGridViewTextBoxColumn.DataPropertyName = "InputGSTPercentage";
            inputGSTPercentageDataGridViewTextBoxColumn.HeaderText = "GST(%)";
            inputGSTPercentageDataGridViewTextBoxColumn.Name = "inputGSTPercentageDataGridViewTextBoxColumn";
            inputGSTPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inputGSTAmountDataGridViewTextBoxColumn
            // 
            inputGSTAmountDataGridViewTextBoxColumn.DataPropertyName = "InputGSTAmount";
            inputGSTAmountDataGridViewTextBoxColumn.HeaderText = "GST Amount";
            inputGSTAmountDataGridViewTextBoxColumn.Name = "inputGSTAmountDataGridViewTextBoxColumn";
            inputGSTAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPurchaseCostInclGSTDataGridViewTextBoxColumn
            // 
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.DataPropertyName = "TotalPurchaseCostInclGST";
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.HeaderText = "Final Price";
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.Name = "totalPurchaseCostInclGSTDataGridViewTextBoxColumn";
            totalPurchaseCostInclGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(362, 51);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(176, 23);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(313, 60);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 40;
            label4.Text = "Price";
            // 
            // txtGST
            // 
            txtGST.Location = new System.Drawing.Point(89, 19);
            txtGST.Name = "txtGST";
            txtGST.Size = new System.Drawing.Size(110, 23);
            txtGST.TabIndex = 7;
            txtGST.TextChanged += txtGST_TextChanged;
            txtGST.KeyPress += txtGST_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(33, 25);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(46, 15);
            label8.TabIndex = 42;
            label8.Text = "GST%";
            // 
            // txtTotalPriceAfterDiscount
            // 
            txtTotalPriceAfterDiscount.Location = new System.Drawing.Point(186, 82);
            txtTotalPriceAfterDiscount.Name = "txtTotalPriceAfterDiscount";
            txtTotalPriceAfterDiscount.ReadOnly = true;
            txtTotalPriceAfterDiscount.Size = new System.Drawing.Size(110, 23);
            txtTotalPriceAfterDiscount.TabIndex = 54;
            txtTotalPriceAfterDiscount.KeyPress += txtTotalPriceAfterDiscount_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(6, 88);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(173, 15);
            label9.TabIndex = 44;
            label9.Text = "Total  Price After Discount";
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new System.Drawing.Point(186, 46);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new System.Drawing.Size(110, 23);
            txtDiscountAmount.TabIndex = 745;
            txtDiscountAmount.KeyPress += txtDiscountAmount_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(61, 51);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(115, 15);
            label10.TabIndex = 46;
            label10.Text = "Discount Amount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(99, 22);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(79, 15);
            label11.TabIndex = 48;
            label11.Text = "Discount %";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(278, 92);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(76, 15);
            label12.TabIndex = 50;
            label12.Text = "Total Price";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new System.Drawing.Point(362, 88);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new System.Drawing.Size(176, 23);
            txtTotalPrice.TabIndex = 88;
            txtTotalPrice.KeyPress += texPrice_KeyPress;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(186, 19);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(110, 23);
            txtDiscount.TabIndex = 6;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new System.Drawing.Point(89, 78);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.ReadOnly = true;
            txtFinalPrice.Size = new System.Drawing.Size(110, 23);
            txtFinalPrice.TabIndex = 54;
            txtFinalPrice.KeyPress += txtFinalPrice_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(5, 85);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(76, 15);
            label13.TabIndex = 52;
            label13.Text = "Final Price";
            // 
            // btnPrint
            // 
            btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPrint.Location = new System.Drawing.Point(311, 16);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(110, 31);
            btnPrint.TabIndex = 16;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new System.Drawing.Point(24, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(559, 122);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(20, 21);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 15);
            label2.TabIndex = 52;
            label2.Text = "Supplier";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new System.Drawing.Point(86, 18);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new System.Drawing.Size(176, 23);
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
            groupBox2.Location = new System.Drawing.Point(612, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(323, 122);
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
            groupBox3.Location = new System.Drawing.Point(955, 39);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(224, 122);
            groupBox3.TabIndex = 57;
            groupBox3.TabStop = false;
            groupBox3.Text = "GST Details";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textNoOfPrint);
            groupBox4.Controls.Add(btnPrint);
            groupBox4.Controls.Add(txtBarcode);
            groupBox4.Location = new System.Drawing.Point(24, 178);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(559, 58);
            groupBox4.TabIndex = 58;
            groupBox4.TabStop = false;
            groupBox4.Text = "Barcode";
            // 
            // textNoOfPrint
            // 
            textNoOfPrint.Location = new System.Drawing.Point(151, 26);
            textNoOfPrint.Name = "textNoOfPrint";
            textNoOfPrint.Size = new System.Drawing.Size(110, 23);
            textNoOfPrint.TabIndex = 15;
            textNoOfPrint.Text = "No. of Print";
            // 
            // Product
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1206, 727);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ProductDataGridView);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Product";
            Text = "Products";
            Load += Product_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
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
        private System.Windows.Forms.DataGridView ProductDataGridView;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textNoOfPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGSTAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchaseCostInclGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}