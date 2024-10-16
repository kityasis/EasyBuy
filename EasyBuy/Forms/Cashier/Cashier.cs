using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Collections.Generic;
using EasyBuy.Models;
using System.Xml.Linq;

namespace EasyBuy.Forms.Cashier
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }
        TextBox SelectedTextBox = null;
        decimal dis = 0;
        int slNumber = 1;
        decimal subtotal = 0;
        decimal grandTotal = 0;
        Bitmap bit;
        public static string mem_id_pass;
        private void Cashier_Load(object sender, EventArgs e)
        {
            txtMobile.Enabled = false;
            txtMemberid.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            txtBillNumber.ReadOnly = true;
            this.radioButton1.Checked = true;
            dgvItem.EnableHeadersVisualStyles = false;
            dgvItem.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgvItem.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            pnlManualSearch.Visible = false;
            GenerateBillNumber();
            LoadComboBox();
        }
        private async void GenerateBillNumber()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var billCount = await Task.Run(() => context.Bill.CountAsync());
                txtBillNumber.Text = "EASYBUY-" + (billCount + 1);
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
                List<Product> products;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {



                //int x_quantity = 13;// Convert.ToInt32(textBox1.Text);


                //int y = Convert.ToInt32(txtProductQuantity.Text);

                //if (txtProductName.Text.Length == 0 || txtProductPrice.Text.Length == 0)
                //{
                //    MessageBox.Show("Please Search A Product First To Enter Detials Into The Bill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else if (txtProductQuantity.Text.Any(Char.IsLetter))
                //{
                //    MessageBox.Show("Product Quantity Must Be In Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else if (y <= 0)
                //{
                //    MessageBox.Show("Product Qunatity Must Be Atleast 1 or Higher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else if (y >= x_quantity)
                //{
                //    MessageBox.Show("Reached The Maximum Available Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{

                //    int total = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                //    DataGridViewRow newRow = new DataGridViewRow();
                //    newRow.CreateCells(dataGridView2);
                //    newRow.Cells[0].Value = n++;
                //    newRow.Cells[1].Value = txtProductName.Text;
                //    newRow.Cells[2].Value = txtProductPrice.Text;
                //    newRow.Cells[3].Value = txtProductQuantity.Text;
                //    newRow.Cells[4].Value = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                //    dataGridView2.Rows.Add(newRow);
                //    xy++;
                //    subtotal = subtotal + total;
                //    txt_subtotal.Text = subtotal.ToString();
                //    grandtotal = subtotal - dis;
                //    txt_grandtotal.Text = "Rs " + grandtotal.ToString();
                //    textBox2_TextChanged(sender, new EventArgs());
                //    int c_ty = Convert.ToInt32(txt_cty.Text);
                //    int pty = Convert.ToInt32(txtProductQuantity.Text);
                //    txt_newqty.Text = (c_ty - pty).ToString();
                //    DataGridViewRow newRow1 = new DataGridViewRow();
                //    newRow1.CreateCells(dgv_qtupdate);
                //    newRow1.Cells[0].Value = txtProductName.Text;
                //    newRow1.Cells[1].Value = txt_newqty.Text;
                //    dgv_qtupdate.Rows.Add(newRow1);
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Searched Product Not Found or Product Quantity Must Be In Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
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
            //showSubMenu(Panel_Bill);

            //var reopen = new Cashier();
            //reopen.ShowDialog();
            //Dispose();
            Cashier x = new Cashier();
            x.Show();
            this.Hide();

        }
        private void btn_adddiscont_Click(object sender, EventArgs e)
        {
            // slide(btn_adddiscont);
        }
        private void btn_settlepayments_Click(object sender, EventArgs e)
        {
            PrintBill();
            //slide(btn_settlepayments);
            //OutPutBill();
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
            int dis_pt;
            try
            {
                dis_pt = Convert.ToInt32(txtDiscunt.Text);
                dis = subtotal * dis_pt / 100;
                txtDiscountAmount.Text = "Rs. " + dis.ToString();
                lblTotalDiscount.Text = dis.ToString();
                grandTotal = subtotal - dis;
                lblGrandTotal.Text = "Rs " + grandTotal.ToString();
            }
            catch
            {

            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            SelectedTextBox = sender as TextBox;
        }
        private void UpdateQTY()
        {
            for (int x = 0; x < dgv_qtupdate.Rows.Count - 1; x++)
            {
                //con.Open();
                //cmd = new SqlCommand("Update Product_Table set Prodcut_Quantity =@qty where Product_Name=@name", con);

                //cmd.Parameters.AddWithValue("name", dgv_qtupdate.Rows[x].Cells[0].Value);
                //cmd.Parameters.AddWithValue("qty", dgv_qtupdate.Rows[x].Cells[1].Value);
                //cmd.ExecuteNonQuery();
                //con.Close();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Easy Bye", new Font("Fake Receipt", 20, FontStyle.Regular), Brushes.Black, new Point(285, 20));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(30, 80));
            e.Graphics.DrawString("NO. 968 , Mahabage Road , Ragama", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(50, 110));
            e.Graphics.DrawString("Date - " + DateTime.Now, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(50, 140));
            e.Graphics.DrawString("Bill ID - " + txtBillNumber.Text + "                                       " + "Cashier Name -" + lblCashierName.Text, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(50, 170));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(30, 200));
            e.Graphics.DrawImage(bit, 30, 230);
            e.Graphics.DrawString("Grand Total - Rs" + grandTotal, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(650, 240));
            e.Graphics.DrawString("_________________________________", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(630, 250));
            e.Graphics.DrawString("Subtotal - Rs" + subtotal, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(650, 270));
            e.Graphics.DrawString("Discount - Rs" + dis + "(" + txtDiscunt.Text + "%)", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(650, 290));

        }
        private void PrintBill()
        {

            int h = dgvItem.Height;
            dgvItem.Height = dgvItem.RowCount * dgvItem.RowTemplate.Height * 2;
            bit = new Bitmap(dgvItem.Width, dgvItem.Height);
            dgvItem.DrawToBitmap(bit, new Rectangle(0, 0, dgvItem.Width, dgvItem.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dgvItem.Height = h;
        }
        private void MemberCheck()
        {
            if (radioButton2.Checked == true)
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
            decimal points = 0;
            points = grandTotal / 300;
            //con.Open();
            //cmd = new SqlCommand("Update Member_Tbl set Member_Points = '"+points+"' where Member_ID = '" + txt_memberid.Text + "'", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            Refresh();

        }
        private void FillTotalValue(decimal price, decimal discount)
        {
            var totalPrice = Math.Round((Convert.ToDecimal(lblSubTotal.Text) + price), 2);
            var totalDiscount = Math.Round((Convert.ToDecimal(lblTotalDiscount.Text) + discount), 2);
            var grandTotal = totalPrice - totalDiscount;
            lblSubTotal.Text = totalPrice.ToString();
            lblTotalDiscount.Text = totalDiscount.ToString();
            lblGrandTotal.Text = grandTotal.ToString();
        }
        private decimal TotalPrice(decimal price, int qty) => price * qty;
        private async void txtBarecode_TextChanged(object sender, EventArgs e)
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
                            row.Cells[8].Value = (Convert.ToInt32(row.Cells[8].Value) + 1);
                            row.Cells[9].Value = Math.Round(Convert.ToDecimal(row.Cells[7].Value) * Convert.ToDecimal(row.Cells[8].Value), 2);
                            this.FillTotalValue(product.PriceAfterDiscount, product.Discount);
                            return;
                        }
                    }
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgvItem);
                    newRow.Cells[0].Value = product.Id;
                    newRow.Cells[1].Value = slNumber++;
                    newRow.Cells[2].Value = product.Name;
                    newRow.Cells[3].Value = product.Price;
                    newRow.Cells[4].Value = product.DiscountAmount;
                    newRow.Cells[5].Value = product.SGST;
                    newRow.Cells[6].Value = product.CGST;
                    newRow.Cells[7].Value = product.PriceAfterDiscount;
                    newRow.Cells[8].Value = 1;
                    newRow.Cells[9].Value = Math.Round(Convert.ToDecimal(product.PriceAfterDiscount) * Convert.ToDecimal(product.Quantity), 2);
                    dgvItem.Rows.Add(newRow);
                    this.FillTotalValue(product.PriceAfterDiscount, product.Discount);
                }


            }
            catch (Exception) { }          
            
        }
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
            if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("Are You Sure You Want To Remove", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var qty = Convert.ToInt32(dgvItem[8, e.RowIndex].Value);
                    if (qty > 1)
                    {
                        dgvItem.Rows[e.RowIndex].Cells[8].Value = qty - 1;
                        var totalAmount= Math.Round(Convert.ToDecimal(dgvItem.Rows[e.RowIndex].Cells[7].Value) * Convert.ToDecimal(dgvItem.Rows[e.RowIndex].Cells[8].Value));
                        dgvItem.Rows[e.RowIndex].Cells[9].Value = totalAmount;
                        RemoveFromTotalValue(totalAmount, Convert.ToDecimal(dgvItem.Rows[e.RowIndex].Cells[5].Value));
                    }
                    else
                    {
                        dgvItem.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

        }
        private void RemoveFromTotalValue(decimal price, decimal discount)
        {
            var totalPrice = Math.Round((Convert.ToDecimal(lblSubTotal.Text) - price), 2);
            var totalDiscount = Math.Round((Convert.ToDecimal(lblTotalDiscount.Text) - discount), 2);
            var grandTotal = totalPrice - totalDiscount;
            lblSubTotal.Text = totalPrice.ToString();
            lblTotalDiscount.Text = totalDiscount.ToString();
            lblGrandTotal.Text = grandTotal.ToString();
        }
    }
}


