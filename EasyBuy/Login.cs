using EasyBuy.Forms.Cashier;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using EasyBuy.Utility;

namespace EasyBuy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }             
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {          
               
                {
                    if (txt_password.Text.Length == 0 || txt_username.Text.Length == 0)
                    {
                        MessageBox.Show("User Name or Password Cannot Be Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (comboBox1.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please Select A Role To Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (comboBox1.SelectedIndex >= 0) // Admin Form
                    {
                        string userName = txt_username.Text;
                        string password = txt_password.Text;
                        string role = comboBox1.SelectedItem.ToString();
                        await using var context = new EasyBuyContext();
                        var employee = await Task.Run(() => context.Employee.FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password && x.Role ==role));
                        if (employee !=null)
                        {
                            UserInfo.UserName = userName;
                            if (comboBox1.SelectedIndex == 0)
                            {                                
                                Home home = new Home();
                                home.Show();
                            }
                            else
                            {
                                Cashier x = new Cashier();
                                x.Show();
                            }                            
                            this.Hide();

                        }                        
                        else
                        {
                            MessageBox.Show("User Name , Password OR Selected Role Is Incorrect Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                    }
                    else
                    {
                        MessageBox.Show("Login Error Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.InnerException.ToString());
            }            
           
        }        
    }
}
