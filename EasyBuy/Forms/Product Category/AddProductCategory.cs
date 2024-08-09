using EasyBuy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBuy.Forms
{
    public partial class AddProductCategory : Form
    {
        public AddProductCategory()
        {
            InitializeComponent();
        }
       
        private async void RefreshData()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var categories = await Task.Run(() => context.Category.ToListAsync());
                dataGridView1.DataSource = categories;
            }
            catch (Exception ex) {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                      

        }
        private void AddProductCategory_Load(object sender, EventArgs e)
        {
            RefreshData();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {           
            txt_cname.Clear();
            txt_cdes.Clear();           
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cname.Text.Length == 0) { MessageBox.Show("Category Name Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if (txt_cdes.Text.Length == 0) { MessageBox.Show("Category Description Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    await using var context = new EasyBuyContext();
                    var category = new Category() { Name = txt_cname.Text, Description = txt_cdes.Text };
                    var employee = await Task.Run(() => context.Category.Add(category));
                    await context.SaveChangesAsync();
                    txt_cname.Clear();
                    txt_cdes.Clear();
                }
            }
            catch (FormatException) { MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (Exception) { MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            RefreshData();
        }
    }
}
