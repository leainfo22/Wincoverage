using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWincoverage.NetFramework.Models;

namespace WpfWincoverage.NetFramework.Database
{
    class DatabaseController
    {
        private static string stringConnection = "Data Source=database.db";

        /*public static async Task<List<UserModel>> getUserList()
        {
            List<UserModel> listProfiel = new List<UserModel>();
            try
            {
                BasicHttpBinding binding = new BasicHttpBinding();
                //Specify the address to be used for the client.
                EndpointAddress address = new EndpointAddress("http://wincoveragesoap.azurewebsites.net/UserService.svc");
                //UserService.UserServiceClient oCliente = new UserService.UserServiceClient(binding, address);

                UserService2.UserServiceClient oCliente2 = new UserService2.UserServiceClient(binding, address);

                //var usersList = await oCliente.getAllUsersAsync();
                var usersList2 = oCliente2.getAllUsers();

                foreach (string[] list in usersList2)
                {
                    UserModel userModer = new UserModel();
                    userModer.Name = list[1];
                    userModer.User = list[2];
                    userModer.Email = list[3];
                    userModer.Phone = list[4];
                    userModer.Charge = list[5];
                    userModer.Rol = list[6];
                    listProfiel.Add(userModer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listProfiel;
        }*/

        public static List<UserModel> getUserList()
        {
            List<UserModel> listProfiel = new List<UserModel>();
            try
            {
                List<List<string>> usersList2 = new List<List<string>>();
                usersList2 = TcpBinding.Client.Program.GetUsuarios();
                foreach (List<string> list in usersList2)
                {
                    UserModel userModer = new UserModel();
                    userModer.Name = list[1];
                    userModer.User = list[2];
                    userModer.Email = list[3];
                    userModer.Phone = list[4];
                    userModer.Charge = list[5];
                    userModer.Rol = list[6];
                    listProfiel.Add(userModer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listProfiel;
        }

        public static async Task deleteUser(string user, string name)
        {
            try
            {
                /*AzureUserService.UserServiceClient oCliente = new AzureUserService.UserServiceClient();
                await oCliente.deleteUserAsync(user,name);      */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void addUser(UserModel user)
        {

            try
            {
                /*AzureUserService.UserServiceClient oCliente = new AzureUserService.UserServiceClient();
                await oCliente.addUserAsync(user.User, user.Name, user.Email, user.Phone, user.Charge, user.Rol);*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static  void updateUser(UserModel user, string userMain, string nameMain, string emailMain)
        {
            try
            {
                /*AzureUserService.UserServiceClient oCliente = new AzureUserService.UserServiceClient();
                await oCliente.updateUserAsync(user.User, user.Name, user.Email, user.Phone, user.Charge, user.Rol, userMain, nameMain, emailMain);*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int getCoutAP()
        {
            int coutAP = 0;
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT count(*) from CPEAP WHERE type = 'AP'";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                coutAP = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return coutAP;
        }

        public static int getCoutCPE()
        {
            int coutCPE = 0;
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT count(*) from CPEAP WHERE type = 'CPE'";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                coutCPE = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return coutCPE;
        }
        public static int getCoutGPS()
        {
            int coutAP = 0;
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT count(*) from CPEAP WHERE type = 'GPS'";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                coutAP = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return coutAP;
        }

        public static int getCoutSite()
        {
            int coutAP = 0;
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT count(*) from sitelocation";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                coutAP = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return coutAP;
        }

        public static int getCoutChannel()
        {
            int coutAP = 0;
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT count(*) from channel";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                coutAP = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return coutAP;
        }

        public static List<CPEAModel> getAPList(int limit, int offset)
        {
            List<CPEAModel> listProfiel = new List<CPEAModel>();
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = string.Format("select code,brand,model,firmware,date,last_edit_date,edit_by from CPEAP where type='AP' limit {0} offset {1}", limit, offset);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CPEAModel userModer = new CPEAModel();
                                userModer.Code = reader.GetString(0);
                                userModer.Brand = reader.GetString(1);
                                userModer.Model = reader.GetString(2);
                                userModer.Firmware = reader.GetString(3);
                                userModer.Date = reader.GetString(4);
                                userModer.Last_edit_date = reader.GetString(5);
                                userModer.Edit_by = reader.GetString(6);
                                listProfiel.Add(userModer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listProfiel;
        }

        public static List<CPEAModel> getCPEList(int limit, int offset)
        {
            List<CPEAModel> listProfiel = new List<CPEAModel>();
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = string.Format("select code,brand,model,firmware,date,last_edit_date,edit_by from CPEAP where type='CPE' limit {0} offset {1}", limit, offset);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CPEAModel userModer = new CPEAModel();
                                userModer.Code = reader.GetString(0);
                                userModer.Brand = reader.GetString(1);
                                userModer.Model = reader.GetString(2);
                                userModer.Firmware = reader.GetString(3);
                                userModer.Date = reader.GetString(4);
                                userModer.Last_edit_date = reader.GetString(5);
                                userModer.Edit_by = reader.GetString(6);
                                listProfiel.Add(userModer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listProfiel;
        }

        public static List<CPEAModel> getGPSList(int limit, int offset)
        {
            List<CPEAModel> listProfiel = new List<CPEAModel>();
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = string.Format("select code,brand,model,firmware,date,last_edit_date,edit_by from CPEAP where type='GPS' limit {0} offset {1}", limit, offset);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CPEAModel userModer = new CPEAModel();
                                userModer.Code = reader.GetString(0);
                                userModer.Brand = reader.GetString(1);
                                userModer.Model = reader.GetString(2);
                                userModer.Firmware = reader.GetString(3);
                                userModer.Date = reader.GetString(4);
                                userModer.Last_edit_date = reader.GetString(5);
                                userModer.Edit_by = reader.GetString(6);
                                listProfiel.Add(userModer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listProfiel;
        }

        public static List<SiteModel> getSiteList(int limit, int offset)
        {
            List<SiteModel> listProfiel = new List<SiteModel>();
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = string.Format("select name,area,longitud,latitud from sitelocation limit {0} offset {1}", limit, offset);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                SiteModel userModer = new SiteModel();
                                userModer.Name = reader.GetString(0);
                                userModer.Area = reader.GetString(1);
                                var aux = reader.GetValue(2);
                                userModer.Longitud = aux.ToString();
                                var aux2 = reader.GetValue(2);
                                userModer.Latitud = aux2.ToString();
                                listProfiel.Add(userModer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listProfiel;
        }

        public static List<ChannelModel> getChannelList(int limit, int offset)
        {
            List<ChannelModel> listProfiel = new List<ChannelModel>();
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = string.Format("select channel,fqzmedia,bandwidth,startband,endband from channel limit {0} offset {1}", limit, offset);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ChannelModel userModer = new ChannelModel();
                                userModer.Channel = reader.GetString(0);
                                userModer.FqzMedia = reader.GetString(1);
                                var aux = reader.GetValue(2);
                                userModer.Ancho = aux.ToString();
                                var aux2 = reader.GetValue(2);
                                userModer.BandaIni = aux2.ToString();
                                var aux3 = reader.GetValue(2);
                                userModer.BandaFin = aux3.ToString();
                                listProfiel.Add(userModer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listProfiel;
        }

        public static void addAP(string code, string brand, string model, string firmware)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    string query = string.Format("INSERT INTO CPEAP(code, brand, model, firmware, date, last_edit_date, edit_by, type) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", code, brand, model, firmware, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("dd-MM-yyyy"), UserCurrentModel.charge, "AP");
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void addCPE(string code, string brand, string model, string firmware)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    string query = string.Format("INSERT INTO CPEAP(code, brand, model, firmware, date, last_edit_date, edit_by, type) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", code, brand, model, firmware, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("dd-MM-yyyy"), UserCurrentModel.charge, "CPE");
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void addGPS(string code, string brand, string model, string firmware)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    string query = string.Format("INSERT INTO CPEAP(code, brand, model, firmware, date, last_edit_date, edit_by, type) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", code, brand, model, firmware, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("dd-MM-yyyy"), UserCurrentModel.charge, "GPS");
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void addSite(string name, string area, string longitud, string latitud)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    string query = string.Format("INSERT INTO sitelocation(name, area, longitud, latitud) VALUES('{0}','{1}',{2},{3}", name, area, longitud, latitud);
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void updateCPEAP(CPEAModel user, string code, string brand, string model, string firmware)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = string.Format("UPDATE CPEAP SET code = '{0}',brand='{1}',model='{2}',firmware='{3}',last_edit_date='{4}',edit_by='{5}' WHERE USER='{6}' AND NAME='{7}' AND EMAIL='{8}'", code, brand, model, firmware, DateTime.Now.ToString("dd-MM-yyyy"), UserCurrentModel.charge);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
        public static void updateSite(string name, string area, string longitud, string latitud)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = string.Format("UPDATE sitelocation SET name = '{0}',area='{1}',model='{2}',longitud={3},latitud={4} WHERE USER='{6}' AND NAME='{7}' AND EMAIL='{8}'", code, brand, model, firmware, DateTime.Now.ToString("dd-MM-yyyy"), UserCurrentModel.charge);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        */

        public static void deleteCPEAP(string code)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = string.Format("delete FROM CPEAP where code ='{0}' ", code);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void deleteChannel(ChannelModel channel)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = string.Format("delete FROM channel where channel ='{0}' and bandwidth='{1}' and startband='{2}' and endband='{3}' and fqzmedia='{4}' ", channel.Channel, channel.Ancho, channel.BandaIni, channel.BandaFin, channel.FqzMedia);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static List<FamilyModel> getFamilyList(int limit, int offset)
        {
            List<FamilyModel> listProfiel = new List<FamilyModel>();
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = string.Format("select family,data,location from family limit {0} offset {1}", limit, offset);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {

                                FamilyModel userModer = new FamilyModel();
                                userModer.Family = reader.GetString(0);
                                userModer.Data = reader.GetString(1);
                                userModer.OID_Location = reader.GetString(2);
                                listProfiel.Add(userModer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listProfiel;
        }

        public static int getCoutFamily()
        {
            int coutCPE = 0;
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "SELECT count(*) from family";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                coutCPE = reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return coutCPE;
        }/**/

    }
}
