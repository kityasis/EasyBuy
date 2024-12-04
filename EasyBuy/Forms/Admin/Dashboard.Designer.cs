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
            btnExportToExcel = new System.Windows.Forms.Button();
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
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1265, 33);
            panel1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 17);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // btnShow
            // 
            btnShow.Location = new System.Drawing.Point(788, 68);
            btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(68, 29);
            btnShow.TabIndex = 7;
            btnShow.Text = "show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(563, 70);
            cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(219, 23);
            cmbCategory.TabIndex = 6;
            cmbCategory.Text = "---Select Category---";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new System.Drawing.Point(563, 70);
            cmbSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new System.Drawing.Size(219, 23);
            cmbSupplier.TabIndex = 5;
            cmbSupplier.Text = "---Select Supplier--";
            // 
            // dtpTo
            // 
            dtpTo.Location = new System.Drawing.Point(338, 70);
            dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(219, 23);
            dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new System.Drawing.Point(87, 72);
            dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(219, 23);
            dtpFrom.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(308, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 15);
            label3.TabIndex = 1;
            label3.Text = "To :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 0;
            label2.Text = "From :";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new System.Drawing.Point(563, 70);
            cmbCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new System.Drawing.Size(219, 23);
            cmbCustomer.TabIndex = 29;
            cmbCustomer.Text = "---Select Customer--";
            // 
            // rbtnPurchase
            // 
            rbtnPurchase.AutoSize = true;
            rbtnPurchase.Location = new System.Drawing.Point(39, 38);
            rbtnPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtnPurchase.Name = "rbtnPurchase";
            rbtnPurchase.Size = new System.Drawing.Size(73, 19);
            rbtnPurchase.TabIndex = 30;
            rbtnPurchase.TabStop = true;
            rbtnPurchase.Text = "Purchase";
            rbtnPurchase.UseVisualStyleBackColor = true;
            rbtnPurchase.CheckedChanged += rbtnPurchase_CheckedChanged;
            // 
            // rbtnGst
            // 
            rbtnGst.AutoSize = true;
            rbtnGst.Location = new System.Drawing.Point(233, 38);
            rbtnGst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtnGst.Name = "rbtnGst";
            rbtnGst.Size = new System.Drawing.Size(45, 19);
            rbtnGst.TabIndex = 31;
            rbtnGst.TabStop = true;
            rbtnGst.Text = "GST";
            rbtnGst.UseVisualStyleBackColor = true;
            rbtnGst.CheckedChanged += rbtnGst_CheckedChanged;
            // 
            // rbtnStock
            // 
            rbtnStock.AutoSize = true;
            rbtnStock.Location = new System.Drawing.Point(173, 38);
            rbtnStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtnStock.Name = "rbtnStock";
            rbtnStock.Size = new System.Drawing.Size(54, 19);
            rbtnStock.TabIndex = 32;
            rbtnStock.TabStop = true;
            rbtnStock.Text = "Stock";
            rbtnStock.UseVisualStyleBackColor = true;
            rbtnStock.CheckedChanged += rbtnStock_CheckedChanged;
            // 
            // rbtnSale
            // 
            rbtnSale.AutoSize = true;
            rbtnSale.Location = new System.Drawing.Point(121, 38);
            rbtnSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            rbtnSale.Name = "rbtnSale";
            rbtnSale.Size = new System.Drawing.Size(46, 19);
            rbtnSale.TabIndex = 33;
            rbtnSale.TabStop = true;
            rbtnSale.Text = "Sale";
            rbtnSale.UseVisualStyleBackColor = true;
            rbtnSale.CheckedChanged += rbtnSale_CheckedChanged;
            // 
            // dgvPurchage
            // 
            dgvPurchage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchage.Location = new System.Drawing.Point(39, 108);
            dgvPurchage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvPurchage.Name = "dgvPurchage";
            dgvPurchage.RowHeadersWidth = 51;
            dgvPurchage.Size = new System.Drawing.Size(1200, 451);
            dgvPurchage.TabIndex = 34;
            // 
            // dgvSale
            // 
            dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSale.Location = new System.Drawing.Point(39, 124);
            dgvSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvSale.Name = "dgvSale";
            dgvSale.RowHeadersWidth = 51;
            dgvSale.Size = new System.Drawing.Size(1200, 451);
            dgvSale.TabIndex = 35;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new System.Drawing.Point(39, 136);
            dgvStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new System.Drawing.Size(1200, 451);
            dgvStock.TabIndex = 36;
            // 
            // dgvGST
            // 
            dgvGST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGST.Location = new System.Drawing.Point(39, 152);
            dgvGST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvGST.Name = "dgvGST";
            dgvGST.RowHeadersWidth = 51;
            dgvGST.Size = new System.Drawing.Size(1200, 451);
            dgvGST.TabIndex = 37;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new System.Drawing.Point(1126, 607);
            btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new System.Drawing.Size(113, 29);
            btnExportToExcel.TabIndex = 38;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = true;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1265, 647);
            Controls.Add(btnExportToExcel);
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
            Controls.Add(label2);
            Controls.Add(dtpTo);
            Controls.Add(label3);
            Controls.Add(dtpFrom);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnExportToExcel;
    }
}