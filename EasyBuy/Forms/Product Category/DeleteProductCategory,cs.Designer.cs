namespace EasyBuy.Forms
{
    partial class DeleteProductCategory_cs
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
            btn_clear = new System.Windows.Forms.Button();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            keelsSuperMarketDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(components);
            btn_delete = new System.Windows.Forms.Button();
            txt_cdes = new System.Windows.Forms.TextBox();
            txt_cname = new System.Windows.Forms.TextBox();
            txt_cid = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btn_check = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            categoryTblBindingSource = new System.Windows.Forms.BindingSource(components);
            categoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)keelsSuperMarketDatabaseDataSetBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryTblBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_clear.Location = new System.Drawing.Point(553, 111);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new System.Drawing.Size(84, 35);
            btn_clear.TabIndex = 20;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { categoryIDDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, categoryDescriptionDataGridViewTextBoxColumn });
            dataGridView3.Location = new System.Drawing.Point(26, 153);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 24;
            dataGridView3.Size = new System.Drawing.Size(639, 262);
            dataGridView3.TabIndex = 19;
            // 
            // btn_delete
            // 
            btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_delete.Location = new System.Drawing.Point(553, 62);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(84, 35);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_cdes
            // 
            txt_cdes.Enabled = false;
            txt_cdes.Location = new System.Drawing.Point(172, 107);
            txt_cdes.Name = "txt_cdes";
            txt_cdes.Size = new System.Drawing.Size(357, 23);
            txt_cdes.TabIndex = 17;
            // 
            // txt_cname
            // 
            txt_cname.Enabled = false;
            txt_cname.Location = new System.Drawing.Point(358, 62);
            txt_cname.Name = "txt_cname";
            txt_cname.Size = new System.Drawing.Size(171, 23);
            txt_cname.TabIndex = 16;
            // 
            // txt_cid
            // 
            txt_cid.Location = new System.Drawing.Point(112, 62);
            txt_cid.Name = "txt_cid";
            txt_cid.Size = new System.Drawing.Size(59, 23);
            txt_cid.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(24, 111);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(140, 15);
            label4.TabIndex = 14;
            label4.Text = "Category Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(246, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 15);
            label3.TabIndex = 13;
            label3.Text = "Category Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(24, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 15);
            label2.TabIndex = 12;
            label2.Text = "Category ID";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(19, 15, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(814, 33);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(163, 17);
            label1.TabIndex = 0;
            label1.Text = "Delete Product Category";
            // 
            // btn_check
            // 
            btn_check.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn_check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_check.Location = new System.Drawing.Point(176, 58);
            btn_check.Name = "btn_check";
            btn_check.Size = new System.Drawing.Size(54, 28);
            btn_check.TabIndex = 25;
            btn_check.Text = "Check";
            btn_check.UseVisualStyleBackColor = true;
            btn_check.Click += btn_check_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(24, 432);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(646, 15);
            label6.TabIndex = 26;
            label6.Text = "*Please Enter The Category ID And Click Check Button To Select The Record And Delete The Record";
            // 
            // categoryTblBindingSource
            // 
            categoryTblBindingSource.DataMember = "Category_Tbl";
            categoryTblBindingSource.DataSource = keelsSuperMarketDatabaseDataSetBindingSource;
            // 
            // categoryDescriptionDataGridViewTextBoxColumn
            // 
            categoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Category_Description";
            categoryDescriptionDataGridViewTextBoxColumn.HeaderText = "Category Description";
            categoryDescriptionDataGridViewTextBoxColumn.MinimumWidth = 306;
            categoryDescriptionDataGridViewTextBoxColumn.Name = "categoryDescriptionDataGridViewTextBoxColumn";
            categoryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDescriptionDataGridViewTextBoxColumn.Width = 306;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "Category_Name";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "Category Name";
            categoryNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            categoryNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category_ID";
            categoryIDDataGridViewTextBoxColumn.HeaderText = "Category ID";
            categoryIDDataGridViewTextBoxColumn.MinimumWidth = 130;
            categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            categoryIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // DeleteProductCategory_cs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(814, 609);
            Controls.Add(label6);
            Controls.Add(btn_check);
            Controls.Add(btn_clear);
            Controls.Add(dataGridView3);
            Controls.Add(btn_delete);
            Controls.Add(txt_cdes);
            Controls.Add(txt_cname);
            Controls.Add(txt_cid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "DeleteProductCategory_cs";
            Text = "DeleteProductCategory_cs";
            Load += DeleteProductCategory_cs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)keelsSuperMarketDatabaseDataSetBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoryTblBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_cdes;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.TextBox txt_cid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_check;
       // private Keels_SuperMarket_DatabaseDataSet keels_SuperMarket_DatabaseDataSet;
        private System.Windows.Forms.BindingSource keelsSuperMarketDatabaseDataSetBindingSource;
        //private Keels_SuperMarket_DatabaseDataSetTableAdapters.Category_TblTableAdapter category_TblTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryTblBindingSource;
    }
}