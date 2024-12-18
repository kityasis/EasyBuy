﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Collections.Generic;
using EasyBuy.Models;
using EasyBuy.Utility;

namespace EasyBuy.Forms.Cashier
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }
        TextBox SelectedTextBox = null;       
        int slNumber = 1;
        long billCount = 0;        
        public static string mem_id_pass;
        private void Cashier_Load(object sender, EventArgs e)
        {
            lblCashierName.Text = UserInfo.UserName;
            rbtnCash.Checked = true;
            rbtnGuestCustomer.Checked = true;
            txtMobile.Enabled = false;
            txtMemberid.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            txtBillNumber.ReadOnly = true;
            dgvItem.EnableHeadersVisualStyles = false;
            dgvItem.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvItem.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            pnlManualSearch.Visible = false;            
            GenerateBillNumber();
            LoadComboBox();
            txtBarecode.Focus();
        }
        private async void GenerateBillNumber()
        {
            try
            {
                await using var context = new EasyBuyContext();
                billCount = await Task.Run(() => context.Sale.CountAsync());
                billCount += 1;
                txtBillNumber.Text = $"EASYBUY-{billCount}";
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadComboBox()
        {
            cmbProductCategory.Items.Clear();
            try
            {
                await using var context = new EasyBuyContext();
                var categories = await Task.Run(() => context.Product.ToListAsync());
                cmbProductCategory.Items.AddRange(categories.Select(x => x.Catagory).ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void cmbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Models.Product> products;
                await using var context = new EasyBuyContext();
                if (string.IsNullOrEmpty(txtSearch.Text)) products = await Task.Run(() => context.Product.Where(x => x.Catagory.Contains(cmbProductCategory.Text)).ToListAsync());
                else products = await Task.Run(() => context.Product.Where(x => x.Name.Contains(txtSearch.Text) && x.Catagory.Contains(cmbProductCategory.Text)).ToListAsync());
                SearchProductGridView.DataSource = products.Select(x => new { x.Name, x.TotalPriceIncludingGST, x.Quantity });
                SearchProductGridView.Columns[0].Width = 80;
                SearchProductGridView.Columns[1].Width = 67;
                SearchProductGridView.Columns[2].Width = 60;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void searchProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.SearchProductGridView.Rows[e.RowIndex];
                //txtProductName.Text = row.Cells["Name"].Value.ToString();
                //txtProductPrice.Text = row.Cells["TotalPurchaseCostInclGST"].Value.ToString();
                //txtProductQuantity.Text = row.Cells["Quantity"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void slide(Button button)
        {
            panelslide.Height = button.Height;
            panelslide.Top = button.Top;
            panelslide.BackColor = Color.DarkBlue;
        }
        private void btn_newtransaction_Click(object sender, EventArgs e)
        {
            slide(btnNewTransaction);
            Cashier x = new Cashier();
            x.Show();
            this.Hide();
        }
        private void btn_adddiscont_Click(object sender, EventArgs e)
        {
            // slide(btn_adddiscont);
        }
        private async void btn_settlepayments_Click(object sender, EventArgs e)
        {
            await using var context = new EasyBuyContext();
            using var transaction = context.Database.BeginTransaction();
            try
            {

                var sale = new Sale()
                {
                    CustomerType = rbtnGuestCustomer.Checked ? "Guest Customer" : "Nexus Member",
                    Date = DateTime.Now,
                    MemberId = txtMemberid.Text,
                    PaymentType = rbtnCash.Checked ? "Cash" : rbtnUPI.Checked ? "UPI" : "CARD",
                    BillNumber = txtBillNumber.Text,
                    SellerName = lblCashierName.Text,
                    SubTotal = Convert.ToDecimal(lblSubTotal.Text),
                    GrandTotal = Convert.ToDecimal(lblGrandTotal.Text)
                };
                var saleDetails = new List<SaleDetails>();
                await Task.Run(() => context.Sale.AddAsync(sale));
                foreach (DataGridViewRow row in dgvItem.Rows)
                {
                    var saleDetail = new SaleDetails();
                    saleDetail.ProductCode = row.Cells[1].Value.ToString();
                    saleDetail.ProductName = row.Cells[2].Value.ToString();
                    saleDetail.Price = Convert.ToDecimal(row.Cells[3].Value ?? 0);
                    saleDetail.DiscountAmount = Convert.ToDecimal(row.Cells[4].Value ?? 0);
                    saleDetail.SGST = Convert.ToDecimal(row.Cells[5].Value ?? 0);
                    saleDetail.CGST = Convert.ToDecimal(row.Cells[6].Value ?? 0);
                    saleDetail.PriceAfterDiscount = Convert.ToDecimal(row.Cells[7].Value ?? 0);
                    saleDetail.ProductQuantity = Convert.ToInt32(row.Cells[8].Value ?? 0);
                    saleDetail.TotalValueInclGST = Convert.ToDecimal(row.Cells[9].Value ?? 0);
                    saleDetail.SaleId = billCount;
                    saleDetails.Add(saleDetail);
                    var product = await Task.Run(() => context.Product.FirstOrDefaultAsync(x => x.Id == Convert.ToInt64(row.Cells[0].Value)));
                    product.Quantity = product.Quantity - Convert.ToInt32(row.Cells[8].Value ?? 0);
                    await Task.Run(() => context.Product.Update(product));
                }
                await Task.Run(() => context.SaleDetails.AddRangeAsync(saleDetails));
                await context.SaveChangesAsync();
                transaction.Commit();
                slide(btnCancelTransaction);
                printPreviewDialog1.ShowDialog();
                Cashier x = new Cashier();
                x.Show();
                this.Hide();

            }
            catch (Exception)
            {
                transaction.Rollback();
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            slide(btnLogout);
            if (MessageBox.Show("Are You Sure You Want To Log Out", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login x = new Login();
                x.Show();
                this.Hide();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtMobile.Enabled = false;
            txtMemberid.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtMobile.Enabled = true;
            txtMemberid.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
        }
        #region calculater
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn1.Text;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn2.Text;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn3.Text;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn4.Text;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn5.Text;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn6.Text;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn9.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn0.Text;
        }

        private void btn_star_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btnStar.Text;
        }

        private void btn_stroke_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btnMinus.Text;
        }

        private void btn_stroke2_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btnDevide.Text;
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox.Text.Length != 0)
            {
                SelectedTextBox.Text = SelectedTextBox.Text.Remove(SelectedTextBox.Text.Length - 1, 1);
            }

        }
        #endregion
        private void txt_memberid_Click(object sender, EventArgs e)
        {
            SelectedTextBox = sender as TextBox;
        }
        private void txt_mobilenum_Click(object sender, EventArgs e)
        {
            SelectedTextBox = sender as TextBox;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //int dis_pt;
            //try
            //{
            //    dis_pt = Convert.ToInt32(txtDiscunt.Text);
            //    dis = subtotal * dis_pt / 100;
            //    txtDiscountAmount.Text = "Rs. " + dis.ToString();
            //    lblTotalDiscount.Text = dis.ToString();
            //    grandTotal = subtotal - dis;
            //    lblGrandTotal.Text = "Rs " + grandTotal.ToString();
            //}
            //catch
            //{

            //}
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            SelectedTextBox = sender as TextBox;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            decimal totalPrice = 0;
            decimal totalPriceAfterDiscount = 0;
            decimal totalFinalPrice = 0;
            decimal totalCGST = 0;
            decimal totalSGST = 0;
            int totalItem = 0;
            e.Graphics.DrawString("EASY BUY STORE",
                new Font("Fake Receipt", 15, FontStyle.Regular), Brushes.Black, new Point(55, 10));
            e.Graphics.DrawString("-----------------------------------------------------------------",
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, 30));
            e.Graphics.DrawString("Ratnagiri, Jajpur, Odisha-754214",
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, 50));
            e.Graphics.DrawString("GSTIN :  21BEQPJ5769E1ZB",
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, 70));
            e.Graphics.DrawString("Bill No : " + txtBillNumber.Text,
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString("Date : " + DateTime.Now,
               new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, 110));
            e.Graphics.DrawString("TAX INVOICE",
                new Font("Fake Receipt", 8, FontStyle.Regular), Brushes.Black, new Point(80, 140));
            e.Graphics.DrawString("-----------------------------------------------------------------",
                new Font("Fake Receipt", 8, FontStyle.Regular), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("Qty   OurPrice     GST(%)      C/S GST        Total",
                new Font("Fake Receipt", 8, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            e.Graphics.DrawString("-----------------------------------------------------------------",
                 new Font("Fake Receipt", 8, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            //
            int i = 200;
            foreach (DataGridViewRow row in dgvItem.Rows)
            {
                totalPrice += Convert.ToDecimal(row.Cells[2].Value.ToString());
                totalPriceAfterDiscount += Convert.ToDecimal(row.Cells[5].Value.ToString());
                totalFinalPrice += Convert.ToDecimal(row.Cells[11].Value.ToString());
                totalItem += Convert.ToInt32(row.Cells[10].Value);
                totalSGST += Convert.ToDecimal(row.Cells[7].Value);
                totalCGST += Convert.ToDecimal(row.Cells[8].Value);
                i += 20;
                e.Graphics.DrawString($"{row.Cells[1].Value.ToString()}",
               new Font("Fake Receipt", 8, FontStyle.Regular), Brushes.Black, new Point(10, i));
                i += 12;
                e.Graphics.DrawString($" {row.Cells[10].Value.ToString()}    {row.Cells[5].Value.ToString()}           {row.Cells[6].Value.ToString()}        {row.Cells[7].Value.ToString()}{"/"}{row.Cells[8].Value.ToString()}       {row.Cells[11].Value.ToString()}",
               new Font("Fake Receipt", 8, FontStyle.Regular), Brushes.Black, new Point(10, i));
            }
            e.Graphics.DrawString("-----------------------------------------------------------------",
                 new Font("Fake Receipt", 8, FontStyle.Regular), Brushes.Black, new Point(10, i + 20));
            e.Graphics.DrawString($"        {totalPriceAfterDiscount}                     {totalSGST}{"/"}{totalCGST}       {totalFinalPrice} ",
                new Font("Fake Receipt", 8, FontStyle.Bold), Brushes.Black, new Point(10, i + 35));
            e.Graphics.DrawString("-----------------------------------------------------------------",
               new Font("Fake Receipt", 8, FontStyle.Regular), Brushes.Black, new Point(10, i + 50));

            e.Graphics.DrawString("GST RECEIPT SUMMARY",
                new Font("Fake Receipt", 12, FontStyle.Regular), Brushes.Black, new Point(45, i + 70));
            e.Graphics.DrawString("-----------------------------------------------------------------",
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 90));

            e.Graphics.DrawString("Total Taxable Amount : " + lblSubTotal.Text,
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 110));
            e.Graphics.DrawString("Round Off Amount : " + txtRoundOffAmount.Text,
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 130));
            e.Graphics.DrawString("Net Taxable Amount : " + lblGrandTotal.Text,
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 150));
            e.Graphics.DrawString("Tax Amount : " + Math.Round(totalCGST + totalSGST, 2),
               new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 170));
            e.Graphics.DrawString("Total Amount Due : " + totalFinalPrice,
               new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 190));
            e.Graphics.DrawString("Total Item Sold : " + totalItem,
              new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 210));
            e.Graphics.DrawString("Total Amount Saved : " + Math.Round(totalPrice - totalPriceAfterDiscount, 2),
              new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 230));
            e.Graphics.DrawString("-----------------------------------------------------------------",
                new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(10, i + 240));

            e.Graphics.DrawString("THANK YOU VISIT AGAIN",
               new Font("Fake Receipt", 12, FontStyle.Regular), Brushes.Black, new Point(45, i + 260));
            e.Graphics.DrawString("Cashier : " + lblCashierName.Text,
              new Font("Fake Receipt", 12, FontStyle.Regular), Brushes.Black, new Point(10, i + 280));
        }
        private void MemberCheck()
        {
            if (rbtnNexusMember.Checked == true)
            {
                //using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from Member_Tbl where Member_ID like @a AND TPO like @b", con))
                //{
                //    con.Open();
                //    sqlCommand.Parameters.AddWithValue("@a", txt_memberid.Text);
                //    sqlCommand.Parameters.AddWithValue("@b", txt_mobilenum.Text);
                //    int userCount = (int)sqlCommand.ExecuteScalar();
                //    con.Close();
                //    if (userCount > 0)
                //    {
                //        txt_mobilenum.BackColor = Color.LightSeaGreen;
                //        txt_memberid.BackColor = Color.LightSeaGreen;
                //        label15.Text = "Member Found";
                //        btn_membershow.Visible = true;
                //    }
                //    else
                //    {
                //        txt_mobilenum.BackColor = Color.OrangeRed;
                //        txt_memberid.BackColor = Color.OrangeRed;
                //        label15.Text = "Member Not Found";
                //        btn_membershow.Visible = false;
                //    }

                //}
            }

        }
        private void txt_memberid_TextChanged(object sender, EventArgs e)
        {
            MemberCheck();
        }
        private void txt_mobilenum_TextChanged(object sender, EventArgs e)
        {
            MemberCheck();
        }
        private void PointsUpdate()
        {
            //decimal points = 0;
            //points = grandTotal / 300;
            ////con.Open();
            ////cmd = new SqlCommand("Update Member_Tbl set Member_Points = '"+points+"' where Member_ID = '" + txt_memberid.Text + "'", con);
            ////cmd.ExecuteNonQuery();
            ////con.Close();
            //Refresh();

        }
        private void FillTotalValue(decimal amount)
        {
            var totalPrice = Math.Round((Convert.ToDecimal(lblSubTotal.Text) + amount), 2);
            lblSubTotal.Text = totalPrice.ToString();
            lblGrandTotal.Text = totalPrice.ToString();
        }
        private decimal TotalPrice(decimal price, int qty) => price * qty;
        
        private decimal GetPriceAfterDiscount(decimal price, decimal qty) => Math.Round(price * qty, 2);
        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            slide(btnCancelTransaction);
            if (MessageBox.Show("Are You Sure You Want To Cancel The Transaction", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var reopen = new Cashier();
                reopen.ShowDialog();
                Dispose();
            }
        }
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.Where(x => x.Name.Contains(txtSearch.Text)).ToListAsync());
                SearchProductGridView.DataSource = products.Select(x => new { x.Id, x.Name, x.TotalPriceIncludingGST, x.Quantity }).ToList();
                SearchProductGridView.Columns[0].Width = 80;
                SearchProductGridView.Columns[1].Width = 67;
                SearchProductGridView.Columns[2].Width = 60;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMemberShow_Click(object sender, EventArgs e)
        {

        }
        private void dgvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == 12)
            {
                if (MessageBox.Show("Are You Sure You Want To Remove", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var qty = Convert.ToInt32(dgvItem[10, e.RowIndex].Value);
                    if (qty > 1)
                    {
                        dgvItem.Rows[e.RowIndex].Cells[10].Value = qty - 1;
                        var totalAmount = Math.Round(Convert.ToDecimal(dgvItem.Rows[e.RowIndex].Cells[9].Value) * Convert.ToDecimal(dgvItem.Rows[e.RowIndex].Cells[10].Value), 2);
                        dgvItem.Rows[e.RowIndex].Cells[11].Value = totalAmount;
                        RemoveFromTotalValue(totalAmount);
                    }
                    else
                    {
                        dgvItem.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

        }
        private void RemoveFromTotalValue(decimal price)
        {
            var totalPrice = Math.Round((Convert.ToDecimal(lblSubTotal.Text) - price), 2);
            lblSubTotal.Text = totalPrice.ToString();
            lblGrandTotal.Text = totalPrice.ToString();
        }
        private void txtRoundOffAmount_TextChanged(object sender, EventArgs e)
        {
            lblGrandTotal.Text = Math.Round((Convert.ToDecimal(lblSubTotal.Text) - Convert.ToDecimal(txtRoundOffAmount.Text)), 2).ToString();
        }
        private void txtRoundOffAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private async void txtBarecode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    await using var context = new EasyBuyContext();
                    var product = await Task.Run(() => context.Product.Where(x => x.Code == txtBarecode.Text).FirstOrDefault());
                    if (product != null)
                    {
                        foreach (DataGridViewRow row in dgvItem.Rows)
                        {
                            if (Convert.ToInt64(row.Cells[0].Value) == product.Id)
                            {
                                row.Cells[10].Value = (Convert.ToInt32(row.Cells[10].Value) + 1);
                                row.Cells[11].Value = GetPriceAfterDiscount(Convert.ToDecimal(row.Cells[10].Value), Convert.ToDecimal(row.Cells[9].Value));
                                this.FillTotalValue(product.TotalPriceIncludingGST);
                                txtBarecode.Text = "";
                                txtBarecode.Focus();
                                return;
                            }
                        }
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dgvItem);
                        newRow.Cells[0].Value = product.Id;
                        newRow.Cells[1].Value = product.Name;
                        newRow.Cells[2].Value = product.Price;
                        newRow.Cells[3].Value = product.Discount;
                        newRow.Cells[4].Value = product.DiscountAmount;
                        newRow.Cells[5].Value = product.PriceAfterDiscount;
                        newRow.Cells[6].Value = product.GSTPercentage;
                        newRow.Cells[7].Value = product.SGST;
                        newRow.Cells[8].Value = product.CGST;
                        newRow.Cells[9].Value = product.TotalPriceIncludingGST;
                        newRow.Cells[10].Value = 1;
                        newRow.Cells[11].Value = product.TotalPriceIncludingGST;
                        dgvItem.Rows.Add(newRow);
                        this.FillTotalValue(product.TotalPriceIncludingGST);
                        txtBarecode.Text = "";
                        txtBarecode.Focus();
                    }


                }
                catch (Exception) { }
            }

              

        }
    }
}


