using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Common;
using Repository;

namespace Business
{
    public static class Validator
    {
        static string skuRegex = @"^[A-Z]{3}[0-9]{4}";

        private static List<String> errorMessages;
        static Validator()
        {
            errorMessages = new List<String>();
        }

        public static String GetMessages
        {
            get
            {
                string result = null;
                foreach (string s in errorMessages)
                {
                    result += s + "\n";
                }
                errorMessages.Clear();
                return result;
            }
        }

        //enforces  quantity > 0
        //          sku is a string [AAA][1234]
        //          price > 0
        //
        private static bool Validate(InvoiceDetail invoiceDetail)
        {
            bool result = true;
            if (invoiceDetail.Quantity < 0)
            {
                result = false;
                errorMessages.Add("Quantity must be a positive integer");
            }
            if (String.IsNullOrWhiteSpace(invoiceDetail.Sku) || !Regex.IsMatch(invoiceDetail.Sku, skuRegex))
            {
                result = false;
                errorMessages.Add("Sku must be in the format of [AAA][1234]");
            }
            if (invoiceDetail.Price < 0)
            {
                result = false;
                errorMessages.Add("Price must be a positve integer");
            }
            return result;
        }
        public static int CreateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            if (Validate(invoiceDetail))
            {
                return InvoiceCRUDRepository.CreateInvoice(invoiceDetail);
            }
            else
            {
                return -1;
            }
        }

        public static InvoiceDetailCollection GetInvoiceDetails()
        {
            return InvoiceCRUDRepository.GetInvoiceDetails();
        }

        public static int UpdateInvoiceDetail (InvoiceDetail invoiceDetail)
        {
            if (Validate(invoiceDetail))
            {
                return InvoiceCRUDRepository.UpdateInvoiceDetail(invoiceDetail);
            }
            else
            {
                return -1;
            }
        }

        public static int DeleteInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            if (Validate(invoiceDetail))
            {
                return InvoiceCRUDRepository.DeleteInvoice(invoiceDetail);
            }
            else
            {
                return -1;
            }
        }
    }
}
