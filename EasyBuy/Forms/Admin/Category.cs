using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBuy.Forms
{
    public partial class Category : Form
    {
        private Int64 _id;
        public Category()
        {
            InitializeComponent();
        }

        private async void RefreshData()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var categories = await Task.Run(() => context.Category.ToListAsync());
                CategoryDataGridView.DataSource = categories;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AddProductCategory_Load(object sender, EventArgs e)
        {
            RefreshData();
            CategoryDataGridView.EnableHeadersVisualStyles = false;
            CategoryDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            CategoryDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CategoryDataGridView.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDescription.Clear();
            btnAdd.Text = "Add";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length == 0) { MessageBox.Show("Category Name Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (txtDescription.Text.Length == 0) { MessageBox.Show("Category Description Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    await using var context = new EasyBuyContext();
                    var category = new Models.Category() { Name = txtName.Text, Description = txtDescription.Text };
                    if (btnAdd.Text == "Add")
                    {

                        await Task.Run(() => context.Category.Add(category));
                    }
                    else
                    {
                        category.Id = _id;
                        await Task.Run(() => context.Category.Update(category));
                        btnAdd.Text = "Add";

                    }
                    await context.SaveChangesAsync();
                    txtName.Clear();
                    txtDescription.Clear();
                }
            }
            catch (FormatException) { MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception) { MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            RefreshData();
        }

        private async void CategoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var id = Convert.ToInt64(CategoryDataGridView[0, e.RowIndex].Value);
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            await using var context = new EasyBuyContext();
                            var category = await Task.Run(() => context.Category.FirstOrDefaultAsync(x => x.Id == id));
                            await Task.Run(() => context.Category.Remove(category));
                            await context.SaveChangesAsync();
                            RefreshData();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    try
                    {
                        await using var context = new EasyBuyContext();
                        var category = await Task.Run(() => context.Category.FirstOrDefaultAsync(x => x.Id == id));
                        txtName.Text = category.Name;
                        txtDescription.Text = category.Description;
                        this._id = category.Id;
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
