using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign07.Printer
{
    class ReportPrinter
    {       
        public static StringBuilder PrintInvoices(List<InvoiceLookupApi.Invoice> invoices)
        {
            StringBuilder myStringBuilder = new StringBuilder();

            string divider = new string('-', 61);

            myStringBuilder.AppendLine("Invoice Listing");
            myStringBuilder.AppendLine(divider);

            foreach (InvoiceLookupApi.Invoice invoice in invoices)
            {
                myStringBuilder.AppendLine("");
                myStringBuilder.AppendFormat($"{"Invoice Number:",-15} {invoice.InvoiceNumber,-20}").AppendLine();
                myStringBuilder.AppendFormat($"{"Invoice Date:",-15} {invoice.InvoiceDate.ToString("MMM dd, yyyy"),-20}").AppendLine();
                myStringBuilder.AppendFormat($"{"Discount Date:",-15} {invoice.InvoiceDate.AddDays(invoice.DiscountPeriod).ToString("MMM dd, yyyy"),-20}").AppendLine();
                myStringBuilder.AppendFormat($"{"Terms:",-15} {invoice.DiscountPercentage:N2}% {invoice.DiscountPeriod} {(invoice.DiscountPeriod > 1 ? "days" : "day")} ADI").AppendLine();

                myStringBuilder.AppendLine(divider);
                myStringBuilder.AppendFormat($"{"Qty",3} {"SKU",-11} {"Description",-20} {"Price",10:N2} {"PST",3} {"Ext",9:N2}").AppendLine();
                myStringBuilder.AppendLine(divider);

                foreach (InvoiceLookupApi.InvoiceDetailLine item in invoice.InvoiceDetailLines)
                {
                    myStringBuilder.AppendFormat($"{item.Quantity,3} {item.Sku,-11} {item.Description,-20} {item.Price,10:N2} {(item.Taxable == true ? "Y" : "N"),2} {item.ExtendedPrice,10:N2}").AppendLine();
                }

                myStringBuilder.AppendLine(divider);

                myStringBuilder.AppendFormat($"{"",-15} {"Subtotal:",-20} {"",11} {invoice.Subtotal,12:N2}").AppendLine();
                myStringBuilder.AppendFormat($"{"",-15} {"GST:",-20} {"",11} {invoice.GstTotal,12:N2}").AppendLine();
                if (invoice.PstTotal != 0)
                {
                    myStringBuilder.AppendFormat($"{"",-15} {"PST:",-20} {"",11} {invoice.PstTotal,12:N2}").AppendLine();
                }

                myStringBuilder.AppendLine(divider);

                myStringBuilder.AppendFormat($"{"",-15} {"Total:",-20} {"",11} {invoice.Total,12:N2}").AppendLine();
                myStringBuilder.AppendFormat($"{"",-15} {"Discount:",-20} {"",11} {invoice.Discount,12:N2}").AppendLine();

                myStringBuilder.AppendLine("");
            }

            return myStringBuilder;
        }
    }
}
