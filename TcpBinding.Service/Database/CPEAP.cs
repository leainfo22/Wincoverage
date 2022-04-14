using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpBinding.Service.Database
{
    public class CPEAP
    {
        public static string SQLConnectionString = "Server=tcp:testmilliways.database.windows.net,1433;Initial Catalog = Test; Persist Security Info=False;User ID = testmilliways; Password=milliwaystest22.; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";
        public static List<List<string>> GetCPEAP()
        {
            List<List<string>> returnData = new List<List<string>>();

            using (SqlConnection connection = new SqlConnection(SQLConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("spGetAllCPEAP", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            List<string> data = new List<string>();
                            data.Add(reader[0].ToString());
                            data.Add(reader[1].ToString());
                            data.Add(reader[2].ToString());
                            data.Add(reader[3].ToString());
                            data.Add(reader[4].ToString());
                            data.Add(reader[5].ToString());
                            data.Add(reader[6].ToString());
                            returnData.Add(data);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    return null;
                }
            }
            return returnData;
        }
    }
}
