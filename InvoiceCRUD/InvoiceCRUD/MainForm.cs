using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Business;
using Common;
using Repository;

namespace InvoiceCRUD
{
    public partial class MainForm : Form
    {
        InvoiceDetailViewModel invoiceDetailVM;
        ErrorProvider errorProvider;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            infoLabel.Text = string.Format($"Sub Total :\nGST :\nPST :\nGrand Total :\n\n\n\nAverage :\nMaximum :\nMinimum :");
            legendLabel.Text = null;
            invoiceDetailVM = new InvoiceDetailViewModel();
            invoiceDetailVM.InvoiceDetails = InvoiceCRUDRepository.GetInvoiceDetails();
            errorProvider = new ErrorProvider();
            set_Bindings();
        }

        private void loadDataGridView()
        {
            invoiceDetailVM.InvoiceDetails = InvoiceCRUDRepository.GetInvoiceDetails();
            invoiceDetailListBox.DataSource = invoiceDetailVM.InvoiceDetails;
            invoiceDetailListBox.DisplayMember = "Sku";
        }



        private void set_Bindings()
        {
            invoiceIdTextBox.DataBindings.Add("Text", invoiceDetailVM, "DetailId");
            quantityTextBox.DataBindings.Add("Text", invoiceDetailVM, "Quantity");
            skuTextBox.DataBindings.Add("Text", invoiceDetailVM, "Sku", false, DataSourceUpdateMode.OnValidation, "");
            descriptionTextBox.DataBindings.Add("Text", invoiceDetailVM, "Description");
            priceTextBox.DataBindings.Add("Text", invoiceDetailVM, "Price", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            taxableCheckBox.DataBindings.Add("Checked", invoiceDetailVM, "Taxable");
            extendedTextBox.DataBindings.Add("Text", invoiceDetailVM, "SubTotal");

            invoiceDetailListBox.DataSource = invoiceDetailVM.InvoiceDetails;
            invoiceDetailListBox.DisplayMember = "Sku";
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {

                InvoiceDetail invoiceDetail = new InvoiceDetail { DetailId = Int16.Parse(invoiceIdTextBox.Text), Quantity = Int16.Parse(quantityTextBox.Text), Sku = skuTextBox.Text, Description = descriptionTextBox.Text, Price = Decimal.Parse(priceTextBox.Text), Taxable = taxableCheckBox.Checked };
                int result = 0;
                if (Int16.Parse(invoiceIdTextBox.Text) == 0)
                {
                    // int index = invoiceDetailListBox.SelectedIndex;
                    // InvoiceDetail invoiceDetail = invoiceDetailVM.InvoiceDetails[index];
                    result = Validator.CreateInvoiceDetail(invoiceDetail);
                    if (result > 0)
                    {
                        invoiceDetailVM.InvoiceDetails = InvoiceCRUDRepository.GetInvoiceDetails();
                        invoiceDetailListBox.DataSource = invoiceDetailVM.InvoiceDetails;
                    }
                    if (result < 0)
                    {
                        errorProvider.SetIconAlignment(saveButton, ErrorIconAlignment.MiddleLeft);
                        errorProvider.SetError(saveButton, Validator.GetMessages);
                        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    }
                }
                else
                {
                    result = Validator.UpdateInvoiceDetail(invoiceDetail);
                    if (result > 0)
                    {
                        invoiceDetailVM.InvoiceDetails = InvoiceCRUDRepository.GetInvoiceDetails();
                        invoiceDetailListBox.DataSource = invoiceDetailVM.InvoiceDetails;
                    }
                    if (result < 0)
                    {
                        errorProvider.SetIconAlignment(saveButton, ErrorIconAlignment.MiddleLeft);
                        errorProvider.SetError(saveButton, Validator.GetMessages);
                        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    }
                }



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {     
            InvoiceDetail invoiceDetail = new InvoiceDetail();
            invoiceDetailVM.DisplayInvoiceDetail(invoiceDetail);
            invoiceIdTextBox.Clear();
        }

        private void invoiceDetailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = invoiceDetailListBox.SelectedIndex;
            InvoiceDetail invoiceDetail = invoiceDetailVM.InvoiceDetails[index];
            invoiceDetailVM.DisplayInvoiceDetail(invoiceDetail);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = invoiceDetailListBox.SelectedIndex;
                int result = 0;
                InvoiceDetail invoiceDetail = new InvoiceDetail { DetailId = Int16.Parse(invoiceIdTextBox.Text) };
                result = InvoiceCRUDRepository.DeleteInvoice(invoiceDetail);
                if (result > 0)
                {
                    invoiceDetailVM.InvoiceDetails = InvoiceCRUDRepository.GetInvoiceDetails();
                    invoiceDetailListBox.DataSource = invoiceDetailVM.InvoiceDetails;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
