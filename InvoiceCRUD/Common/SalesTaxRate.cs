using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// Data class for object salesTaxRate
    /// </summary>
    public class SalesTaxRate
    {
        int taxId;
        string taxCode;
        decimal taxRate;

        public int TaxId
        {
            get { return taxId; }
            set { taxId = value; }
        }

        public string TaxCode
        {
            get { return taxCode; }
            set { taxCode = value; }
        }

        public decimal TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }
    }
}
