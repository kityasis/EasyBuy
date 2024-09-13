namespace EasyBuy.Forms
{
    partial class Category
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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            CategoryDataGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            categoryBindingSource = new System.Windows.Forms.BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(72, 52, 212);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1014, 44);
            panel1.TabIndex = 0;
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
            label1.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(69, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 18);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(27, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 18);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(130, 68);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(474, 27);
            txtName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(130, 143);
            txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(474, 27);
            txtDescription.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnAdd.Location = new System.Drawing.Point(627, 143);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(96, 35);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(739, 143);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(96, 35);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // CategoryDataGridView
            // 
            CategoryDataGridView.AllowUserToDeleteRows = false;
            CategoryDataGridView.AutoGenerateColumns = false;
            CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            CategoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, Edit, Delete });
            CategoryDataGridView.DataSource = categoryBindingSource;
            CategoryDataGridView.Location = new System.Drawing.Point(27, 200);
            CategoryDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            CategoryDataGridView.Name = "CategoryDataGridView";
            CategoryDataGridView.ReadOnly = true;
            CategoryDataGridView.RowHeadersVisible = false;
            CategoryDataGridView.RowHeadersWidth = 51;
            CategoryDataGridView.RowTemplate.Height = 24;
            CategoryDataGridView.Size = new System.Drawing.Size(937, 396);
            CategoryDataGridView.TabIndex = 20;
            CategoryDataGridView.CellContentClick += CategoryDataGridView_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Edit.DataPropertyName = "Id";
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.ToolTipText = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Delete.DataPropertyName = "Id";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.ToolTipText = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // Category
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1014, 633);
            Controls.Add(CategoryDataGridView);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Category";
            Text = "Category";
            Load += AddProductCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;    
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView CategoryDataGridView;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}