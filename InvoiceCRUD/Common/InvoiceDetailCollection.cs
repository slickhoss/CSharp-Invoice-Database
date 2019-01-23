using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Common
{
    /// <summary>
    /// Collection class for invoiceDetail - implements BindingList
    /// </summary>
    public class InvoiceDetailCollection : BindingList<InvoiceDetail>
    {
        //lambda expressions
        decimal count => this.Count;
        decimal subTotal => this.Sum(x => x.SubTotal);
        decimal average => this.Average(x => x.Price);
        decimal maximum => this.Max(x => x.Price);
        decimal minimum => this.Min(x => x.Price);
        SalesTaxRateCollection salesTaxRates;

        public SalesTaxRateCollection SalesTaxesRates
        {
            get { return salesTaxRates; }
            set { salesTaxRates = value; }
        }

        public decimal Gst
        {
            get
            {
                decimal rate = salesTaxRates.GetTaxRatesByCode("gst").Single().TaxRate;
                return (rate / 100) * subTotal;
            }
        }

        public decimal Pst
        {
            get
            {
                decimal rate = salesTaxRates.GetTaxRatesByCode("bcpst").Single().TaxRate;
                decimal pst = 0;
                foreach (InvoiceDetail i in this)
                {
                    if (i.Taxable == true)
                    {
                        pst += (rate / 100) * i.SubTotal;
                    }
                }
                return pst;
            }
        }

        public decimal SubTotal
        {
            get { return subTotal; }
        }

        public decimal GrandTotal
        {
            get { return Gst + Pst + SubTotal; }
        }

        public decimal Average
        {
            get { return average; }
        }

        public decimal Maximum
        {
            get { return maximum; }
        }

        public decimal Minimum
        {
            get { return minimum; }
        }

      
    }
}
