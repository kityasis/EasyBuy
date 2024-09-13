using EasyBuy.Forms;
using EasyBuy.Forms.Product_Items;
using System;
using System.Windows.Forms;

namespace EasyBuy
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void openChildForm(object Form)
        {
            if (this.Panel_ChildForm.Controls.Count > 0)
                this.Panel_ChildForm.Controls.RemoveAt(0);

            Form x = Form as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            this.Panel_ChildForm.Controls.Add(x);
            this.Panel_ChildForm.Tag = x;
            x.Show();

        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
        }

        private void btn_catogories_Click(object sender, EventArgs e)
        {
            openChildForm(new Category());
        }
        private void btn_supplier_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {

        }

        private void btn_nexus_Click(object sender, EventArgs e)
        {
            //showSubMenu(SubPanel_NexusMembers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Log Out", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login x = new Login();
                x.Show();
                this.Hide();
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
