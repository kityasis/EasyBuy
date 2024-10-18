namespace EasyBuy.Forms.Employee_Account
{
    partial class Employee
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
            txtPassword = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            cmdRole = new System.Windows.Forms.ComboBox();
            txtUserName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            txtFullName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            employeeBindingSource = new System.Windows.Forms.BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
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
            panel1.Size = new System.Drawing.Size(987, 44);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(11, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(250, 157);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(282, 27);
            txtPassword.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(40, 163);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(83, 18);
            label7.TabIndex = 49;
            label7.Text = "Password";
            // 
            // cmdRole
            // 
            cmdRole.FormattingEnabled = true;
            cmdRole.Items.AddRange(new object[] { "Administrator", "Cashier" });
            cmdRole.Location = new System.Drawing.Point(250, 232);
            cmdRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmdRole.Name = "cmdRole";
            cmdRole.Size = new System.Drawing.Size(282, 28);
            cmdRole.TabIndex = 48;
            cmdRole.Text = "---Select Role---";
            // 
            // txtUserName
            // 
            txtUserName.Location = new System.Drawing.Point(250, 120);
            txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(282, 27);
            txtUserName.TabIndex = 47;
            txtUserName.Leave += txtUserName_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(40, 237);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 18);
            label5.TabIndex = 46;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(40, 125);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(93, 18);
            label6.TabIndex = 45;
            label6.Text = "User Name";
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClear.Location = new System.Drawing.Point(658, 220);
            btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(96, 43);
            btnClear.TabIndex = 44;
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
            btnAdd.Location = new System.Drawing.Point(555, 220);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(96, 43);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(250, 195);
            txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new System.Drawing.Size(282, 27);
            txtConfirmPassword.TabIndex = 42;
            txtConfirmPassword.Leave += txtConfirmPassword_Leave;
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(250, 83);
            txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(282, 27);
            txtFullName.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(40, 200);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(151, 18);
            label3.TabIndex = 40;
            label3.Text = "Re-Type Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(40, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 18);
            label2.TabIndex = 39;
            label2.Text = "Full Name";
            // 
            // EmployeeDataGridView
            // 
            EmployeeDataGridView.AllowUserToDeleteRows = false;
            EmployeeDataGridView.AutoGenerateColumns = false;
            EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, Edit, Delete });
            EmployeeDataGridView.DataSource = employeeBindingSource;
            EmployeeDataGridView.Location = new System.Drawing.Point(24, 307);
            EmployeeDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.RowHeadersVisible = false;
            EmployeeDataGridView.RowHeadersWidth = 51;
            EmployeeDataGridView.RowTemplate.Height = 24;
            EmployeeDataGridView.Size = new System.Drawing.Size(937, 396);
            EmployeeDataGridView.TabIndex = 51;
            EmployeeDataGridView.CellContentClick += EmployeeDataGridView_CellContentClick;
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
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
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
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // Employee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(987, 749);
            Controls.Add(EmployeeDataGridView);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(cmdRole);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmdRole;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}