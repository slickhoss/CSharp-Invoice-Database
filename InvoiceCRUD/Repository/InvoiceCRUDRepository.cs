using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common;
namespace Repository
{
    public class InvoiceCRUDRepository
    {
        //establish server connection
        public static string connectionString = "Server = DESKTOP-8J6SAVC,1433;" +
            "                                   Initial Catalog = master;" +
            "                                   User ID = sa;" +
            "                                   Password = andrehoong;" +
            "                                   Encrypt = true;" +
            "                                   TrustServerCertificate = true;" +
            "                                   Connection Timeout = 30;";

        public static InvoiceDetailCollection GetInvoiceDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT detailId, quantity, sku, description, price, taxable FROM invoiceDetail";
                InvoiceDetailCollection invoiceDetails = new InvoiceDetailCollection();
                int detailId;
                int quantity;
                string sku;
                string description = null; //nullable field
                decimal price;
                bool taxable = false; //nullable
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Connection = connection;
                    connection.Open();
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            detailId = (int)dataReader["detailId"];
                            quantity = (int)dataReader["quantity"];
                            sku = dataReader["sku"] as string;
                            if (!dataReader.IsDBNull(3))
                            {
                                description = dataReader["description"] as string;
                            }
                            price = (decimal)dataReader["price"];
                            if (!dataReader.IsDBNull(5))
                            {
                                taxable = (bool)dataReader["taxable"];
                            }
                            invoiceDetails.Add(new InvoiceDetail { DetailId = detailId, Quantity = quantity, Sku = sku, Description = description, Price = price, Taxable = taxable });
                            description = null; //reset nullalbe values
                            taxable = false;
                        }
                    }
                    invoiceDetails.SalesTaxesRates = GetTaxRates();
                    return invoiceDetails;
                }

            }
        }

        public static int CreateInvoice(InvoiceDetail invoice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO InvoiceDetail (quantity, sku, description, price, taxable)"
                    +"VALUES (@quantity, @sku, @description, @price, @taxable)";
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@detailId", invoice.DetailId);
                    command.Parameters.AddWithValue("@quantity", invoice.Quantity);
                    command.Parameters.AddWithValue("@sku", invoice.Sku);
                    command.Parameters.AddWithValue("@description", invoice.Description);
                    command.Parameters.AddWithValue("@price", invoice.Price);
                    command.Parameters.AddWithValue("@taxable", invoice.Taxable);
                    command.Connection = connection;
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static int UpdateInvoiceDetail(InvoiceDetail invoice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE InvoiceDetail SET quantity = @quantity, sku = @sku, description = @description, price = @price, taxable = @taxable WHERE detailId = @detailId";
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@quantity", invoice.Quantity);
                    command.Parameters.AddWithValue("@sku", invoice.Sku);
                    if (!String.IsNullOrWhiteSpace(invoice.Description))
                    {
                        command.Parameters.AddWithValue("@description", invoice.Description);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@description", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@price", invoice.Price);
                    command.Parameters.AddWithValue("@taxable", invoice.Taxable);
                    command.Parameters.AddWithValue("@detailId", invoice.DetailId);
                    command.Connection = connection;
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static int DeleteInvoice(InvoiceDetail invoice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"DELETE FROM InvoiceDetail WHERE detailId = @detailId";
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@detailId", invoice.DetailId);
                    command.Connection = connection;
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public static SalesTaxRateCollection GetTaxRates()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT taxId, taxCode, taxRate FROM salesTaxRates";
                SalesTaxRateCollection salesTaxes = new SalesTaxRateCollection();
                int taxId;
                string taxCode;
                decimal taxRate;
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.Connection = connection;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            taxId = (int)reader["taxId"];
                            taxCode = reader["taxCode"] as string;
                            taxRate = (decimal)reader["taxRate"];
                            salesTaxes.Add(new SalesTaxRate { TaxId = taxId, TaxCode = taxCode, TaxRate = taxRate });
                        }
                    }
                }
                return salesTaxes;
            }
        }
    }
}
