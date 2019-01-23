using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Common
{
    public class SalesTaxRateCollection : BindingList<SalesTaxRate>
    {
        public IEnumerable<SalesTaxRate> GetTaxRatesByCode(string code)
                                => this.Where(x => x.TaxCode.ToUpper() == code.ToUpper());
    }
}
