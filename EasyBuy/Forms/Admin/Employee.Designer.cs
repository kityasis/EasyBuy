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
            txt_password = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            cmd_role = new System.Windows.Forms.ComboBox();
            txt_uname = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btn_clear = new System.Windows.Forms.Button();
            btn_add = new System.Windows.Forms.Button();
            txt_password2 = new System.Windows.Forms.TextBox();
            txt_fname = new System.Windows.Forms.TextBox();
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
            panel1.BackColor = System.Drawing.Color.FromArgb(72, 52, 212);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(864, 33);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 17);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // txt_password
            // 
            txt_password.Location = new System.Drawing.Point(219, 118);
            txt_password.Name = "txt_password";
            txt_password.Size = new System.Drawing.Size(247, 23);
            txt_password.TabIndex = 50;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(35, 122);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(69, 15);
            label7.TabIndex = 49;
            label7.Text = "Password";
            // 
            // cmd_role
            // 
            cmd_role.FormattingEnabled = true;
            cmd_role.Items.AddRange(new object[] { "Administrator", "Cashier" });
            cmd_role.Location = new System.Drawing.Point(219, 174);
            cmd_role.Name = "cmd_role";
            cmd_role.Size = new System.Drawing.Size(247, 23);
            cmd_role.TabIndex = 48;
            // 
            // txt_uname
            // 
            txt_uname.Location = new System.Drawing.Point(219, 90);
            txt_uname.Name = "txt_uname";
            txt_uname.Size = new System.Drawing.Size(247, 23);
            txt_uname.TabIndex = 47;
            txt_uname.TextChanged += txt_uname_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(35, 178);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 15);
            label5.TabIndex = 46;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(35, 94);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(79, 15);
            label6.TabIndex = 45;
            label6.Text = "User Name";
            // 
            // btn_clear
            // 
            btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_clear.Location = new System.Drawing.Point(576, 165);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new System.Drawing.Size(84, 32);
            btn_clear.TabIndex = 44;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_add
            // 
            btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_add.Location = new System.Drawing.Point(486, 165);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(84, 32);
            btn_add.TabIndex = 43;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_password2
            // 
            txt_password2.Location = new System.Drawing.Point(219, 146);
            txt_password2.Name = "txt_password2";
            txt_password2.Size = new System.Drawing.Size(247, 23);
            txt_password2.TabIndex = 42;
            // 
            // txt_fname
            // 
            txt_fname.Location = new System.Drawing.Point(219, 62);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new System.Drawing.Size(247, 23);
            txt_fname.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(35, 150);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 15);
            label3.TabIndex = 40;
            label3.Text = "Re-Type Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(35, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 15);
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
            EmployeeDataGridView.Location = new System.Drawing.Point(21, 230);
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.RowHeadersVisible = false;
            EmployeeDataGridView.RowHeadersWidth = 51;
            EmployeeDataGridView.RowTemplate.Height = 24;
            EmployeeDataGridView.Size = new System.Drawing.Size(820, 297);
            EmployeeDataGridView.TabIndex = 51;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
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
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(864, 562);
            Controls.Add(EmployeeDataGridView);
            Controls.Add(txt_password);
            Controls.Add(label7);
            Controls.Add(cmd_role);
            Controls.Add(txt_uname);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btn_clear);
            Controls.Add(btn_add);
            Controls.Add(txt_password2);
            Controls.Add(txt_fname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Employee";
            Text = "CreateEmployeeAccount";
            Load += CreateEmployeeAccount_Load;
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
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmd_role;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.TextBox txt_fname;
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