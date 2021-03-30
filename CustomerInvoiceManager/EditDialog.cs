using BusinessLib.Business;
using BusinessLib.Common;
using BusinessLib.Data;
using InvoiceLookupApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign07
{
    public partial class EditDialog : Form
    {
        public Client client;
        public ClientViewModel ClientVM { get; set; }        
        public string OriginalClientCode { get; set; }
        public bool IsNew { get; set; }
        public int RowsAffected { get; set; }
        public bool HasInvoice { get; set; }

        public EditDialog()
        {
            InitializeComponent();
        }        

        public void setBindings()
        {
            maskedTextBoxClientCode.DataBindings.Add("Text", ClientVM, "DisplayClient.ClientCode");
            textBoxCompanyName.DataBindings.Add("Text", ClientVM, "DisplayClient.CompanyName");
            textBoxAddress1.DataBindings.Add("Text", ClientVM, "DisplayClient.Address1");
            textBoxAddress2.DataBindings.Add("Text", ClientVM, "DisplayClient.Address2");
            textBoxCity.DataBindings.Add("Text", ClientVM, "DisplayClient.City");
            comboBoxProvince.DataBindings.Add("Text", ClientVM, "DisplayClient.Province");
            maskedTextBoxPostalCode.DataBindings.Add("Text", ClientVM, "DisplayClient.PostalCode");
            textBoxYTDSales.DataBindings.Add("Text", ClientVM, "DisplayClient.YTDSales", true, DataSourceUpdateMode.OnValidation, "0", "#,##0;(#,##0);0");
            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "DisplayClient.CreditHold");
            textBoxNotes.DataBindings.Add("Text", ClientVM, "DisplayClient.Notes");
        }

        private void EditDialog_Load(object sender, EventArgs e)
        {
            setBindings();
            populateComboBoxProvince(comboBoxProvince);
            textBoxCompanyName.Select();
            textBoxCompanyName.SelectAll();
            hasInvoiceCheck(client);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {                                   
            client = ClientVM.DisplayClient;

            // If client code is already in the client view model or is not new,
            // replace the client information
            if (ClientVM.clients.Exists(x => x.ClientCode == OriginalClientCode) || !IsNew)
            {
                RowsAffected = ClientValidation.UpdateClient(client, OriginalClientCode);
            }
            else
            {
                RowsAffected = ClientValidation.AddClient(ref client);
            }

            if (RowsAffected == 0)
            {             
                errorProviderClient.SetError(buttonOK, "No DB changed were made");                
            }
            else if (RowsAffected < 0)
            {
                errorProviderClient.SetError(buttonOK, ClientValidation.ErrorMessage);               
            }
            
            // If all input data pass validation, then allow the EditDialog close with OK result
            if (RowsAffected >= 0)
            {
                DialogResult = DialogResult.OK;
            }            
        }           
                
        private void populateComboBoxProvince(ComboBox comboBox)
        {
            try
            {
                // Clear ComboBox first so that this method can be called again later if
                // necessary.
                comboBox.Items.Clear();

                ProvinceList provinces = ProvinceRepository.GetProvinces();

                foreach (Province province in provinces)
                {
                    string provinceAbbreviation = province.Abbreviation;
                    comboBox.Items.Add(provinceAbbreviation);
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hasInvoiceCheck(Client client)
        {
            // Check if the client has any invoices
            HasInvoice = InvoiceLookupApiClient.GetInvoicesByClient(client.ClientCode).Count != 0 ? true : false;

            // Disable the show invoices button, if there are no invoices for the client
            if (HasInvoice)
            {
                buttonShowInvoices.Enabled = true;
            }
            else
            {
                buttonShowInvoices.Enabled = false;
            }
        }

        private void buttonShowInvoices_Click(object sender, EventArgs e)
        {
            Client client;            
            client = ClientVM.DisplayClient;

            PrintInvoiceReportDialog printInvoiceReportDialog = new PrintInvoiceReportDialog();
            printInvoiceReportDialog.ClientVM = this.ClientVM;

            // Use InvoiceLookupApi to find and return invoice report based on client code.
            ClientVM.Invoices = InvoiceLookupApiClient.GetInvoicesByClient(client.ClientCode);
            printInvoiceReportDialog.ShowDialog();
        }        
    }
}
