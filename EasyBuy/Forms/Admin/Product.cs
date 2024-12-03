using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EasyBuy.Forms.Admin
{
    public partial class Product : Form
    {
        private Int64 _id;
        public Product()
        {
            InitializeComponent();
        }
        private async void RefreshData()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var productes = await Task.Run(() => context.Product.ToListAsync());
                ProductDataGridView.DataSource = productes;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void Product_Load(object sender, EventArgs e)
        {
            ProductDataGridView.EnableHeadersVisualStyles = false;
            ProductDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            ProductDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ProductDataGridView.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);

            RefreshData();
            LoadCategoryComboBox();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {

            if (cmbCategory.Text == "---Select---") MessageBox.Show("Please Select An Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtName.Text.Length == 0) MessageBox.Show("Product Name Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtPrice.Text.Length == 0) MessageBox.Show("Product Price Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtQunatity.Text.Length == 0) MessageBox.Show("Product Qunatity Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtGST.Text.Length == 0) MessageBox.Show("Product Gst Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtSGstAmount.Text.Length == 0) MessageBox.Show("Product Gst Amount Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtFinalPrice.Text.Length == 0) MessageBox.Show("Product Final Price Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                try
                {
                    await using var context = new EasyBuyContext();
                    var product = new Models.Product()
                    {
                        Code = txtBarcode.Text,
                        Catagory = cmbCategory.Text,
                        Name = txtName.Text.Trim(),
                        Price = Convert.ToDecimal(txtPrice.Text),
                        Quantity = Convert.ToInt32(txtQunatity.Text),
                        Discount = Convert.ToDecimal(txtDiscount.Text),
                        DiscountAmount = Convert.ToDecimal(txtDiscountAmount.Text),
                        PriceAfterDiscount = Convert.ToDecimal(txtPriceAfterDiscount.Text),
                        GSTPercentage = Convert.ToDecimal(txtGST.Text),
                        SGST = Convert.ToDecimal(txtSGstAmount.Text),
                        CGST = Convert.ToDecimal(txtCGstAmount.Text),
                        TotalPriceIncludingGST = Convert.ToDecimal(txtFinalPrice.Text)
                    };
                    if (btnAdd.Text == "Add")
                    {

                        await Task.Run(() => context.Product.Add(product));
                    }
                    else
                    {
                        product.Id = _id;
                        await Task.Run(() => context.Product.Update(product));
                        btnAdd.Text = "Add";

                    }

                    await context.SaveChangesAsync();
                    this.Clear();
                }
                catch (FormatException)
                {

                    MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                RefreshData();

            }
        }
        private void Clear()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQunatity.Clear();
            txtDiscount.Clear();
            txtDiscountAmount.Clear();
            txtPriceAfterDiscount.Clear();
            txtGST.Clear();
            txtSGstAmount.Clear();
            txtCGstAmount.Clear();
            txtFinalPrice.Clear();
            cmbCategory.Text = "---Select---";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Clear();
        }


        private void txtGST_TextChanged(object sender, EventArgs e)
        {
            if (txtPriceAfterDiscount.Text.Length == 0 && txtPrice.Text.Length == 0) return;
            if (txtGST.Text.Length == 0) return;
            var price = string.IsNullOrEmpty(txtPriceAfterDiscount.Text) ? txtPrice.Text : txtPriceAfterDiscount.Text;
            var gstAmount = ((Convert.ToDouble(price) * Convert.ToDouble(txtGST.Text)) / 100) / 2;
            txtSGstAmount.Text = Math.Round(gstAmount, 2).ToString();
            txtCGstAmount.Text = Math.Round(gstAmount, 2).ToString();
            txtFinalPrice.Text = Math.Round((Convert.ToDouble(price) + Convert.ToDouble(txtSGstAmount.Text)), 2).ToString();
        }

        private async void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var id = Convert.ToInt64(ProductDataGridView[0, e.RowIndex].Value);
                if (e.ColumnIndex == 14)
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            await using var context = new EasyBuyContext();
                            var product = await Task.Run(() => context.Product.FirstOrDefaultAsync(x => x.Id == id));
                            await Task.Run(() => context.Product.Remove(product));
                            await context.SaveChangesAsync();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == 13)
                {
                    try
                    {
                        btnAdd.Text = "Update";
                        await using var context = new EasyBuyContext();
                        var product = await Task.Run(() => context.Product.FirstOrDefaultAsync(x => x.Id == id));
                        txtName.Text = product.Name;
                        txtPrice.Text = product.Price.ToString();
                        txtQunatity.Text = product.Quantity.ToString();
                        txtDiscount.Text = product.Discount.ToString();
                        txtDiscountAmount.Text = product.DiscountAmount.ToString();
                        txtPriceAfterDiscount.Text = product.PriceAfterDiscount.ToString();
                        txtGST.Text = product.GSTPercentage.ToString();
                        txtSGstAmount.Text = product.SGST.ToString();
                        txtCGstAmount.Text = product.CGST.ToString();
                        txtFinalPrice.Text = product.TotalPriceIncludingGST.ToString();
                        cmbCategory.Text = product.Catagory;
                        txtBarcode.Text = product.Code;
                        this._id = product.Id;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                RefreshData();

            }
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

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void txtGST_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text.Length == 0) return;
            txtDiscountAmount.Text = Math.Round(((Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtDiscount.Text)) / 100), 2).ToString();
            txtPriceAfterDiscount.Text = Math.Round((Convert.ToDouble(txtPrice.Text) - Convert.ToDouble(txtDiscountAmount.Text)), 2).ToString();
            txtFinalPrice.Text = Math.Round((Convert.ToDouble(txtPrice.Text) - Convert.ToDouble(txtDiscountAmount.Text)), 2).ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            //if (txtQunatity.Text.Length == 0) return;
            if (txtPrice.Text.Length == 0) return;
            txtFinalPrice.Text = txtPrice.Text;
            txtDiscount.Clear();
            txtDiscountAmount.Clear();
            txtPriceAfterDiscount.Clear();
            txtGST.Clear();
            txtSGstAmount.Clear();
            txtCGstAmount.Clear();
        }

        private void txtGST_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPriceAfterDiscount.Text.Length == 0 && txtPrice.Text.Length == 0) return;
                if (txtGST.Text.Length == 0) return;
                var gstAmount = ((Convert.ToDouble(txtPriceAfterDiscount.Text) * Convert.ToDouble(txtGST.Text)) / 100) / 2;
                txtSGstAmount.Text = Math.Round(gstAmount, 2).ToString();
                txtCGstAmount.Text = Math.Round(gstAmount, 2).ToString();
                txtFinalPrice.Text = Math.Round((Convert.ToDouble(txtPriceAfterDiscount.Text) + Convert.ToDouble(gstAmount * 2)), 2).ToString();
            }
            catch { }
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            Bitmap bit = new Bitmap(100, 100);

            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var noOfCount = Convert.ToInt32(txtNoOfPrint.Text);
            int y = 10;
            for (int i = 0; i <= noOfCount; i++)
            {

                e.Graphics.DrawString(txtBarcode.Text, new Font("Fake Receipt", 15, FontStyle.Regular), Brushes.Black, new Point(55, y));
                y += 30;
            }


        }

        private async void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length < 3) return;
            if (cmbCategory.Text == "---Select---" && btnAdd.Text != "Update")
            {
                MessageBox.Show("Please Select Category", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                txtName.Focus();
                return;
            }
            try
            {
                string category = cmbCategory.Text;
                await using var context = new EasyBuyContext();
                var productCount = await Task.Run(() => context.Product.Where(x => x.Catagory == category).CountAsync());
                txtBarcode.Text = txtName.Text.Substring(0, 3) + (productCount + 1).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.Where(x => x.Name.Contains(txtSearchName.Text)).ToListAsync());
                ProductDataGridView.DataSource = products;
                txtSearchName.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }
    }
}
