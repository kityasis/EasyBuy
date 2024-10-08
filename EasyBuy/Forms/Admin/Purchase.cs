﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace EasyBuy.Forms.Product_Items
{
    public partial class Purchase : Form
    {
        private Int64 _id;
        public Purchase()
        {
            InitializeComponent();
        }
        private void Product_Load(object sender, EventArgs e)
        {
            PurchaseDataGridView.EnableHeadersVisualStyles = false;
            PurchaseDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            PurchaseDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            PurchaseDataGridView.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);

            RefreshData();
            LoadCategoryComboBox();
            LoadSupplierComboBox();
        }
        private async void RefreshData()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var purchases = await Task.Run(() => context.Purchase.ToListAsync());
                PurchaseDataGridView.DataSource = purchases;
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
            else if (txtSGstAmount.Text.Length == 0) MessageBox.Show("Product Gst Amount Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtFinalPrice.Text.Length == 0) MessageBox.Show("Product Final Price Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                try
                {
                    await using var context = new EasyBuyContext();
                    var purchase = new Models.Purchase()
                    {                      
                        Supplier = cmbSupplier.Text,
                        Catagory = cmbCategory.Text,
                        Name = txtName.Text.Trim(),
                        BasePrice = Convert.ToDecimal(txtPrice.Text),
                        Quantity = Convert.ToInt32(txtQunatity.Text),
                        TotalBaseBuyPrice = Convert.ToDecimal(txtTotalPrice.Text),
                        DiscountOnBaseBuyPrice = Convert.ToDecimal(txtDiscount.Text),
                        TotalPurchaseDiscountAmount = Convert.ToDecimal(txtDiscountAmount.Text),
                        TotalBaseBuyPriceAfterDiscount = Convert.ToDecimal(txtTotalPriceAfterDiscount.Text),
                        InputGSTPercentage = Convert.ToDecimal(txtGST.Text),
                        InputSGSTAmount = Convert.ToDecimal(txtSGstAmount.Text),
                        InputCGSTAmount = Convert.ToDecimal(txtCGstAmount.Text),
                        TotalPurchaseCostInclGST = Convert.ToDecimal(txtFinalPrice.Text)

                    };
                    if (btnAdd.Text == "Add")
                    {

                        await Task.Run(() => context.Purchase.Add(purchase));
                    }
                    else
                    {
                        purchase.Id = _id;
                        await Task.Run(() => context.Purchase.Update(purchase));
                        btnAdd.Text = "Add";

                    }
                    
                    await context.SaveChangesAsync();
                    this.Clear();
                }
                catch (FormatException)
                {

                    MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception)

                {
                    MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                RefreshData();

            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Clear();

        }
        private void Clear()
        {
            txtName.Clear();       
            txtPrice.Clear();
            txtQunatity.Clear();
            txtTotalPrice.Clear();
            txtDiscount.Clear();
            txtDiscountAmount.Clear();
            txtTotalPriceAfterDiscount.Clear();
            txtGST.Clear();
            txtSGstAmount.Clear();
            txtCGstAmount.Clear();
            txtFinalPrice.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
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
            txtDiscountAmount.Text = Math.Round(((Convert.ToDouble(txtTotalPrice.Text) * Convert.ToDouble(txtDiscount.Text)) / 100), 2).ToString();
            txtTotalPriceAfterDiscount.Text = Math.Round((Convert.ToDouble(txtTotalPrice.Text) - Convert.ToDouble(txtDiscountAmount.Text)), 2).ToString();
        }

        private void txtGST_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPriceAfterDiscount.Text.Length == 0 && txtTotalPrice.Text.Length == 0) return;
            if (txtGST.Text.Length == 0) return;
            var price = string.IsNullOrEmpty(txtTotalPriceAfterDiscount.Text) ? txtTotalPrice.Text : txtTotalPriceAfterDiscount.Text;
            var gstAmount = ((Convert.ToDouble(price) * Convert.ToDouble(txtGST.Text)) / 100) / 2;
            txtSGstAmount.Text =Math.Round(gstAmount,2).ToString();
            txtCGstAmount.Text = Math.Round(gstAmount, 2).ToString();
            txtFinalPrice.Text = Math.Round((Convert.ToDouble(price) + Convert.ToDouble(txtSGstAmount.Text)), 2).ToString();
        }

        private async void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var id = Convert.ToInt64(PurchaseDataGridView[0, e.RowIndex].Value);
                if (e.ColumnIndex == 15)
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            await using var context = new EasyBuyContext();
                            var purchase = await Task.Run(() => context.Purchase.FirstOrDefaultAsync(x => x.Id == id));
                            await Task.Run(() => context.Purchase.Remove(purchase));
                            await context.SaveChangesAsync();                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == 14)
                {
                    try
                    {
                        await using var context = new EasyBuyContext();
                        var product = await Task.Run(() => context.Purchase.FirstOrDefaultAsync(x => x.Id == id));
                        txtName.Text= product.Name;                       
                        txtPrice.Text= product.BasePrice.ToString();
                        txtQunatity.Text= product.Quantity.ToString();
                        txtTotalPrice.Text= product.TotalBaseBuyPrice.ToString();
                        txtDiscount.Text= product.DiscountOnBaseBuyPrice.ToString(); 
                        txtDiscountAmount.Text= product.TotalPurchaseDiscountAmount.ToString();
                        txtTotalPriceAfterDiscount.Text= product.TotalBaseBuyPriceAfterDiscount.ToString();
                        txtGST.Text= product.InputGSTPercentage.ToString();
                        txtSGstAmount.Text= product.InputSGSTAmount.ToString();
                        txtCGstAmount.Text = product.InputCGSTAmount.ToString();
                        txtFinalPrice.Text= product.TotalPurchaseCostInclGST.ToString()    ;
                        cmbCategory.Text = product.Catagory;
                        cmbSupplier.Text = product.Supplier;
                        this._id = product.Id;
                        btnAdd.Text = "Update";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                RefreshData();
            }
        }
    }
}
