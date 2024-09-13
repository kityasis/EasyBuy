using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.EntityFrameworkCore;

namespace EasyBuy.Forms.Employee_Account
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        private Int64 _id;
        private async void RefreshData()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var suppliers = await Task.Run(() => context.Employee.ToListAsync());
                EmployeeDataGridView.DataSource = suppliers;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Employee_Load(object sender, EventArgs e)
        {
            RefreshData();
            EmployeeDataGridView.EnableHeadersVisualStyles = false;
            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            EmployeeDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            EmployeeDataGridView.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.TextLength == 0)
                {
                    MessageBox.Show("Full Name Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtUserName.Text.Length == 0)
                {
                    MessageBox.Show("User Name Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    await using var context = new EasyBuyContext();
                    var employee = new Models.Employee() { Name = txtFullName.Text, UserName = txtUserName.Text, Password = txtPassword.Text, Role = cmdRole.Text };
                    if (btnAdd.Text == "Add")
                    {

                        await Task.Run(() => context.Employee.Add(employee));
                    }
                    else
                    {
                        employee.Id = _id;
                        await Task.Run(() => context.Employee.Update(employee));
                        btnAdd.Text = "Add";

                    }
                    await context.SaveChangesAsync();
                    RefreshData();
                    Clear();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Please select an image to upload", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            Clear();
        }
        private void Clear()
        {
            txtFullName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtUserName.Clear();
            cmdRole.SelectedIndex = -1;
        }

        private async void txtUserName_Leave(object sender, EventArgs e)
        {
            try
            {
                await using var context = new EasyBuyContext();
                var employeeCount = await Task.Run(() => context.Employee.Where(x => x.UserName == txtUserName.Text).CountAsync());
                if (employeeCount > 0)
                {
                    MessageBox.Show("Same UserName already present, try defferent", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Enterd Passwords Doesnt Match Please Check Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Clear();
            }
        }

        private async void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var id = Convert.ToInt64(EmployeeDataGridView[0, e.RowIndex].Value);
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            await using var context = new EasyBuyContext();
                            var employee = await Task.Run(() => context.Employee.FirstOrDefaultAsync(x => x.Id == id));
                            await Task.Run(() => context.Employee.Remove(employee));
                            await context.SaveChangesAsync();
                            RefreshData();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    try
                    {
                        await using var context = new EasyBuyContext();
                        var employee = await Task.Run(() => context.Employee.FirstOrDefaultAsync(x => x.Id == id));
                        txtFullName.Text = employee.Name;
                        txtUserName.Text = employee.UserName;                      
                        cmdRole.Text = employee.Role;                       
                        this._id = employee.Id;
                        btnAdd.Text = "Update";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
