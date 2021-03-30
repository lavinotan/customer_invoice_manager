using BusinessLib.Business;
using BusinessLib.Common;
using BusinessLib.Data;
using InvoiceLookupApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign07
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ClientList clients;        

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ClientViewModel()
        {
            clients = ClientValidation.GetClients();
            ClientsSource = new BindingSource();
            ClientsSource.DataSource = clients;
            ClientsSource.ListChanged += ClientSource_ListChanged;
            DisplayClient = new Client();
            Invoices = new List<InvoiceLookupApi.Invoice>();
        }

        private Client displayClient;

        public Client DisplayClient
        {
            get { return displayClient; }
            set
            {
                displayClient = new Client
                {
                    ClientCode = value.ClientCode,
                    CompanyName = value.CompanyName,
                    Address1 = value.Address1,
                    Address2 = value.Address2,
                    City = value.City,
                    Province = value.Province,
                    PostalCode = value.PostalCode,
                    YTDSales = value.YTDSales,
                    CreditHold = value.CreditHold,
                    Notes = value.Notes
                };

                OnPropertyChanged();
            }
        }               

        public List<InvoiceLookupApi.Invoice> Invoices { get; set; }

        public BindingSource ClientsSource { get; }

        public int Count => clients.Count;

        public int CreditHoldCount => clients.CreditHoldCount;

        public decimal TotalYTDSales => clients.TotalYTDSales;

        public decimal YTDSalesDifference => DisplayClient.YTDSales - clients.AverageYTDSales;

        private void ClientSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            OnPropertyChanged("Count");
            OnPropertyChanged("CreditHoldCount");
            OnPropertyChanged("TotalYTDSales");
            OnPropertyChanged("YTDSalesDifference");
        }        
    }
}
