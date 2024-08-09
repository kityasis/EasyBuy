using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using EasyBuy.Models;

namespace EasyBuy.Forms
{
    public partial class EditProductCategory : Form
    {
        public EditProductCategory()
        {
            InitializeComponent();
        }

        private async void Refresh()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var categories = await Task.Run(() => context.Category.ToListAsync());
                dataGridView2.DataSource = categories;
                txt_cname.Clear();
                txt_cdes.Clear();
                txt_cname.Enabled = false;
                txt_cdes.Enabled = false;
                btn_edit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EditProductCategory_Load(object sender, EventArgs e)
        {
            Refresh();
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);

        }

        private async void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cname.Text.Length == 0)
                {
                    MessageBox.Show("Category Name Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_cdes.Text.Length == 0)
                {
                    MessageBox.Show("Category Description Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    await using var context = new EasyBuyContext();
                    var category = new Category() { Id = Convert.ToInt64(txt_cid.Text), Name = txt_cname.Text, Description = txt_cdes.Text };
                    var employee = await Task.Run(() => context.Category.Update(category));
                    await context.SaveChangesAsync();
                    Refresh();
                }

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
            btn_edit.Enabled = false;
        }

        private void txt_cid_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (txt_cid.Text.Length == 0)
            {
                MessageBox.Show("Category ID Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var _id = Convert.ToInt64(txt_cid.Text);
                    await using var context = new EasyBuyContext();
                    var category = await Task.Run(() => context.Category.FirstOrDefault(x => x.Id == _id));
                    if (category != null)
                    {
                        txt_cname.Text = category.Name;
                        txt_cdes.Text = category.Description;
                        txt_cname.Enabled = true;
                        txt_cdes.Enabled = true;
                        btn_edit.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Category Data Not Found or Category ID Is Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
