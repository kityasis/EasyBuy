namespace EasyBuy.Forms.Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            groupBox4 = new System.Windows.Forms.GroupBox();
            label12 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtNoOfPrint = new System.Windows.Forms.TextBox();
            btnPrint = new System.Windows.Forms.Button();
            txtBarcode = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtCGstAmount = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            txtFinalPrice = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            txtSGstAmount = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtGST = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            txtDiscount = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            txtDiscountAmount = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtPriceAfterDiscount = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            cmbCategory = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtQunatity = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtPrice = new System.Windows.Forms.TextBox();
            btnClear = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ProductDataGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            discountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            priceAfterDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            gSTPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalPriceIncludingGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            productBindingSource = new System.Windows.Forms.BindingSource(components);
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(txtNoOfPrint);
            groupBox4.Controls.Add(btnPrint);
            groupBox4.Controls.Add(txtBarcode);
            groupBox4.Location = new System.Drawing.Point(1117, 67);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox4.Size = new System.Drawing.Size(176, 217);
            groupBox4.TabIndex = 65;
            groupBox4.TabStop = false;
            groupBox4.Text = "Barcode";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(23, 88);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(86, 20);
            label12.TabIndex = 18;
            label12.Text = "No. Of Print";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(23, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 20);
            label2.TabIndex = 17;
            label2.Text = "Barcode";
            // 
            // txtNoOfPrint
            // 
            txtNoOfPrint.Location = new System.Drawing.Point(23, 111);
            txtNoOfPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNoOfPrint.Name = "txtNoOfPrint";
            txtNoOfPrint.Size = new System.Drawing.Size(125, 27);
            txtNoOfPrint.TabIndex = 15;
            // 
            // btnPrint
            // 
            btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPrint.Location = new System.Drawing.Point(23, 157);
            btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(131, 41);
            btnPrint.TabIndex = 16;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new System.Drawing.Point(23, 57);
            txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.ReadOnly = true;
            txtBarcode.Size = new System.Drawing.Size(131, 27);
            txtBarcode.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCGstAmount);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtFinalPrice);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtSGstAmount);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtGST);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new System.Drawing.Point(758, 67);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox3.Size = new System.Drawing.Size(337, 217);
            groupBox3.TabIndex = 64;
            groupBox3.TabStop = false;
            groupBox3.Text = "GST Details";
            // 
            // txtCGstAmount
            // 
            txtCGstAmount.AcceptsReturn = true;
            txtCGstAmount.Location = new System.Drawing.Point(102, 125);
            txtCGstAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCGstAmount.Name = "txtCGstAmount";
            txtCGstAmount.ReadOnly = true;
            txtCGstAmount.Size = new System.Drawing.Size(189, 27);
            txtCGstAmount.TabIndex = 856;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(37, 129);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(59, 18);
            label14.TabIndex = 855;
            label14.Text = "C GST";
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new System.Drawing.Point(102, 171);
            txtFinalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.ReadOnly = true;
            txtFinalPrice.Size = new System.Drawing.Size(189, 27);
            txtFinalPrice.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(8, 180);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(88, 18);
            label13.TabIndex = 52;
            label13.Text = "Final Price";
            // 
            // txtSGstAmount
            // 
            txtSGstAmount.AcceptsReturn = true;
            txtSGstAmount.Location = new System.Drawing.Point(102, 76);
            txtSGstAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSGstAmount.Name = "txtSGstAmount";
            txtSGstAmount.ReadOnly = true;
            txtSGstAmount.Size = new System.Drawing.Size(189, 27);
            txtSGstAmount.TabIndex = 854;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(38, 85);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 18);
            label6.TabIndex = 33;
            label6.Text = "S GST";
            // 
            // txtGST
            // 
            txtGST.Location = new System.Drawing.Point(102, 20);
            txtGST.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtGST.Name = "txtGST";
            txtGST.Size = new System.Drawing.Size(185, 27);
            txtGST.TabIndex = 7;
            txtGST.TextChanged += txtGST_TextChanged_1;
            txtGST.KeyPress += txtGST_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(25, 25);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(56, 18);
            label8.TabIndex = 42;
            label8.Text = "GST%";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtDiscount);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDiscountAmount);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPriceAfterDiscount);
            groupBox2.Location = new System.Drawing.Point(367, 67);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(373, 217);
            groupBox2.TabIndex = 63;
            groupBox2.TabStop = false;
            groupBox2.Text = "Discount Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(59, 24);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(106, 18);
            label11.TabIndex = 48;
            label11.Text = "Discount (%)";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(171, 20);
            txtDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(176, 27);
            txtDiscount.TabIndex = 6;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(100, 80);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(65, 18);
            label10.TabIndex = 46;
            label10.Text = "Amount";
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new System.Drawing.Point(171, 76);
            txtDiscountAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new System.Drawing.Size(177, 27);
            txtDiscountAmount.TabIndex = 745;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(6, 129);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(159, 18);
            label9.TabIndex = 44;
            label9.Text = "Price After Discount";
            // 
            // txtPriceAfterDiscount
            // 
            txtPriceAfterDiscount.Location = new System.Drawing.Point(171, 129);
            txtPriceAfterDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPriceAfterDiscount.Name = "txtPriceAfterDiscount";
            txtPriceAfterDiscount.ReadOnly = true;
            txtPriceAfterDiscount.Size = new System.Drawing.Size(177, 27);
            txtPriceAfterDiscount.TabIndex = 54;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtQunatity);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Location = new System.Drawing.Point(12, 67);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(336, 217);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(11, 25);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 18);
            label5.TabIndex = 34;
            label5.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(97, 20);
            cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(201, 28);
            cmbCategory.TabIndex = 2;
            cmbCategory.Text = "---Select---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(35, 76);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 18);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(97, 76);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(201, 27);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(17, 180);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 18);
            label7.TabIndex = 37;
            label7.Text = "Quantity";
            // 
            // txtQunatity
            // 
            txtQunatity.Location = new System.Drawing.Point(97, 176);
            txtQunatity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtQunatity.Name = "txtQunatity";
            txtQunatity.Size = new System.Drawing.Size(201, 27);
            txtQunatity.TabIndex = 5;            
            txtQunatity.KeyPress += txtQunatity_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(40, 129);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 18);
            label4.TabIndex = 40;
            label4.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(97, 129);
            txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(201, 27);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(1299, 236);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(96, 41);
            btnClear.TabIndex = 60;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Location = new System.Drawing.Point(1299, 178);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(96, 41);
            btnAdd.TabIndex = 59;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1437, 44);
            panel1.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(11, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.AutoGenerateColumns = false;
            ProductDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, catagoryDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, discountAmountDataGridViewTextBoxColumn, priceAfterDiscountDataGridViewTextBoxColumn, gSTPercentageDataGridViewTextBoxColumn, sGSTDataGridViewTextBoxColumn, cGSTDataGridViewTextBoxColumn, totalPriceIncludingGSTDataGridViewTextBoxColumn, Edit, Delete });
            ProductDataGridView.DataSource = productBindingSource;
            ProductDataGridView.Location = new System.Drawing.Point(11, 292);
            ProductDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.RowTemplate.Height = 24;
            ProductDataGridView.Size = new System.Drawing.Size(1384, 477);
            ProductDataGridView.TabIndex = 66;
            ProductDataGridView.CellContentClick += ProductDataGridView_CellContentClick;
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
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ReadOnly = true;
            codeDataGridViewTextBoxColumn.Visible = false;
            codeDataGridViewTextBoxColumn.Width = 125;
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
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
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
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountAmountDataGridViewTextBoxColumn
            // 
            discountAmountDataGridViewTextBoxColumn.DataPropertyName = "DiscountAmount";
            discountAmountDataGridViewTextBoxColumn.HeaderText = "DiscountAmount";
            discountAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountAmountDataGridViewTextBoxColumn.Name = "discountAmountDataGridViewTextBoxColumn";
            discountAmountDataGridViewTextBoxColumn.ReadOnly = true;
            discountAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceAfterDiscountDataGridViewTextBoxColumn
            // 
            priceAfterDiscountDataGridViewTextBoxColumn.DataPropertyName = "PriceAfterDiscount";
            priceAfterDiscountDataGridViewTextBoxColumn.HeaderText = "PriceAfterDiscount";
            priceAfterDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceAfterDiscountDataGridViewTextBoxColumn.Name = "priceAfterDiscountDataGridViewTextBoxColumn";
            priceAfterDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            priceAfterDiscountDataGridViewTextBoxColumn.Width = 125;
            // 
            // gSTPercentageDataGridViewTextBoxColumn
            // 
            gSTPercentageDataGridViewTextBoxColumn.DataPropertyName = "GSTPercentage";
            gSTPercentageDataGridViewTextBoxColumn.HeaderText = "GSTPercentage";
            gSTPercentageDataGridViewTextBoxColumn.MinimumWidth = 6;
            gSTPercentageDataGridViewTextBoxColumn.Name = "gSTPercentageDataGridViewTextBoxColumn";
            gSTPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            gSTPercentageDataGridViewTextBoxColumn.Width = 125;
            // 
            // sGSTDataGridViewTextBoxColumn
            // 
            sGSTDataGridViewTextBoxColumn.DataPropertyName = "SGST";
            sGSTDataGridViewTextBoxColumn.HeaderText = "SGST";
            sGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            sGSTDataGridViewTextBoxColumn.Name = "sGSTDataGridViewTextBoxColumn";
            sGSTDataGridViewTextBoxColumn.ReadOnly = true;
            sGSTDataGridViewTextBoxColumn.Width = 125;
            // 
            // cGSTDataGridViewTextBoxColumn
            // 
            cGSTDataGridViewTextBoxColumn.DataPropertyName = "CGST";
            cGSTDataGridViewTextBoxColumn.HeaderText = "CGST";
            cGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            cGSTDataGridViewTextBoxColumn.Name = "cGSTDataGridViewTextBoxColumn";
            cGSTDataGridViewTextBoxColumn.ReadOnly = true;
            cGSTDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceIncludingGSTDataGridViewTextBoxColumn
            // 
            totalPriceIncludingGSTDataGridViewTextBoxColumn.DataPropertyName = "TotalPriceIncludingGST";
            totalPriceIncludingGSTDataGridViewTextBoxColumn.HeaderText = "TotalPriceIncludingGST";
            totalPriceIncludingGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceIncludingGSTDataGridViewTextBoxColumn.Name = "totalPriceIncludingGSTDataGridViewTextBoxColumn";
            totalPriceIncludingGSTDataGridViewTextBoxColumn.ReadOnly = true;
            totalPriceIncludingGSTDataGridViewTextBoxColumn.Width = 125;
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
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Product
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1437, 782);
            Controls.Add(ProductDataGridView);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Product";
            Text = "Product";
            Load += Product_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNoOfPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCGstAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSGstAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPriceAfterDiscount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQunatity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBaseBuyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountOnBaseBuyPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchaseDiscountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBaseBuyPriceAfterDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGSTPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputGSTAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPurchaseCostInclGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceAfterDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceIncludingGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}