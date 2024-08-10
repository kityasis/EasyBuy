using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy.Forms.Product_Items
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        private async void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'keels_SuperMarket_DatabaseDataSet3.Product_Table' table. You can move, or remove it, as needed.
            //this.product_TableTableAdapter.Fill(this.keels_SuperMarket_DatabaseDataSet3.Product_Table);
            //con = new SqlConnection("Data Source=DESKTOP-SMVQK5B\\SQLEXPRESS;Initial Catalog=Keels_SuperMarket_Database;Integrated Security=True");
            //dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.YellowGreen;
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.productDataGridView.AllowUserToAddRows = true;
            this.productDataGridView.AllowUserToDeleteRows = true;
            productDataGridView.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.ToListAsync());
                productDataGridView.DataSource= products;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadComboBox();
        }
        private void Refresh()
        {
            // this.product_TableTableAdapter.Fill(this.keels_SuperMarket_DatabaseDataSet3.Product_Table);

        }
        int ax;
        private void AutoProductIDGen()
        {
            //con.Open();
            //cmd = new SqlCommand("Select count (Product_ID) from [Product_Table]", con);
            //ax = Convert.ToInt32(((SqlCommand)cmd).ExecuteScalar());
            //con.Close();
            //ax++;
            //txt_productid.Text = "PID-" + ax.ToString();

        }
        private async void LoadComboBox()
        {
            cmbCategory.Items.Clear();
            try
            {
                await using var context = new EasyBuyContext();
                var categories = await Task.Run(() => context.Category.ToListAsync());
                cmbCategory.Items.AddRange(categories.Select(x => x.Name).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Product Name Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtGstAmount.Text.Length == 0 || txtGstAmount.Text.Any(Char.IsLetter))
            {
                MessageBox.Show("Product Price Cannot Be Blanck Or Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQunatity.Text.Length == 0 || txtQunatity.Text.Any(Char.IsLetter))
            {
                MessageBox.Show("Product Quantity Cannot Be Blanck Or Cannot Contain Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategory.Text.Length == 0)
            {
                MessageBox.Show("Please Select An Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //con.Open();
                //cmd = new SqlCommand("Select Prodcut_Quantity from Product_Table where Product_Name = '" + txt_productid + "'", con);
                //con.Close();
                try
                {
                    //con.Open();
                    //cmd = new SqlCommand("Insert Into Product_Table values('" + txt_productid.Text + "','" + txt_productname.Text + "','" + txt_price.Text + "','" + txt_productqunatity.Text + "',@a)", con);
                    //cmd.Parameters.AddWithValue("@a", cmb_productcategory.SelectedItem);
                    //int i = cmd.ExecuteNonQuery();
                    //con.Close();
                    //if (i == 1)
                    //{
                    //    Refresh();
                    //    MessageBox.Show("New Product Added Succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("New Product Cannot Be Added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

                    AutoProductIDGen();

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


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtQunatity.Clear();
            txtGstAmount.Clear();
            cmbCategory.SelectedIndex = -1;
            AutoProductIDGen();

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }


        private void txtQunatity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void texPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void txtDiscountAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void txtTotalPriceAfterDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void txtGstAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void txtFinalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void txtGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }
       
    }
}
