using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBuy.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
        private async void LoadProductComboBox()
        {
            cmbProduct.Items.Clear();
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.ToListAsync());
                cmbProduct.Items.AddRange(products.Select(x => x.Name).ToArray());
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
                var suppliers = await Task.Run(() => context.Supplier.ToListAsync());
                cmbSupplier.Items.AddRange(suppliers.Select(x => x.Name).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void LoadCustomerComboBox()
        {
            cmbCustomer.Items.Clear();
            try
            {
                await using var context = new EasyBuyContext();
                var customers = await Task.Run(() => context.Member.ToListAsync());
                cmbCustomer.Items.AddRange(customers.Select(x => x.Name).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadCategoryComboBox();
            LoadCustomerComboBox();
            LoadProductComboBox();
            LoadSupplierComboBox();
            rbtnPurchase.Checked = true;
            cmbCustomer.Visible = false;
            dgvGST.Visible = false;
            dgvPurchage.Visible = false;
            dgvSale.Visible = false;
            dgvStock.Visible = false;
        }

        private void rbtnSale_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomer.Visible = true;
            cmbSupplier.Visible = false;
        }

        private void rbtnPurchase_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomer.Visible = false;
            cmbSupplier.Visible = true;
        }

        private void rbtnStock_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomer.Visible = false;
            cmbSupplier.Visible = false;
        }

        private void rbtnGst_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomer.Visible = false;
            cmbSupplier.Visible = false;
            cmbCategory.Visible = false;
            cmbProduct.Visible = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rbtnPurchase.Checked)
            {
                dgvGST.Visible = false;               
                dgvSale.Visible = false;
                dgvStock.Visible = false;
                PurchaseReport();
            }
            else if (rbtnSale.Checked)
            {
                dgvGST.Visible = false;
                dgvPurchage.Visible = false;               
                dgvStock.Visible = false;
                SaleReport();

            }
            else if (rbtnStock.Checked)
            {
                dgvGST.Visible = false;
                dgvPurchage.Visible = false;
                dgvSale.Visible = false;                
                StockReport();
            }
            else if (rbtnGst.Checked)
            {               
                dgvPurchage.Visible = false;
                dgvSale.Visible = false;
                dgvStock.Visible = false;
                GSTReport();
            }
            else { MessageBox.Show("Please select report"); }

        }
        private async void PurchaseReport()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Purchase.ToListAsync());
                dgvPurchage.DataSource = products;
                dgvPurchage.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void SaleReport()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.SaleDetails.ToListAsync());
                dgvSale.DataSource = products;
                dgvSale.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void StockReport()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Product.ToListAsync());
                dgvStock.DataSource = products;
                dgvStock.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void GSTReport()
        {
            try
            {
                await using var context = new EasyBuyContext();
                var products = await Task.Run(() => context.Sale.ToListAsync());
                dgvGST.DataSource = products;
                dgvGST.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
