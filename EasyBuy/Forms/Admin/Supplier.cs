using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBuy.Forms
{
    public partial class Supplier : Form
    {
        private Int64 _id;
        public Supplier()
        {
            InitializeComponent();
        }

        private async void RefreshData()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var suppliers = await Task.Run(() => context.Supplier.ToListAsync());
                SupplierDataGridView.DataSource = suppliers;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            RefreshData();
            SupplierDataGridView.EnableHeadersVisualStyles = false;
            SupplierDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            SupplierDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SupplierDataGridView.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtContactNumber.Clear();
            btnAdd.Text = "Add";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length == 0) { MessageBox.Show("Supplier Name Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (txtAddress.Text.Length == 0) { MessageBox.Show("Supplier Description Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    await using var context = new EasyBuyContext();
                    var Supplier = new Models.Supplier() { Name = txtName.Text, ContactNumber = Convert.ToInt32(txtContactNumber.Text), Address = txtAddress.Text };
                    if (btnAdd.Text == "Add")
                    {

                        await Task.Run(() => context.Supplier.Add(Supplier));
                    }
                    else
                    {
                        Supplier.Id = _id;
                        await Task.Run(() => context.Supplier.Update(Supplier));
                        btnAdd.Text = "Add";

                    }
                    await context.SaveChangesAsync();
                    txtName.Clear();
                    txtAddress.Clear();
                    txtContactNumber.Clear();
                      
                }
            }
            catch (FormatException) { MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception) { MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            RefreshData();
        }

        private async void SupplierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var id = Convert.ToInt64(SupplierDataGridView[0, e.RowIndex].Value);
                if (e.ColumnIndex == 5)
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            await using var context = new EasyBuyContext();
                            var supplier = await Task.Run(() => context.Supplier.FirstOrDefaultAsync(x => x.Id == id));
                            await Task.Run(() => context.Supplier.Remove(supplier));
                            await context.SaveChangesAsync();
                            RefreshData();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    try
                    {
                        await using var context = new EasyBuyContext();
                        var supplier = await Task.Run(() => context.Supplier.FirstOrDefaultAsync(x => x.Id == id));
                        txtName.Text = supplier.Name;
                        txtContactNumber.Text= supplier.ContactNumber.ToString();
                        txtAddress.Text = supplier.Address;
                        this._id = supplier.Id;
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
