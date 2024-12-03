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
            txtNoOfPrint = new System.Windows.Forms.TextBox();
            btnPrint = new System.Windows.Forms.Button();
            txtBarcode = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtCGstAmount = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            txtSGstAmount = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtGST = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtFinalPrice = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
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
            productBindingSource = new System.Windows.Forms.BindingSource(components);
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnSearch = new System.Windows.Forms.Button();
            txtSearchName = new System.Windows.Forms.TextBox();
            groupBox5 = new System.Windows.Forms.GroupBox();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            cmbSearchCategory = new System.Windows.Forms.ComboBox();
            btnRefresh = new System.Windows.Forms.Button();
            btnFirst = new System.Windows.Forms.Button();
            btnLast = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            btnPrevious = new System.Windows.Forms.Button();
            txtRecordNumber = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            groupBox6 = new System.Windows.Forms.GroupBox();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtNoOfPrint);
            groupBox4.Controls.Add(btnPrint);
            groupBox4.Controls.Add(txtBarcode);
            groupBox4.Location = new System.Drawing.Point(902, 50);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(321, 53);
            groupBox4.TabIndex = 65;
            groupBox4.TabStop = false;
            groupBox4.Text = "Barcode";
            // 
            // txtNoOfPrint
            // 
            txtNoOfPrint.Location = new System.Drawing.Point(153, 16);
            txtNoOfPrint.Name = "txtNoOfPrint";
            txtNoOfPrint.Size = new System.Drawing.Size(71, 23);
            txtNoOfPrint.TabIndex = 15;
            // 
            // btnPrint
            // 
            btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPrint.Location = new System.Drawing.Point(236, 16);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(66, 26);
            btnPrint.TabIndex = 16;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new System.Drawing.Point(13, 16);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.ReadOnly = true;
            txtBarcode.Size = new System.Drawing.Size(122, 23);
            txtBarcode.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCGstAmount);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txtSGstAmount);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtGST);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new System.Drawing.Point(805, 109);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(418, 53);
            groupBox3.TabIndex = 64;
            groupBox3.TabStop = false;
            groupBox3.Text = "GST Details";
            // 
            // txtCGstAmount
            // 
            txtCGstAmount.AcceptsReturn = true;
            txtCGstAmount.Location = new System.Drawing.Point(327, 21);
            txtCGstAmount.Name = "txtCGstAmount";
            txtCGstAmount.ReadOnly = true;
            txtCGstAmount.Size = new System.Drawing.Size(72, 23);
            txtCGstAmount.TabIndex = 856;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.Location = new System.Drawing.Point(274, 25);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(47, 15);
            label14.TabIndex = 855;
            label14.Text = "C GST";
            // 
            // txtSGstAmount
            // 
            txtSGstAmount.AcceptsReturn = true;
            txtSGstAmount.Location = new System.Drawing.Point(192, 23);
            txtSGstAmount.Name = "txtSGstAmount";
            txtSGstAmount.ReadOnly = true;
            txtSGstAmount.Size = new System.Drawing.Size(67, 23);
            txtSGstAmount.TabIndex = 854;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(139, 25);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 15);
            label6.TabIndex = 33;
            label6.Text = "S GST";
            // 
            // txtGST
            // 
            txtGST.Location = new System.Drawing.Point(62, 23);
            txtGST.Name = "txtGST";
            txtGST.Size = new System.Drawing.Size(66, 23);
            txtGST.TabIndex = 7;
            txtGST.TextChanged += txtGST_TextChanged_1;
            txtGST.KeyPress += txtGST_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(11, 25);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(46, 15);
            label8.TabIndex = 42;
            label8.Text = "GST%";
            // 
            // txtFinalPrice
            // 
            txtFinalPrice.Location = new System.Drawing.Point(92, 22);
            txtFinalPrice.Name = "txtFinalPrice";
            txtFinalPrice.ReadOnly = true;
            txtFinalPrice.Size = new System.Drawing.Size(166, 23);
            txtFinalPrice.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(10, 24);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(76, 15);
            label13.TabIndex = 52;
            label13.Text = "Final Price";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtDiscount);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDiscountAmount);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtPriceAfterDiscount);
            groupBox2.Location = new System.Drawing.Point(10, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(789, 53);
            groupBox2.TabIndex = 63;
            groupBox2.TabStop = false;
            groupBox2.Text = "Discount Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(10, 19);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(89, 15);
            label11.TabIndex = 48;
            label11.Text = "Discount (%)";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new System.Drawing.Point(104, 16);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new System.Drawing.Size(65, 23);
            txtDiscount.TabIndex = 6;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            txtDiscount.KeyPress += txtDiscount_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(182, 23);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(55, 15);
            label10.TabIndex = 46;
            label10.Text = "Amount";
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new System.Drawing.Point(261, 17);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.ReadOnly = true;
            txtDiscountAmount.Size = new System.Drawing.Size(134, 23);
            txtDiscountAmount.TabIndex = 745;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(415, 23);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(133, 15);
            label9.TabIndex = 44;
            label9.Text = "Price After Discount";
            // 
            // txtPriceAfterDiscount
            // 
            txtPriceAfterDiscount.Location = new System.Drawing.Point(557, 17);
            txtPriceAfterDiscount.Name = "txtPriceAfterDiscount";
            txtPriceAfterDiscount.ReadOnly = true;
            txtPriceAfterDiscount.Size = new System.Drawing.Size(134, 23);
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
            groupBox1.Location = new System.Drawing.Point(10, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(875, 53);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(10, 19);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 15);
            label5.TabIndex = 34;
            label5.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(85, 15);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(176, 23);
            cmbCategory.TabIndex = 2;
            cmbCategory.Text = "---Select---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(273, 19);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 28;
            label3.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(324, 17);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(212, 23);
            txtName.TabIndex = 3;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(704, 19);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(59, 15);
            label7.TabIndex = 37;
            label7.Text = "Quantity";
            // 
            // txtQunatity
            // 
            txtQunatity.Location = new System.Drawing.Point(772, 16);
            txtQunatity.Name = "txtQunatity";
            txtQunatity.Size = new System.Drawing.Size(78, 23);
            txtQunatity.TabIndex = 5;
            txtQunatity.KeyPress += txtQunatity_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(536, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 40;
            label4.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(584, 17);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(115, 23);
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
            btnClear.Location = new System.Drawing.Point(466, 15);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(85, 28);
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
            btnAdd.Location = new System.Drawing.Point(290, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(82, 28);
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
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1262, 33);
            panel1.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 17);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.AutoGenerateColumns = false;
            ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            ProductDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            ProductDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, catagoryDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, discountAmountDataGridViewTextBoxColumn, priceAfterDiscountDataGridViewTextBoxColumn, gSTPercentageDataGridViewTextBoxColumn, sGSTDataGridViewTextBoxColumn, cGSTDataGridViewTextBoxColumn, totalPriceIncludingGSTDataGridViewTextBoxColumn, Edit, Delete });
            ProductDataGridView.DataSource = productBindingSource;
            ProductDataGridView.Location = new System.Drawing.Point(10, 242);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 51;
            ProductDataGridView.RowTemplate.Height = 24;
            ProductDataGridView.Size = new System.Drawing.Size(1213, 338);
            ProductDataGridView.TabIndex = 66;
            ProductDataGridView.CellContentClick += ProductDataGridView_CellContentClick;
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
            // btnSearch
            // 
            btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSearch.Location = new System.Drawing.Point(470, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(66, 26);
            btnSearch.TabIndex = 67;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new System.Drawing.Point(327, 18);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new System.Drawing.Size(137, 23);
            txtSearchName.TabIndex = 68;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(cmbSearchCategory);
            groupBox5.Controls.Add(txtSearchName);
            groupBox5.Controls.Add(btnSearch);
            groupBox5.Location = new System.Drawing.Point(668, 171);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(555, 53);
            groupBox5.TabIndex = 66;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search....";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label15.Location = new System.Drawing.Point(276, 21);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(45, 15);
            label15.TabIndex = 72;
            label15.Text = "Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label16.Location = new System.Drawing.Point(8, 20);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(63, 15);
            label16.TabIndex = 71;
            label16.Text = "Category";
            // 
            // cmbSearchCategory
            // 
            cmbSearchCategory.FormattingEnabled = true;
            cmbSearchCategory.Location = new System.Drawing.Point(83, 16);
            cmbSearchCategory.Name = "cmbSearchCategory";
            cmbSearchCategory.Size = new System.Drawing.Size(176, 23);
            cmbSearchCategory.TabIndex = 70;
            cmbSearchCategory.Text = "---Select---";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnRefresh.Location = new System.Drawing.Point(378, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(82, 28);
            btnRefresh.TabIndex = 67;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFirst
            // 
            btnFirst.CausesValidation = false;
            btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnFirst.Location = new System.Drawing.Point(895, 592);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new System.Drawing.Size(28, 28);
            btnFirst.TabIndex = 68;
            btnFirst.Text = "|<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnLast
            // 
            btnLast.CausesValidation = false;
            btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnLast.Location = new System.Drawing.Point(1195, 592);
            btnLast.Name = "btnLast";
            btnLast.Size = new System.Drawing.Size(28, 28);
            btnLast.TabIndex = 69;
            btnLast.Text = ">|";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.CausesValidation = false;
            btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnNext.Location = new System.Drawing.Point(1161, 592);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(28, 28);
            btnNext.TabIndex = 70;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.CausesValidation = false;
            btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnPrevious.Location = new System.Drawing.Point(929, 592);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(28, 28);
            btnPrevious.TabIndex = 71;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // txtRecordNumber
            // 
            txtRecordNumber.Location = new System.Drawing.Point(1033, 597);
            txtRecordNumber.Name = "txtRecordNumber";
            txtRecordNumber.ReadOnly = true;
            txtRecordNumber.Size = new System.Drawing.Size(115, 23);
            txtRecordNumber.TabIndex = 72;
            txtRecordNumber.Text = "0/0";
            txtRecordNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(963, 599);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 15);
            label2.TabIndex = 73;
            label2.Text = "Showing";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtFinalPrice);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(btnAdd);
            groupBox6.Controls.Add(btnClear);
            groupBox6.Controls.Add(btnRefresh);
            groupBox6.Location = new System.Drawing.Point(10, 171);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new System.Drawing.Size(576, 53);
            groupBox6.TabIndex = 74;
            groupBox6.TabStop = false;
            groupBox6.Text = "Final";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            catagoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            catagoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountAmountDataGridViewTextBoxColumn
            // 
            discountAmountDataGridViewTextBoxColumn.DataPropertyName = "DiscountAmount";
            discountAmountDataGridViewTextBoxColumn.HeaderText = "DiscountAmount";
            discountAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountAmountDataGridViewTextBoxColumn.Name = "discountAmountDataGridViewTextBoxColumn";
            discountAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceAfterDiscountDataGridViewTextBoxColumn
            // 
            priceAfterDiscountDataGridViewTextBoxColumn.DataPropertyName = "PriceAfterDiscount";
            priceAfterDiscountDataGridViewTextBoxColumn.HeaderText = "PriceAfterDiscount";
            priceAfterDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceAfterDiscountDataGridViewTextBoxColumn.Name = "priceAfterDiscountDataGridViewTextBoxColumn";
            priceAfterDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gSTPercentageDataGridViewTextBoxColumn
            // 
            gSTPercentageDataGridViewTextBoxColumn.DataPropertyName = "GSTPercentage";
            gSTPercentageDataGridViewTextBoxColumn.HeaderText = "GSTPercentage";
            gSTPercentageDataGridViewTextBoxColumn.MinimumWidth = 6;
            gSTPercentageDataGridViewTextBoxColumn.Name = "gSTPercentageDataGridViewTextBoxColumn";
            gSTPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGSTDataGridViewTextBoxColumn
            // 
            sGSTDataGridViewTextBoxColumn.DataPropertyName = "SGST";
            sGSTDataGridViewTextBoxColumn.HeaderText = "SGST";
            sGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            sGSTDataGridViewTextBoxColumn.Name = "sGSTDataGridViewTextBoxColumn";
            sGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cGSTDataGridViewTextBoxColumn
            // 
            cGSTDataGridViewTextBoxColumn.DataPropertyName = "CGST";
            cGSTDataGridViewTextBoxColumn.HeaderText = "CGST";
            cGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            cGSTDataGridViewTextBoxColumn.Name = "cGSTDataGridViewTextBoxColumn";
            cGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceIncludingGSTDataGridViewTextBoxColumn
            // 
            totalPriceIncludingGSTDataGridViewTextBoxColumn.DataPropertyName = "TotalPriceIncludingGST";
            totalPriceIncludingGSTDataGridViewTextBoxColumn.HeaderText = "TotalPriceIncludingGST";
            totalPriceIncludingGSTDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalPriceIncludingGSTDataGridViewTextBoxColumn.Name = "totalPriceIncludingGSTDataGridViewTextBoxColumn";
            totalPriceIncludingGSTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // Product
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1262, 628);
            Controls.Add(groupBox6);
            Controls.Add(label2);
            Controls.Add(txtRecordNumber);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnLast);
            Controls.Add(btnFirst);
            Controls.Add(groupBox5);
            Controls.Add(ProductDataGridView);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtRecordNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
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
    }
}