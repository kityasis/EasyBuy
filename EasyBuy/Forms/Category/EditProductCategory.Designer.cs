namespace EasyBuy.Forms
{
    partial class EditProductCategory
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
            btn_clear = new System.Windows.Forms.Button();
            btn_edit = new System.Windows.Forms.Button();
            txt_cdes = new System.Windows.Forms.TextBox();
            txt_cname = new System.Windows.Forms.TextBox();
            txt_cid = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            button2 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_clear.Location = new System.Drawing.Point(553, 107);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new System.Drawing.Size(84, 35);
            btn_clear.TabIndex = 20;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_edit
            // 
            btn_edit.Enabled = false;
            btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_edit.Location = new System.Drawing.Point(553, 62);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(84, 35);
            btn_edit.TabIndex = 18;
            btn_edit.Text = "Update";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
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
            txt_cid.TextChanged += txt_cid_TextChanged;
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
            label3.Location = new System.Drawing.Point(246, 66);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 15);
            label3.TabIndex = 13;
            label3.Text = "Category Name";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(48, 51, 107);
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
            label1.Size = new System.Drawing.Size(146, 17);
            label1.TabIndex = 0;
            label1.Text = "Edit Product Category";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(24, 432);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(629, 15);
            label6.TabIndex = 21;
            label6.Text = "*Please Enter The Category ID And Click Check Button To Select The Record And Edit The Record";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(26, 153);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new System.Drawing.Size(639, 262);
            dataGridView2.TabIndex = 22;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button2.Location = new System.Drawing.Point(176, 58);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(54, 28);
            button2.TabIndex = 24;
            button2.Text = "Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditProductCategory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(814, 609);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(btn_clear);
            Controls.Add(btn_edit);
            Controls.Add(txt_cdes);
            Controls.Add(txt_cname);
            Controls.Add(txt_cid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "EditProductCategory";
            Text = "EditProductCategory";
            Load += EditProductCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_cdes;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.TextBox txt_cid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        //private Keels_SuperMarket_DatabaseDataSetTableAdapters.Category_TblTableAdapter category_TblTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
    }
}