using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Common;


namespace InvoiceCRUD
{
    /// <summary>
    /// View Model Class for object InvoiceDetail - implements INotifyPropertyChanged
    /// </summary>
    class InvoiceDetailViewModel : INotifyPropertyChanged
    {
        //INotifyPropertyChaned implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        InvoiceDetailCollection invoiceDetails;
        string detailId; //stores detailId as a string for nullables
        int quantity;
        string sku;
        string description;
        decimal price;
        bool taxable;

        public InvoiceDetailCollection InvoiceDetails
        {
            get { return invoiceDetails; }
            set { invoiceDetails = value; }
        }

        public string DetailId
        {
            get { return detailId; }
            set {
                    detailId = value;
                    OnPropertyChanged();
                }
        }

        public int Quantity
        {
            get { return quantity; }
            set {
                 quantity = value;
                 OnPropertyChanged();
                }
        }

        public string Sku
        {
            get { return sku; }
            set {
                 sku = value;
                 OnPropertyChanged();
                }
        }

        public string Description
        {
            get { return description; }
            set {
                 description = value;
                 OnPropertyChanged();
                }
        }

        public decimal Price
        {
            get { return price; }
            set {
                price = value;
                OnPropertyChanged();
                }
        }

        public bool Taxable
        {
            get { return taxable; }
            set
            {
                taxable = value;
                OnPropertyChanged();
            }
        }

        public decimal SubTotal
        {
            get { return quantity * price; }
        }

        //param an invoice detail object to display
        public void DisplayInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            if (invoiceDetail.DetailId != 0)
            {
                this.DetailId = invoiceDetail.DetailId.ToString();
            }
            else
            {
                this.DetailId = null;
            }
            this.Quantity = invoiceDetail.Quantity;
            this.Sku = invoiceDetail.Sku;
            this.Description = invoiceDetail.Description;
            this.Price = invoiceDetail.Price;
            this.Taxable = invoiceDetail.Taxable;
        }
        //save/update the invoiceDetail at the selected index w/ the current viewModel object
        public InvoiceDetail SaveInvoiceDetail(int index)
        {
            this.InvoiceDetails[index].DetailId = Int16.Parse(this.DetailId);
            this.InvoiceDetails[index].Quantity = this.Quantity;
            this.InvoiceDetails[index].Sku = this.Sku;
            this.InvoiceDetails[index].Description = this.Description;
            this.InvoiceDetails[index].Price = this.Price;
            this.InvoiceDetails[index].Taxable = this.Taxable;
            return this.InvoiceDetails[index];
        }


    }
}
