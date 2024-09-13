using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.EntityFrameworkCore;

namespace EasyBuy.Forms.Employee_Account
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
       
        int check = 0;
        private Int64 _id;
        private async void RefreshData()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var suppliers = await Task.Run(() => context.Employee.ToListAsync());
                EmployeeDataGridView.DataSource = suppliers;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CreateEmployeeAccount_Load(object sender, EventArgs e)
        {
            
            //con = new SqlConnection("Data Source=DESKTOP-SMVQK5B\\SQLEXPRESS;Initial Catalog=Keels_SuperMarket_Database;Integrated Security=True");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_fname.TextLength == 0)
                {
                    MessageBox.Show("Full Name Cannot Be Blank","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txt_uname.Text.Length == 0)
                {
                    MessageBox.Show("User Name Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(check == 1)
                {
                    MessageBox.Show("User Name Allready Taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_password.Text.Trim() != txt_password2.Text.Trim())
                {
                    MessageBox.Show("Enterd Passwords Doesnt Match Please Check Again","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
                else
                {
                    //con.Open();
                    //cmd = new SqlCommand("Insert into Employee_Table values('"+txt_fname.Text+"','"+txt_uname.Text+"','"+txt_password2.Text+"',@a,@b)",con); 
                    //cmd.Parameters.AddWithValue("a", cmd_role.SelectedItem);
                    //MemoryStream memoryStream = new MemoryStream();
                    //pfp_pbox.Image.Save(memoryStream, pfp_pbox.Image.RawFormat);
                    //cmd.Parameters.AddWithValue("b", memoryStream.ToArray());
                    //int i = cmd.ExecuteNonQuery();
                    //con.Close();
                    //if (i == 1)
                    //{
                    //    MessageBox.Show("New Employee Account Created Succesfully","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error Occured Employee Account Cannot Be Created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Please select an image to upload", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_password.Clear();
            txt_password2.Clear();
            txt_uname.Clear();
            cmd_role.SelectedIndex = -1;
            
        }

        private void CheckUserName()
        {
            //using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from Employee_Table where User_Name ='" + txt_uname.Text+"'", con))
            //{
            //    con.Open();
            //    int userCount = (int)sqlCommand.ExecuteScalar();
            //    con.Close();
            //    if (userCount > 0) 
            //    {
            //        check = 1;
            //    }
            //    else
            //    {
            //        check = 0;
            //    }
            //}
        }

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {
            CheckUserName();
        }
    }
}
