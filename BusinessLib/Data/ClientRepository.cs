using System;
using System.Data.SqlClient;
using System.Data;
using BusinessLib.Common;

namespace BusinessLib.Data
{
    public class ClientRepository
    {
        private static readonly string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                                      Initial Catalog=comp2614;
                                                      User ID=student; 
                                                      Password=iLOVEpho!; 
                                                      Encrypt=True; 
                                                      TrustServerCertificate=False; 
                                                      Connection Timeout=30;";

        private const string clientTableName = "Client1030427";

        public static ClientList GetClients()
        {
            ClientList clients = new ClientList();

            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                                    FROM {clientTableName}
                                    ORDER BY ClientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string clientCode;
                        string companyName;
                        string address1;
                        string address2 = null;
                        string city = null;
                        string province;
                        string postalCode = null;
                        decimal ytdSales;
                        bool creditHold;
                        string notes = null;

                        while (reader.Read())
                        {
                            clientCode = reader["ClientCode"] as string;
                            companyName = reader["CompanyName"] as string;
                            address1 = reader["Address1"] as string;

                            if (!reader.IsDBNull(reader.GetOrdinal("Address2")))
                            {
                                address2 = reader["Address2"] as string;
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("City")))
                            {
                                city = reader["City"] as string;
                            }

                            province = reader["Province"] as string;

                            if (!reader.IsDBNull(reader.GetOrdinal("PostalCode")))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }

                            ytdSales = (decimal)reader["YTDSales"];

                            creditHold = (bool)reader["CreditHold"];

                            if (!reader.IsDBNull(reader.GetOrdinal("Notes")))
                            {
                                notes = reader["Notes"] as string;
                            }

                            clients.Add(new Client {
                                                    ClientCode = clientCode,
                                                    CompanyName = companyName,
                                                    Address1 = address1,
                                                    Address2 = address2,
                                                    City = city,
                                                    Province = province,
                                                    PostalCode = postalCode,
                                                    YTDSales = ytdSales,
                                                    CreditHold = creditHold,
                                                    Notes = notes
                                                    });

                            address2 = null;
                            city = null;
                            postalCode = null;
                            notes = null;
                        }                            
                    }
                }
            }            

            return clients;
        }

        public static Client GetClient(string clientCode)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"SELECT ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes
                                  FROM {clientTableName}
                                  WHERE ClientCode = @ClientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        string companyName;
                        string address1;
                        string address2 = null;
                        string city = null;
                        string province;
                        string postalCode = null;
                        decimal ytdSales;
                        bool creditHold;
                        string notes = null;

                        while (reader.Read())
                        {
                            clientCode = reader["ClientCode"] as string;
                            companyName = reader["CompanyName"] as string;
                            address1 = reader["Address1"] as string;

                            if (!reader.IsDBNull(reader.GetOrdinal("Address2")))
                            {
                                address2 = reader["Address2"] as string;
                            }
                            else
                            {
                                address2 = null;
                            }

                            if (!reader.IsDBNull(reader.GetOrdinal("City")))
                            {
                                city = reader["City"] as string;
                            }
                            else
                            {
                                city = null;
                            }

                            province = reader["Province"] as string;

                            if (!reader.IsDBNull(reader.GetOrdinal("PostalCode")))
                            {
                                postalCode = reader["PostalCode"] as string;
                            }
                            else
                            {
                                postalCode = null;
                            }

                            ytdSales = (decimal)reader["YTDSales"];

                            creditHold = (bool)reader["CreditHold"];

                            if (!reader.IsDBNull(reader.GetOrdinal("Notes")))
                            {
                                notes = reader["Notes"] as string;
                            }
                            else
                            {
                                notes = null;
                            }

                            return new Client
                            {
                                ClientCode = clientCode,
                                CompanyName = companyName,
                                Address1 = address1,
                                Address2 = address2,
                                City = city,
                                Province = province,
                                PostalCode = postalCode,
                                YTDSales = ytdSales,
                                CreditHold = creditHold,
                                Notes = notes
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static int AddClient(ref Client client)
        {
            int rowsAffected;

            using (SqlConnection conn = new SqlConnection(connString))
            { 
                string query = $@"INSERT INTO {clientTableName}
                                         (ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, Notes)
                                  VALUES (@clientCode, @companyName, @address1, @address2, @city, @province, @postalCode, @ytdSales, @creditHold, @notes);";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("clientCode", client.ClientCode);
                    cmd.Parameters.AddWithValue("companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("address1", client.Address1);
                    cmd.Parameters.AddWithValue("address2", (object)client.Address2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("city", (object)client.City ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("province", client.Province);
                    cmd.Parameters.AddWithValue("postalCode", (object)client.PostalCode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("ytdSales", client.YTDSales);
                    cmd.Parameters.AddWithValue("creditHold", client.CreditHold);
                    cmd.Parameters.AddWithValue("notes", (object)client.Notes ?? DBNull.Value);

                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }            
            }

            return rowsAffected;
        }

        public static int UpdateClient(Client client, string originalClientCode)
        {
            int rowsAffected;

            using (SqlConnection conn = new SqlConnection(connString))
            {               
                string query = $@"UPDATE {clientTableName}
                                  SET ClientCode = @clientCode,
                                      CompanyName = @companyName,
                                      Address1 = @address1,
                                      Address2 = @address2,
                                      City = @city,
                                      Province = @province,
                                      PostalCode = @postalCode,
                                      YTDSales = @ytdSales,
                                      CreditHold = @creditHold,
                                      Notes = @notes
                                  WHERE ClientCode = @originalClientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;                   
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("clientCode", client.ClientCode);
                    cmd.Parameters.AddWithValue("companyName", client.CompanyName);
                    cmd.Parameters.AddWithValue("address1", client.Address1);
                    cmd.Parameters.AddWithValue("address2", (object)client.Address2 ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("city", (object)client.City ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("province", client.Province);
                    cmd.Parameters.AddWithValue("postalCode", (object)client.PostalCode ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("ytdSales", client.YTDSales);
                    cmd.Parameters.AddWithValue("creditHold", client.CreditHold);
                    cmd.Parameters.AddWithValue("notes", (object)client.Notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("originalClientCode", originalClientCode);

                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public static int DeleteClient(Client client)
        {
            int rowsAffected;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"DELETE {clientTableName}
                                  WHERE ClientCode = @ClientCode";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("clientCode", client.ClientCode);

                    conn.Open();

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
    }
}
