using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
namespace EasyBuy.Forms.Cashier
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }
        TextBox SelectedTextBox = null;
        int dis = 0;
        public static string mem_id_pass;

        private async void SearchProducts2()
        {
            try
            {
                string search = txtSearch.Text;
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.Where(x => x.Name.Contains(search) && x.Catagory.Contains(cmbProductCategory.Text)).ToListAsync());
                searchProductGridView.DataSource = products.Select(x => new { x.Name, x.TotalPurchaseCostInclGST, x.Quantity });
                searchProductGridView.Columns[0].Width = 80;
                searchProductGridView.Columns[1].Width = 67;
                searchProductGridView.Columns[2].Width = 60;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void SearchProducts()
        {
            try
            {
                string search = txtSearch.Text;
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.Where(x => x.Name.Contains(search)).ToListAsync());
                searchProductGridView.DataSource = products.Select(x => new { x.Name, x.TotalPurchaseCostInclGST, x.Quantity }).ToList();
                searchProductGridView.Columns[0].Width = 80;
                searchProductGridView.Columns[1].Width = 67;
                searchProductGridView.Columns[2].Width = 60;
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
                string search = cmbProductCategory.Text;
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.Where(x => x.Catagory.Contains(search)).ToListAsync());
                searchProductGridView.DataSource = products.Select(x => new { x.Name, x.TotalPurchaseCostInclGST, x.Quantity }).ToList();
                searchProductGridView.Columns[0].Width = 80;
                searchProductGridView.Columns[1].Width = 67;
                searchProductGridView.Columns[2].Width = 60;
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
                DataGridViewRow row = this.searchProductGridView.Rows[e.RowIndex];
                txtProductName.Text = row.Cells["Name"].Value.ToString();
                txtProductPrice.Text = row.Cells["TotalPurchaseCostInclGST"].Value.ToString();
                txtProductQuantity.Text = row.Cells["Quantity"].Value.ToString();

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
                //con.Open();
                //cmd = new SqlCommand("SELECT [Prodcut_Quantity] FROM Product_Table WHERE [Product_Name] = '" + txt_productname.Text + "'", con);
                //SqlDataReader reader1 = cmd.ExecuteReader();

                //if (reader1.Read())
                //{
                //    textBox1.Text = reader1["Prodcut_Quantity"].ToString();
                //}
                //con.Close();


                int x_quantity = 13;// Convert.ToInt32(textBox1.Text);


                int y = Convert.ToInt32(txtProductQuantity.Text);

                if (txtProductName.Text.Length == 0 || txtProductPrice.Text.Length == 0)
                {
                    MessageBox.Show("Please Search A Product First To Enter Detials Into The Bill", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtProductQuantity.Text.Any(Char.IsLetter))
                {
                    MessageBox.Show("Product Quantity Must Be In Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (y <= 0)
                {
                    MessageBox.Show("Product Qunatity Must Be Atleast 1 or Higher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (y >= x_quantity)
                {
                    MessageBox.Show("Reached The Maximum Available Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    int total = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView2);
                    newRow.Cells[0].Value = n++;
                    newRow.Cells[1].Value = txtProductName.Text;
                    newRow.Cells[2].Value = txtProductPrice.Text;
                    newRow.Cells[3].Value = txtProductQuantity.Text;
                    newRow.Cells[4].Value = Convert.ToInt32(txtProductPrice.Text) * Convert.ToInt32(txtProductQuantity.Text);
                    dataGridView2.Rows.Add(newRow);
                    xy++;
                    subtotal = subtotal + total;
                    txt_subtotal.Text = subtotal.ToString();
                    grandtotal = subtotal - dis;
                    txt_grandtotal.Text = "Rs " + grandtotal.ToString();
                    textBox2_TextChanged(sender, new EventArgs());

                    int c_ty = Convert.ToInt32(txt_cty.Text);
                    int pty = Convert.ToInt32(txtProductQuantity.Text);


                    txt_newqty.Text = (c_ty - pty).ToString();
                    DataGridViewRow newRow1 = new DataGridViewRow();
                    newRow1.CreateCells(dgv_qtupdate);
                    newRow1.Cells[0].Value = txtProductName.Text;
                    newRow1.Cells[1].Value = txt_newqty.Text;
                    dgv_qtupdate.Rows.Add(newRow1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Searched Product Not Found or Product Quantity Must Be In Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GenBID()
        {
            //con = new SqlConnection("Data Source=DESKTOP-SMVQK5B\\SQLEXPRESS;Initial Catalog=Keels_SuperMarket_Database;Integrated Security=True");
            //con.Open();
            //cmd = new SqlCommand("Select count (Bill_ID) from [Bill_Table]", con);
            //cmd.ExecuteNonQuery();
            //int count = Convert.ToInt32(((SqlCommand)cmd).ExecuteScalar());
            //count++;
            //txt_billid.Text = "BID-" + count.ToString();
            //con.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
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
            slide(btn_newtransaction);
            //showSubMenu(Panel_Bill);

            //var reopen = new Cashier();
            //reopen.ShowDialog();
            //Dispose();
            Cashier x = new Cashier();
            x.Show();
            this.Hide();

        }

        private void btn_searchproduct_Click(object sender, EventArgs e)
        {
            // slide(btn_searchproduct);
            // showSubMenu(SubMenu_Search);
        }

        private void btn_adddiscont_Click(object sender, EventArgs e)
        {
            // slide(btn_adddiscont);
        }

        private void btn_settlepayments_Click(object sender, EventArgs e)
        {
            slide(btn_settlepayments);
            OutPutBill();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            slide(btn_logout);
            if (MessageBox.Show("Are You Sure You Want To Log Out", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login x = new Login();
                x.Show();
                this.Hide();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_mobilenum.Enabled = false;
            txt_memberid.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_mobilenum.Enabled = true;
            txt_memberid.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            txt_mobilenum.Enabled = false;
            txt_memberid.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            txt_billid.ReadOnly = true;
            GenBID();
            LoadComboBox();
            this.radioButton1.Checked = true;

            if (cmbProductCategory.SelectedIndex == -1)
            {
                SearchProducts();
            }
            else
            {
                SearchProducts2();
            }
            us.Text = Login.UserName;
            us.Visible = false;
            // LoadAccDetails();

            LoadPFP();
            //con = new SqlConnection("Data Source=DESKTOP-SMVQK5B\\SQLEXPRESS;Initial Catalog=Keels_SuperMarket_Database;Integrated Security=True");

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            txtProductName.ReadOnly = true;
            txtProductPrice.ReadOnly = true;
            datelb.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }



        private void btn_canceltransaction_Click(object sender, EventArgs e)
        {

            slide(btn_canceltransaction);
            if (MessageBox.Show("Are You Sure You Want To Cancel The Transaction", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var reopen = new Cashier();
                reopen.ShowDialog();
                Dispose();
            }
        }
        int n = 1; int subtotal = 0; int xy = 0; int grandtotal = 0;



        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Today.Date;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtSearch.Clear();
            txtProductQuantity.Clear();
            cmbProductCategory.Items.Clear();
            txtProductQuantity.Text = "0";
            txtProductPrice.Clear();
            searchProductGridView.DataSource = null;
            searchProductGridView.Refresh();
            cmbProductCategory.ResetText();
            LoadComboBox();
        }



        
        private void OutPutBill()
        {
            try
            {
                //if (radioButton1.Checked == false && radioButton1.Checked == false)
                {
                    //MessageBox.Show("Please Select A Customer Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (subtotal == 0)
                {
                    MessageBox.Show("No Product Is Listed To Purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioButton1.Checked == true)
                {
                    //con.Open();
                    //cmd = new SqlCommand("Insert Into Bill_Table values ('" + txt_billid.Text + "','" + DateTime.Today + "','" + CashierName.Text + "','Guest','None','" +grandtotal + "')", con);
                    //int i = cmd.ExecuteNonQuery();
                    //con.Close();
                    //if (i == 1)
                    //{
                    //    MessageBox.Show("Transaction " + txt_billid.Text + " Completed Succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    UpdateQTY();
                    //    PrintBill();
                    //    var reopen = new Cashier();
                    //    reopen.ShowDialog();
                    //    Dispose();

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Transaction Failed Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                }
                else if (label15.Text != "Member Found" && radioButton2.Checked == true)
                {
                    MessageBox.Show("Member Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (label15.Text == "Member Found" && radioButton2.Checked == true)
                {
                    //con.Open();
                    //cmd = new SqlCommand("Insert Into Bill_Table values ('" + txt_billid.Text + "','" + DateTime.Today + "','" + CashierName.Text + "','Member','" + txt_memberid.Text + "','" + Convert.ToInt32(txt_subtotal.Text) + "')", con);
                    //int i = cmd.ExecuteNonQuery();
                    //con.Close();
                    //if (i == 1)
                    //{
                    //    MessageBox.Show("Transaction " + txt_billid.Text + " Completed Succesfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    PointsUpdate();
                    //    UpdateQTY();
                    //    PrintBill();
                    //    var reopen = new Cashier();
                    //    reopen.ShowDialog();
                    //    Dispose();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Transaction Failed Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Transaction Failed Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAccDetails()
        {
            //con.Open();
            //cmd = new SqlCommand("Select Full_Name from Employee_Table where User_Name='" + us.Text + "'", con);
            //SqlDataReader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    CashierName.Text = reader["Full_Name"].ToString();
            //}
            //con.Close();
        }

        private void LoadPFP()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox1.DisplayRectangle);
            pictureBox1.Region = new Region(gp);

            //con.Open();
            //cmd = new SqlCommand("Select Full_Name,Image from Employee_Table where User_Name='" + us.Text + "'", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();

            //if (dr.HasRows)
            //{
            //    CashierName.Text = dr["Full_Name"].ToString();
            //    byte[] Images = (byte[])dr[1];

            //    if (Images == null)
            //    {
            //        pictureBox1.Image = null;
            //    }
            //    else
            //    {
            //        MemoryStream memoryStream = new MemoryStream(Images);
            //        pictureBox1.Image = Image.FromStream(memoryStream);
            //    }
            //}
            //con.Close();

        }

        private void SubMenu_BillDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_productquantity_Click(object sender, EventArgs e)
        {
            SelectedTextBox = sender as TextBox;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn_1.Text;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn_2.Text;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn_3.Text;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn_4.Text;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn_5.Text;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox != null)
            {
                SelectedTextBox.Text = SelectedTextBox.Text + btn_6.Text;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn_9.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn_0.Text;
        }

        private void btn_star_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn_star.Text;
        }

        private void btn_stroke_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn_stroke.Text;
        }

        private void btn_stroke2_Click(object sender, EventArgs e)
        {
            SelectedTextBox.Text = SelectedTextBox.Text + btn_stroke2.Text;
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (SelectedTextBox.Text.Length != 0)
            {
                SelectedTextBox.Text = SelectedTextBox.Text.Remove(SelectedTextBox.Text.Length - 1, 1);
            }

        }

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
                txt_discount2.Text = dis.ToString();
                grandtotal = subtotal - dis;
                txt_grandtotal.Text = "Rs " + grandtotal.ToString();
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
            e.Graphics.DrawString("Keels-Super", new Font("Fake Receipt", 20, FontStyle.Regular), Brushes.Black, new Point(285, 20));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(30, 80));
            e.Graphics.DrawString("NO. 968 , Mahabage Road , Ragama", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(50, 110));
            e.Graphics.DrawString("Date - " + DateTime.Now, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(50, 140));
            e.Graphics.DrawString("Bill ID - " + txt_billid.Text + "                                       " + "Cashier Name -" + CashierName.Text, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(50, 170));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(30, 200));
            e.Graphics.DrawImage(bit, 30, 230);
            e.Graphics.DrawString("Grand Total - Rs" + grandtotal, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(650, 240));
            e.Graphics.DrawString("_________________________________", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(630, 250));
            e.Graphics.DrawString("Subtotal - Rs" + subtotal, new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(650, 270));
            e.Graphics.DrawString("Discount - Rs" + dis + "(" + txtDiscunt.Text + "%)", new Font("Fake Receipt", 10, FontStyle.Regular), Brushes.Black, new Point(650, 290));

        }
        Bitmap bit;
        private void PrintBill()
        {

            int h = dataGridView2.Height;
            dataGridView2.Height = dataGridView2.RowCount * dataGridView2.RowTemplate.Height * 2;
            bit = new Bitmap(dataGridView2.Width, dataGridView2.Height);
            dataGridView2.DrawToBitmap(bit, new Rectangle(0, 0, dataGridView2.Width, dataGridView2.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView2.Height = h;
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
            int points = 0;
            points = grandtotal / 300;
            //con.Open();
            //cmd = new SqlCommand("Update Member_Tbl set Member_Points = '"+points+"' where Member_ID = '" + txt_memberid.Text + "'", con);
            //cmd.ExecuteNonQuery();
            //con.Close();
            Refresh();

        }

        private void btn_membershow_Click(object sender, EventArgs e)
        {
            mem_id_pass = txt_memberid.Text;
            //ShowMember x = new ShowMember();
            //x.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            slide(button4);
            //Cashier_memreg x = new Cashier_memreg();
            //x.Show();   
        }

       
    }
}


