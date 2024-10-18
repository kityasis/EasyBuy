namespace EasyBuy.Forms.Nexus
{
    partial class Member
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
            txtName = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtContactNumber = new System.Windows.Forms.TextBox();
            txtId = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblPoint = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            MemberDataGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            memberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            memberBindingSource = new System.Windows.Forms.BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MemberDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
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
            panel1.Size = new System.Drawing.Size(984, 44);
            panel1.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(11, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Nexus Member";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(157, 124);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(237, 27);
            txtName.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(25, 129);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(52, 18);
            label6.TabIndex = 60;
            label6.Text = "Name";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(514, 163);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(96, 36);
            btnClear.TabIndex = 59;
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
            btnAdd.Location = new System.Drawing.Point(399, 163);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(96, 36);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new System.Drawing.Point(157, 163);
            txtContactNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new System.Drawing.Size(235, 27);
            txtContactNumber.TabIndex = 57;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new System.Drawing.Point(157, 88);
            txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(237, 27);
            txtId.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(22, 163);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 18);
            label3.TabIndex = 55;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(25, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(24, 18);
            label2.TabIndex = 54;
            label2.Text = "ID";
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Location = new System.Drawing.Point(157, 203);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new System.Drawing.Size(17, 20);
            lblPoint.TabIndex = 62;
            lblPoint.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(25, 201);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 18);
            label5.TabIndex = 63;
            label5.Text = "Points";
            // 
            // MemberDataGridView
            // 
            MemberDataGridView.AllowUserToDeleteRows = false;
            MemberDataGridView.AutoGenerateColumns = false;
            MemberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            MemberDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            MemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, memberIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, contactNumberDataGridViewTextBoxColumn, pointsDataGridViewTextBoxColumn, Edit, Delete });
            MemberDataGridView.DataSource = memberBindingSource;
            MemberDataGridView.Location = new System.Drawing.Point(25, 249);
            MemberDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MemberDataGridView.Name = "MemberDataGridView";
            MemberDataGridView.ReadOnly = true;
            MemberDataGridView.RowHeadersVisible = false;
            MemberDataGridView.RowHeadersWidth = 51;
            MemberDataGridView.RowTemplate.Height = 24;
            MemberDataGridView.Size = new System.Drawing.Size(897, 396);
            MemberDataGridView.TabIndex = 64;
            MemberDataGridView.CellContentClick += MemberDataGridView_CellContentClick;
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
            // memberIdDataGridViewTextBoxColumn
            // 
            memberIdDataGridViewTextBoxColumn.DataPropertyName = "MemberId";
            memberIdDataGridViewTextBoxColumn.HeaderText = "MemberId";
            memberIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            memberIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            contactNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            pointsDataGridViewTextBoxColumn.MinimumWidth = 6;
            pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            pointsDataGridViewTextBoxColumn.ReadOnly = true;
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
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Models.Member);
            // 
            // Member
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 704);
            Controls.Add(MemberDataGridView);
            Controls.Add(label5);
            Controls.Add(lblPoint);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtContactNumber);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Member";
            Text = "Member";
            Load += Member_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MemberDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        //private Keels_SuperMarket_DatabaseDataSet9TableAdapters.Member_TableTableAdapter member_TableTableAdapter;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView MemberDataGridView;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}