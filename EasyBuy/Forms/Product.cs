using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            this.productDataGridView.AllowUserToAddRows = true;
            this.productDataGridView.AllowUserToDeleteRows = true;
            productDataGridView.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.ToListAsync());
                //productDataGridView.DataSource= products;
                productDataGridView.Rows.Add(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCategoryComboBox();
            LoadSupplierComboBox();
        }
        private void Refresh()
        {
            // this.product_TableTableAdapter.Fill(this.keels_SuperMarket_DatabaseDataSet3.Product_Table);

        }        
        private async void LoadCategoryComboBox()
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
        private async void LoadSupplierComboBox()
        {
            cmbSupplier.Items.Clear();
            try
            {
                await using var context = new EasyBuyContext();
                var supplieres = await Task.Run(() => context.Supplier.ToListAsync());
                cmbSupplier.Items.AddRange(supplieres.Select(x => x.Name).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
             if (cmbSupplier.Text == "---Select---") MessageBox.Show("Please Select A Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cmbCategory.Text == "---Select---") MessageBox.Show("Please Select An Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtName.Text.Length == 0) MessageBox.Show("Product Name Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtPrice.Text.Length == 0) MessageBox.Show("Product Price Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtQunatity.Text.Length == 0) MessageBox.Show("Product Qunatity Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtTotalPrice.Text.Length == 0) MessageBox.Show("Product TotalPrice Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            else if (txtGST.Text.Length == 0) MessageBox.Show("Product Gst Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtGstAmount.Text.Length == 0) MessageBox.Show("Product Gst Amount Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtFinalPrice.Text.Length == 0) MessageBox.Show("Product Final Price Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

                try
                {
                    await using var context = new EasyBuyContext();
                    //var product = new Models.Product() { Name = txtName.Text, ContactNumber = Convert.ToInt32(txtContactNumber.Text), Address = txtAddress.Text };
                    //if (btnAdd.Text == "Add")
                    //{

                    //    await Task.Run(() => context.Product.Add(product));
                    //}
                    //else
                    //{
                    //    Supplier.Id = _id;
                    //    await Task.Run(() => context.Supplier.Update(Supplier));
                    //    btnAdd.Text = "Add";

                    //}
                    //await context.SaveChangesAsync();
                    //txtName.Clear();
                    //txtAddress.Clear();
                    //txtContactNumber.Clear();


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

        private void txtQunatity_TextChanged(object sender, EventArgs e)
        {
            if (txtQunatity.Text.Length == 0) return;
            if (txtPrice.Text.Length == 0) return;
            txtTotalPrice.Text = (Convert.ToDouble(txtQunatity.Text) * Convert.ToDouble(txtPrice.Text)).ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtQunatity.Text.Length == 0) return;
            if (txtPrice.Text.Length == 0) return;
            txtTotalPrice.Text = (Convert.ToDouble(txtQunatity.Text) * Convert.ToDouble(txtPrice.Text)).ToString();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPrice.Text.Length == 0) return;
            if (txtDiscount.Text.Length == 0) return;
            txtDiscountAmount.Text = ((Convert.ToDouble(txtTotalPrice.Text) * Convert.ToDouble(txtDiscount.Text)) / 100).ToString();
            txtTotalPriceAfterDiscount.Text = (Convert.ToDouble(txtTotalPrice.Text) - Convert.ToDouble(txtDiscountAmount.Text)).ToString();
        }

        private void txtGST_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPriceAfterDiscount.Text.Length == 0 && txtTotalPrice.Text.Length == 0) return;
            if (txtGST.Text.Length == 0) return;
            var price =string.IsNullOrEmpty(txtTotalPriceAfterDiscount.Text) ? txtTotalPrice.Text: txtTotalPriceAfterDiscount.Text;
            var gstAmount = (Convert.ToDouble(price) * Convert.ToDouble(txtGST.Text)) / 100;
            txtGstAmount.Text = gstAmount.ToString();
            txtFinalPrice.Text = (Convert.ToDouble(price) + Convert.ToDouble(txtGstAmount.Text)).ToString();
        }
    }
}
