using EasyBuy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBuy.Forms
{
    public partial class DeleteProductCategory_cs : Form
    {
        public DeleteProductCategory_cs()
        {
            InitializeComponent();
        }
      
        private void DeleteProductCategory_cs_Load(object sender, EventArgs e)
        {           
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);
            Refresh();
        }
        private async void Refresh()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var categories = await Task.Run(() => context.Category.ToListAsync());
                dataGridView3.DataSource = categories;
                txt_cname.Clear();
                txt_cdes.Clear();
                txt_cname.Enabled = false;
                txt_cdes.Enabled = false;
                btn_delete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            
        }

        private async void btn_check_Click(object sender, EventArgs e)
        {
            var _id = Convert.ToInt64(txt_cid.Text);
            await using var context = new EasyBuyContext();
            var category = await Task.Run(() => context.Category.FirstOrDefault(x => x.Id == _id));
            if (category != null)
            {
                txt_cname.Text = category.Name;
                txt_cdes.Text = category.Description;
                btn_delete.Enabled = true;
            }
            else
            {
                MessageBox.Show("Category Data Not Found or Category ID Is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                await using var context = new EasyBuyContext();
                var category = new Category() { Id = Convert.ToInt64(txt_cid.Text), Name = txt_cname.Text, Description = txt_cdes.Text };
                await Task.Run(() => context.Category.Remove(category));
                await context.SaveChangesAsync();
                Refresh();
           }
            catch (FormatException)
            {

                MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)

            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_cid.Clear();
            txt_cname.Clear();
            txt_cdes.Clear();
            txt_cname.Enabled = false;
            txt_cdes.Enabled = false;
            btn_delete.Enabled = false;
        }
    }
}
