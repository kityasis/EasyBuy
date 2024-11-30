namespace EasyBuy.Forms
{
    partial class Dashboard
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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btnShow = new System.Windows.Forms.Button();
            cmbCategory = new System.Windows.Forms.ComboBox();
            cmbSupplier = new System.Windows.Forms.ComboBox();
            cmbProduct = new System.Windows.Forms.ComboBox();
            dtpTo = new System.Windows.Forms.DateTimePicker();
            dtpFrom = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cmbCustomer = new System.Windows.Forms.ComboBox();
            rbtnPurchase = new System.Windows.Forms.RadioButton();
            rbtnGst = new System.Windows.Forms.RadioButton();
            rbtnStock = new System.Windows.Forms.RadioButton();
            rbtnSale = new System.Windows.Forms.RadioButton();
            dgvPurchage = new System.Windows.Forms.DataGridView();
            dgvSale = new System.Windows.Forms.DataGridView();
            dgvStock = new System.Windows.Forms.DataGridView();
            dgvGST = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGST).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(11, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnShow
            // 
            btnShow.Location = new System.Drawing.Point(394, 69);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(78, 47);
            btnShow.TabIndex = 7;
            btnShow.Text = "show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(641, 119);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(250, 28);
            cmbCategory.TabIndex = 6;
            cmbCategory.Text = "---Select Category---";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new System.Drawing.Point(1162, 119);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new System.Drawing.Size(250, 28);
            cmbSupplier.TabIndex = 5;
            cmbSupplier.Text = "---Select Supplier--";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new System.Drawing.Point(900, 119);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new System.Drawing.Size(250, 28);
            cmbProduct.TabIndex = 4;
            cmbProduct.Text = "---Select Product---";
            // 
            // dtpTo
            // 
            dtpTo.Location = new System.Drawing.Point(382, 120);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(250, 27);
            dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new System.Drawing.Point(95, 122);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(250, 27);
            dtpFrom.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(348, 127);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 20);
            label3.TabIndex = 1;
            label3.Text = "To :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 127);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "From :";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new System.Drawing.Point(1162, 119);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new System.Drawing.Size(250, 28);
            cmbCustomer.TabIndex = 29;
            cmbCustomer.Text = "---Select Customer--";
            // 
            // rbtnPurchase
            // 
            rbtnPurchase.AutoSize = true;
            rbtnPurchase.Location = new System.Drawing.Point(40, 77);
            rbtnPurchase.Name = "rbtnPurchase";
            rbtnPurchase.Size = new System.Drawing.Size(88, 24);
            rbtnPurchase.TabIndex = 30;
            rbtnPurchase.TabStop = true;
            rbtnPurchase.Text = "Purchase";
            rbtnPurchase.UseVisualStyleBackColor = true;
            rbtnPurchase.CheckedChanged += rbtnPurchase_CheckedChanged;
            // 
            // rbtnGst
            // 
            rbtnGst.AutoSize = true;
            rbtnGst.Location = new System.Drawing.Point(306, 80);
            rbtnGst.Name = "rbtnGst";
            rbtnGst.Size = new System.Drawing.Size(56, 24);
            rbtnGst.TabIndex = 31;
            rbtnGst.TabStop = true;
            rbtnGst.Text = "GST";
            rbtnGst.UseVisualStyleBackColor = true;
            rbtnGst.CheckedChanged += rbtnGst_CheckedChanged;
            // 
            // rbtnStock
            // 
            rbtnStock.AutoSize = true;
            rbtnStock.Location = new System.Drawing.Point(222, 80);
            rbtnStock.Name = "rbtnStock";
            rbtnStock.Size = new System.Drawing.Size(66, 24);
            rbtnStock.TabIndex = 32;
            rbtnStock.TabStop = true;
            rbtnStock.Text = "Stock";
            rbtnStock.UseVisualStyleBackColor = true;
            rbtnStock.CheckedChanged += rbtnStock_CheckedChanged;
            // 
            // rbtnSale
            // 
            rbtnSale.AutoSize = true;
            rbtnSale.Location = new System.Drawing.Point(134, 80);
            rbtnSale.Name = "rbtnSale";
            rbtnSale.Size = new System.Drawing.Size(58, 24);
            rbtnSale.TabIndex = 33;
            rbtnSale.TabStop = true;
            rbtnSale.Text = "Sale";
            rbtnSale.UseVisualStyleBackColor = true;
            rbtnSale.CheckedChanged += rbtnSale_CheckedChanged;
            // 
            // dgvPurchage
            // 
            dgvPurchage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchage.Location = new System.Drawing.Point(40, 165);
            dgvPurchage.Name = "dgvPurchage";
            dgvPurchage.RowHeadersWidth = 51;
            dgvPurchage.Size = new System.Drawing.Size(1372, 188);
            dgvPurchage.TabIndex = 34;
            // 
            // dgvSale
            // 
            dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Location = new System.Drawing.Point(40, 186);
            dgvSale.Name = "dgvSale";
            dgvSale.RowHeadersWidth = 51;
            dgvSale.Size = new System.Drawing.Size(1372, 188);
            dgvSale.TabIndex = 35;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new System.Drawing.Point(40, 203);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new System.Drawing.Size(1372, 188);
            dgvStock.TabIndex = 36;
            // 
            // dgvGST
            // 
            dgvGST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGST.Location = new System.Drawing.Point(40, 224);
            dgvGST.Name = "dgvGST";
            dgvGST.RowHeadersWidth = 51;
            dgvGST.Size = new System.Drawing.Size(1372, 188);
            dgvGST.TabIndex = 37;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1437, 782);
            Controls.Add(dgvGST);
            Controls.Add(dgvStock);
            Controls.Add(dgvSale);
            Controls.Add(dgvPurchage);
            Controls.Add(rbtnSale);
            Controls.Add(rbtnStock);
            Controls.Add(rbtnGst);
            Controls.Add(rbtnPurchase);
            Controls.Add(cmbCustomer);
            Controls.Add(btnShow);
            Controls.Add(cmbCategory);
            Controls.Add(panel1);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbProduct);
            Controls.Add(label2);
            Controls.Add(dtpTo);
            Controls.Add(label3);
            Controls.Add(dtpFrom);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGST).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.RadioButton rbtnPurchase;
        private System.Windows.Forms.RadioButton rbtnGst;
        private System.Windows.Forms.RadioButton rbtnStock;
        private System.Windows.Forms.RadioButton rbtnSale;
        private System.Windows.Forms.DataGridView dgvPurchage;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridView dgvGST;
    }
}