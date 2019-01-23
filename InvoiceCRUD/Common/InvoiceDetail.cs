using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class InvoiceDetail
    {
        int detailId;
        int quantity;
        string sku;
        string description;
        decimal price;
        bool taxable;


        public int DetailId
        {
            get { return detailId; }
            set { detailId = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Sku
        {
            get { return sku; }
            set { sku = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool Taxable
        {
            get { return taxable; }
            set { taxable = value; }
        }

        public decimal SubTotal
        {
            get { return quantity * price; }
        }
    }
}
