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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            dataGridView4 = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
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
            btnShow.Location = new System.Drawing.Point(692, 122);
            btnShow.Name = "btnShow";
            btnShow.Size = new System.Drawing.Size(69, 29);
            btnShow.TabIndex = 7;
            btnShow.Text = "show";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(645, 77);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(250, 28);
            cmbCategory.TabIndex = 6;
            cmbCategory.Text = "---Select Category---";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new System.Drawing.Point(1157, 77);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new System.Drawing.Size(250, 28);
            cmbSupplier.TabIndex = 5;
            cmbSupplier.Text = "---Select Supplier--";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new System.Drawing.Point(901, 78);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new System.Drawing.Size(250, 28);
            cmbProduct.TabIndex = 4;
            cmbProduct.Text = "---Select Product---";
            // 
            // dtpTo
            // 
            dtpTo.Location = new System.Drawing.Point(389, 78);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new System.Drawing.Size(250, 27);
            dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new System.Drawing.Point(90, 80);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new System.Drawing.Size(250, 27);
            dtpFrom.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(353, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 20);
            label3.TabIndex = 1;
            label3.Text = "To :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 85);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "From :";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new System.Drawing.Point(90, 123);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new System.Drawing.Size(250, 28);
            cmbCustomer.TabIndex = 29;
            cmbCustomer.Text = "---Select Customer--";
            // 
            // rbtnPurchase
            // 
            rbtnPurchase.AutoSize = true;
            rbtnPurchase.Location = new System.Drawing.Point(353, 124);
            rbtnPurchase.Name = "rbtnPurchase";
            rbtnPurchase.Size = new System.Drawing.Size(88, 24);
            rbtnPurchase.TabIndex = 30;
            rbtnPurchase.TabStop = true;
            rbtnPurchase.Text = "Purchase";
            rbtnPurchase.UseVisualStyleBackColor = true;
            // 
            // rbtnGst
            // 
            rbtnGst.AutoSize = true;
            rbtnGst.Location = new System.Drawing.Point(619, 127);
            rbtnGst.Name = "rbtnGst";
            rbtnGst.Size = new System.Drawing.Size(56, 24);
            rbtnGst.TabIndex = 31;
            rbtnGst.TabStop = true;
            rbtnGst.Text = "GST";
            rbtnGst.UseVisualStyleBackColor = true;
            // 
            // rbtnStock
            // 
            rbtnStock.AutoSize = true;
            rbtnStock.Location = new System.Drawing.Point(535, 127);
            rbtnStock.Name = "rbtnStock";
            rbtnStock.Size = new System.Drawing.Size(66, 24);
            rbtnStock.TabIndex = 32;
            rbtnStock.TabStop = true;
            rbtnStock.Text = "Stock";
            rbtnStock.UseVisualStyleBackColor = true;
            // 
            // rbtnSale
            // 
            rbtnSale.AutoSize = true;
            rbtnSale.Location = new System.Drawing.Point(447, 127);
            rbtnSale.Name = "rbtnSale";
            rbtnSale.Size = new System.Drawing.Size(17, 16);
            rbtnSale.TabIndex = 33;
            rbtnSale.TabStop = true;
            rbtnSale.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(35, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(1372, 188);
            dataGridView1.TabIndex = 34;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(35, 197);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new System.Drawing.Size(1372, 188);
            dataGridView2.TabIndex = 35;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new System.Drawing.Point(35, 214);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new System.Drawing.Size(1372, 188);
            dataGridView3.TabIndex = 36;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new System.Drawing.Point(35, 235);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new System.Drawing.Size(1372, 188);
            dataGridView4.TabIndex = 37;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1437, 782);
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}