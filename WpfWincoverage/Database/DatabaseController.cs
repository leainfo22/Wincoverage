using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfWincoverage.Models;

namespace WpfWincoverage.Database
{
    class DatabaseController
    {
        private static  string stringConnection = "Data Source=database.db";

        public static List<UserModel> getUserList()
        {
            List<UserModel> listProfiel = new List<UserModel>();
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();

                    command.CommandText = "select * from user";

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                UserModel userModer = new UserModel();
                                userModer.Name = reader.GetString(1);
                                userModer.User = reader.GetString(2);
                                userModer.Email = reader.GetString(3);
                                userModer.Phone = reader.GetString(4);
                                userModer.Charge = reader.GetString(5);
                                userModer.Rol = reader.GetString(6);
                                listProfiel.Add(userModer);
                            }
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
           
            return listProfiel;
        }

        public static void deleteUser(string user, string name)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = string.Format("delete FROM user where user ='{0}' and name='{1}'",user,name);
                    command.ExecuteNonQuery();
                }
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
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    string query =  string.Format("INSERT INTO USER (USER,NAME,EMAIL,PHONE,CHARGE,ROL) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", user.User, user.Name, user.Email, user.Phone, user.Charge, user.Rol);
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void updateUser(UserModel user,string userMain,string nameMain, string emailMain)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = string.Format("UPDATE USER SET USER = '{0}',NAME='{1}',EMAIL='{2}',PHONE='{3}',CHARGE='{4}',ROL='{5}' WHERE USER='{6}' AND NAME='{7}' AND EMAIL='{8}'", user.User, user.Name, user.Email, user.Phone, user.Charge, user.Rol,userMain,nameMain,emailMain);
                    command.ExecuteNonQuery();
                }
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

                    command.CommandText = string.Format("select code,brand,model,firmware,date,last_edit_date,edit_by from CPEAP where type='CPE' limit {0} offset {1}",limit,offset);

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

        public static void addAP(string code, string brand, string model, string firmware)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    string query = string.Format("INSERT INTO CPEAP(code, brand, model, firmware, date, last_edit_date, edit_by, type) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", code, brand, model, firmware, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("dd-MM-yyyy"), UserCurrentModel.charge,"AP");
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

        public static void updateCPEAP(CPEAModel user, string code, string brand, string model,string firmware)
        {
            try
            {
                using (var connection = new SQLiteConnection(stringConnection))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = string.Format("UPDATE USER SET code = '{0}',brand='{1}',model='{2}',firmware='{3}',last_edit_date='{4}',edit_by='{5}' WHERE USER='{6}' AND NAME='{7}' AND EMAIL='{8}'", code, brand, model, firmware, DateTime.Now.ToString("dd-MM-yyyy"), UserCurrentModel.charge);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


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
        }


    }
}
