using BusinessLib.Common;
using BusinessLib.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLib.Business
{
    public class ClientValidation
    {
        private static List<string> errors = new List<string>();

        public static string ErrorMessage
        {
            get 
            {
                string message = "";

                foreach (string line in errors)
                {
                    message += line + "\r\n";
                }

                return message;
            }
        }

        public static int AddClient(ref Client client)
        {
            if (validate(client))
            {
                return ClientRepository.AddClient(ref client);
            }
            else
            {
                return -1;
            }
        }

        public static int UpdateClient(Client client, string originalClientCode)
        {
            if (validate(client))
            {
                return ClientRepository.UpdateClient(client, originalClientCode);
            }
            else
            {
                return -1;
            }
        }

        public static int DeleteClient(Client client) => ClientRepository.DeleteClient(client);
        
        public static ClientList GetClients()
        {

            ClientList clientList = ClientRepository.GetClients();
            
            foreach (Client client in clientList)
            {
                validate(client);
            }

            return clientList;
        }

        private static bool validate(Client client)
        {
            bool valid = true;
            errors.Clear();

            string regexClientCode = @"^[A-Z]{5}$";            

            if (string.IsNullOrEmpty(client.ClientCode))
            {
                errors.Add("ClientCode cannot be empty.");
                valid = false;
            }
            else if (!Regex.IsMatch(client.ClientCode, regexClientCode))
            {
                errors.Add("Clientcode must have the pattern AAAAA");
            }

            if (string.IsNullOrEmpty(client.CompanyName))
            {
                errors.Add("Company Name cannot be empty.");
                valid = false;
            }

            if (string.IsNullOrEmpty(client.Address1))
            {
                errors.Add("Address1 cannot be empty.");
                valid = false;
            }

            if (string.IsNullOrEmpty(client.Province))
            {
                errors.Add("Province cannot be empty.");
                valid = false;
            }

            string regexPostalCode = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";

            if (string.IsNullOrEmpty(client.PostalCode))
            {
                errors.Add("PostalCode cannot be empty.");
                valid = false;
            }
            else
            {
                if (!Regex.IsMatch(client.PostalCode, regexPostalCode))
                {
                    errors.Add("PostalCode must have the pattern A9A 9A9");
                    valid = false;
                }                
            }

            if (client.YTDSales < 0)
            {
                errors.Add("YTD Sales cannot be negative.");
                valid = false;
            }

            if (client.CreditHold == true)
            {              
                if (string.IsNullOrEmpty(client.City))
                {
                    errors.Add("City cannot be empty.");
                    valid = false;
                }              
            }            

            return valid;
        }
    }
}
