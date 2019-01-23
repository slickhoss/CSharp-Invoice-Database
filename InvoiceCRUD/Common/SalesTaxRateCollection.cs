using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Common
{
    /// <summary>
    /// Collection class for object salesTaxRate
    /// </summary>
    public class SalesTaxRateCollection : List<SalesTaxRate>
    {
        //linq statement to read taxRate by code
        public IEnumerable<SalesTaxRate> GetTaxRatesByCode(string code)
                                => this.Where(x => x.TaxCode.ToUpper() == code.ToUpper());
    }
}
