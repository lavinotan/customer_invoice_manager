using COMP2614Assign07.Printer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign07
{
    public partial class PrintInvoiceReportDialog : Form
    {
        public ClientViewModel ClientVM { get; set; }
        
        private StringBuilder invoicesReport;

        public PrintInvoiceReportDialog()
        {
            InitializeComponent();
        }

        private void PrintInvoiceReport_Load(object sender, EventArgs e)
        {
            // Set the invoices report from the report printer based on the invoices from the selected client
            invoicesReport = ReportPrinter.PrintInvoices(this.ClientVM.Invoices);
            textBoxPrintInvoiceReport.Text = invoicesReport.ToString();
        }         

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
