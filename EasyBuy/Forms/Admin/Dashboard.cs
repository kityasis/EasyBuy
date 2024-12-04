using EasyBuy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            cmbCategory.Visible = false;
        }

        private void rbtnPurchase_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomer.Visible = false;
            cmbSupplier.Visible = true;
            cmbCategory.Visible = false;
        }

        private void rbtnStock_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomer.Visible = false;
            cmbSupplier.Visible = false;
            cmbCategory.Visible = true;
        }

        private void rbtnGst_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomer.Visible = false;
            cmbSupplier.Visible = false;
            cmbCategory.Visible = false;
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
                List<Purchase> purchases = new List<Purchase>();
                string supplier = cmbSupplier.Text;
                if (cmbSupplier.SelectedIndex == -1) purchases = await Task.Run(() => context.Purchase.ToListAsync());
                else purchases = await Task.Run(() => context.Purchase.Where(x => x.Supplier.Contains(supplier)).ToListAsync());
                dgvPurchage.DataSource = purchases;
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
                List<SaleDetails> saleDetails = new List<SaleDetails>();
                if (cmbCustomer.SelectedIndex == -1) saleDetails = await Task.Run(() => context.SaleDetails.ToListAsync());
                else saleDetails = await Task.Run(() => context.SaleDetails.ToListAsync());
                dgvSale.DataSource = saleDetails = await Task.Run(() => context.SaleDetails.ToListAsync()); ;
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
                List<Models.Product> products = new List<Models.Product>();
                string category = cmbCategory.Text;
                if (cmbCategory.SelectedIndex == -1) products = await Task.Run(() => context.Product.ToListAsync());
                else products = await Task.Run(() => context.Product.Where(x => x.Catagory.Contains(category)).ToListAsync());
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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (rbtnPurchase.Checked)
            {
                dgvPurchage.SelectAll();
                DataObject dataObj = dgvPurchage.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                ExportToExcel();

            }
            else if (rbtnSale.Checked)
            {
                dgvSale.SelectAll();
                DataObject dataObj = dgvSale.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                ExportToExcel();

            }
            else if (rbtnStock.Checked)
            {
                dgvStock.SelectAll();
                DataObject dataObj = dgvStock.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                ExportToExcel();
            }
            else if (rbtnGst.Checked)
            {
                dgvGST.SelectAll();
                DataObject dataObj = dgvGST.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                ExportToExcel();
            }
        }

        private void ExportToExcel()
        {
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
