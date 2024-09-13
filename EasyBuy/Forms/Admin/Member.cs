using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBuy.Forms.Nexus
{
    public partial class Member : Form
    {
        private Int64 _id;
        public Member()
        {
            InitializeComponent();
        }
        private async void RefreshData()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var members = await Task.Run(() => context.Member.ToListAsync());
                MemberDataGridView.DataSource = members;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Member_Load(object sender, EventArgs e)
        {

            MemberDataGridView.EnableHeadersVisualStyles = false;
            MemberDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;
            MemberDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MemberDataGridView.DefaultCellStyle.Font = new Font("Consolas", 7, FontStyle.Bold);
            RefreshData();
            AutoNexusMemberID();
        }
        private async void AutoNexusMemberID()
        {
            await using var context = new EasyBuyContext();
            var memberCount = await Task.Run(() => context.Member.CountAsync());
            txtId.Text = "NMEM" + memberCount + 1;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {         
            txtName.Clear();
            txtContactNumber.Clear();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {                
                if (txtName.Text.Length == 0 || txtContactNumber.Text.Length == 0)
                {
                    MessageBox.Show("Details Cannot Be Blanck", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtName.Text.Any(Char.IsDigit))
                {
                    MessageBox.Show("Name Cannot Be Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
                else
                {
                    try
                    {

                        await using var context = new EasyBuyContext();
                        var member = new Models.Member() { Name = txtName.Text, ContactNumber = Convert.ToInt32(txtContactNumber.Text), Points = Convert.ToInt32(lblPoint.Text), MemberId = txtId.Text };
                        if (btnAdd.Text == "Add")
                        {

                            await Task.Run(() => context.Member.Add(member));
                        }
                        else
                        {
                            member.Id = _id;
                            await Task.Run(() => context.Member.Update(member));
                            btnAdd.Text = "Add";

                        }
                        await context.SaveChangesAsync();
                        txtName.Clear();
                        txtContactNumber.Clear();
                        txtContactNumber.Clear();


                    }
                    catch (FormatException) { MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    catch (Exception) { MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    RefreshData();
                    AutoNexusMemberID();
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

        private async void MemberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var id = Convert.ToInt64(MemberDataGridView[0, e.RowIndex].Value);
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            await using var context = new EasyBuyContext();
                            var member = await Task.Run(() => context.Member.FirstOrDefaultAsync(x => x.Id == id));
                            await Task.Run(() => context.Member.Remove(member));
                            await context.SaveChangesAsync();
                            RefreshData();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (e.ColumnIndex == 5)
                {
                    try
                    {
                        await using var context = new EasyBuyContext();
                        var member = await Task.Run(() => context.Member.FirstOrDefaultAsync(x => x.Id == id));
                        txtName.Text = member.Name;
                        txtContactNumber.Text = member.ContactNumber.ToString();
                        lblPoint.Text = member.Points.ToString();
                        this._id = member.Id;
                        btnAdd.Text = "Update";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
