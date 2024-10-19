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
        }
    }
}
