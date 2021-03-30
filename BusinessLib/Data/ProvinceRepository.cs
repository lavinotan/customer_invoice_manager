using BusinessLib.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib.Data
{
    public class ProvinceRepository
    {
        private static readonly string connString = @"Server=tcp:comp2614.database.windows.net,1433; 
                                                      Initial Catalog=comp2614;
                                                      User ID=student; 
                                                      Password=iLOVEpho!; 
                                                      Encrypt=True; 
                                                      TrustServerCertificate=False; 
                                                      Connection Timeout=30;";

        private const string provinceTableName = "Province";

        public static ProvinceList GetProvinces()
        {
            ProvinceList provinces = new ProvinceList();


            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = $@"SELECT ProvinceId, Sort, Abbreviation, Name
                                    FROM {provinceTableName}
                                    ORDER BY Sort";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int provinceId;
                        int sort;
                        string abbreviation;
                        string name = null;

                        while (reader.Read())
                        {
                            provinceId = (int)reader["ProvinceId"];
                            sort = (int)reader["Sort"];
                            abbreviation = reader["Abbreviation"] as string;

                            if (!reader.IsDBNull(reader.GetOrdinal("Name")))
                            {
                                name = reader["Name"] as string;
                            }

                            provinces.Add(new Province
                            {
                                ProvinceId = provinceId,
                                Sort = sort,
                                Abbreviation = abbreviation,
                                Name = name
                            });

                            name = null;
                        }
                    }
                }
            }

            return provinces;
        }
    }
}
