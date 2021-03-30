using BusinessLib.Business;
using BusinessLib.Common;
using InvoiceLookupApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign07
{
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

        const string numberFormat = "#,##0.00;(#,##0.00);0";

        public MainForm()
        {
            InitializeComponent();
        }        

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                labelCountResult.Text = string.Empty;
                labelCreditHoldCount.Text = string.Empty;
                labelTotalYTDSales.Text = string.Empty;
                labelYTDSalesDifference.Text = string.Empty;
                clientVM = new ClientViewModel();
                setBindings();
                setupDataGridView();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void setBindings()
        {           
            labelCountResult.DataBindings.Add("Text", clientVM, "Count");
            labelCreditHoldCount.DataBindings.Add("Text", clientVM, "CreditHoldCount");
            labelTotalYTDSales.DataBindings.Add("Text", clientVM, "TotalYTDSales", true, DataSourceUpdateMode.OnValidation, "0", numberFormat);
            labelYTDSalesDifference.DataBindings.Add("Text", clientVM, "YTDSalesDifference", true, DataSourceUpdateMode.OnValidation, "0", numberFormat);
            
            dataGridViewClients.AutoGenerateColumns = false;            
            dataGridViewClients.DataSource = clientVM.ClientsSource;
        }               

        private void setupDataGridView()
        {
            // configure for readonly 
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // add columns

            DataGridViewTextBoxColumn code = new DataGridViewTextBoxColumn();
            code.Name = "code";
            code.DataPropertyName = "ClientCode";
            code.HeaderText = "Code";
            code.Width = 60;            
            code.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(code);

            DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
            companyName.Name = "companyName";
            companyName.DataPropertyName = "CompanyName";
            companyName.HeaderText = "Company Name";
            companyName.Width = 110;
            companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(companyName);

            DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
            address1.Name = "address1";
            address1.DataPropertyName = "Address1";
            address1.HeaderText = "Address 1";
            address1.Width = 120;
            address1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address1);

            DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
            address2.Name = "address2";
            address2.DataPropertyName = "Address2";
            address2.HeaderText = "Address 2";
            address2.Width = 120;
            address2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address2);

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
            city.Name = "city";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 70;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
            province.Name = "province";
            province.DataPropertyName = "Province";
            province.HeaderText = "Province";
            province.Width = 70;
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
            postalCode.Name = "postalCode";
            postalCode.DataPropertyName = "PostalCode";
            postalCode.HeaderText = "Postal Code";
            postalCode.Width = 70;
            postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalCode);

            DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
            ytdSales.Name = "ytdSales";
            ytdSales.DataPropertyName = "YTDSales";
            ytdSales.HeaderText = "YTD Sales";
            ytdSales.Width = 80;            
            ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Format = "N2";
            ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(ytdSales);

            DataGridViewCheckBoxColumn creditHold = new DataGridViewCheckBoxColumn();
            creditHold.Name = "creditHold";
            creditHold.DataPropertyName = "CreditHold";
            creditHold.HeaderText = "Credit Hold";
            creditHold.Width = 60;            
            creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(creditHold);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 300;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            ShowEditDialog(true);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ShowEditDialog(false);
        }
                    

        private void dataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowEditDialog(false);
        }        

        // Display edit dialog for client information based on the condition of add new or existing client
        private void ShowEditDialog(bool isNew)
        {
            try 
            {
                int rowsAffected;

                Client client;
                int index = dataGridViewClients.CurrentRow.Index;

                if (isNew)
                {
                    client = new Client();
                }
                else
                {
                    client = (Client)clientVM.ClientsSource[index];                    
                }

                // Set the display client
                clientVM.DisplayClient = client;

                using (EditDialog editDialog = new EditDialog())
                {
                    // Pass client information to editDialog then launch dialog
                    editDialog.ClientVM = this.clientVM;
                    editDialog.IsNew = isNew;
                    editDialog.client = client;
                    editDialog.OriginalClientCode = client.ClientCode;                                 

                    editDialog.ShowDialog();

                    if (editDialog.DialogResult == DialogResult.OK)
                    {
                        // Pass editDialog edited information back to main form
                        rowsAffected = editDialog.RowsAffected;
                        client = editDialog.client;

                        if (isNew && rowsAffected > 0)
                        {
                            clientVM.ClientsSource.Add(client);
                        }
                        else if (rowsAffected > 0)
                        {
                            clientVM.ClientsSource[index] = client;
                        }                        

                        if (rowsAffected > 0)
                        {
                            //Sort the list as the clientCode may have changed or an item may have been added
                            clientVM.clients.Sort();

                            //Reset the bindings so the listbox refreshes with the updated, sorted list.                        
                            clientVM.ClientsSource.ResetBindings(false);                            
                        }
                    }                    
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewClients.CurrentRow.Index;
                Client client = clientVM.clients[index];

                // Show confirm deletion dialog if checkBoxConfirmDeletion is checked
                if (checkBoxConfirmDeletion.Checked)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the client?", 
                                                                "Confirm Deletion", 
                                                                MessageBoxButtons.YesNo, 
                                                                MessageBoxIcon.Question,
                                                                MessageBoxDefaultButton.Button2);

                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteClient(client);
                    }
                }
                else
                {
                    deleteClient(client);
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

        private void deleteClient(Client client)
        {
            //Delete the client from the database
            int rowsAffected = ClientValidation.DeleteClient(client);

            //If the delete was succesful, remove the client from the list                
            if (rowsAffected > 0)
            {
                clientVM.ClientsSource.Remove(client);
            }
        }

        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            Client client = (Client)clientVM.ClientsSource[index];
            clientVM.DisplayClient = client;
            
            UpdateYTDSalesDifference();
            hasInvoiceCheck(client);
        }

        // Check if the selected client has any invoices
        private void hasInvoiceCheck(Client client)
        {            
            bool hasInvoice = InvoiceLookupApiClient.GetInvoicesByClient(client.ClientCode).Count != 0 ? true : false;

            // Disable the show invoices button, if there are no invoices for the client
            if (hasInvoice)
            {
                buttonReport.Enabled = true;
            }
            else
            {
                buttonReport.Enabled = false;
            }
        }                    

        private void UpdateYTDSalesDifference()
        {               
            labelYTDSalesDifference.Text = clientVM.YTDSalesDifference.ToString(numberFormat);

            if (clientVM.YTDSalesDifference < 0)
            {
                labelYTDSalesDifference.ForeColor = Color.Red;
            }
            else
            {
                labelYTDSalesDifference.ForeColor = Color.Black;
            }
        }

        // Print the invoice report for the selected client from the invoice database.
        private void buttonReport_Click(object sender, EventArgs e)
        {
            Client client;
            int index = dataGridViewClients.CurrentRow.Index;
            client = (Client)clientVM.ClientsSource[index];

            PrintInvoiceReportDialog printInvoiceReportDialog = new PrintInvoiceReportDialog();
            printInvoiceReportDialog.ClientVM = this.clientVM;

            // Use InvoiceLookupApi to find and return invoice report based on client code.
            clientVM.Invoices = InvoiceLookupApiClient.GetInvoicesByClient(client.ClientCode);

            printInvoiceReportDialog.ShowDialog();
        }
    }
}
