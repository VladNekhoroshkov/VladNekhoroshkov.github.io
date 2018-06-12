using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для DB_handler
/// </summary>
namespace App_Code
{
    public class DB_handler
    {
        private static string users = Config.UsersDBPath;
        private static string vacancy = Config.VacanciesDB;
        public static void AddUser(string f_name, string s_name, string patronymic, string phone, string email, string password, string token)
        {
            List<Dictionary<string, string>> usersDb;
            using (StreamReader sr = new StreamReader(users))
            {
                usersDb = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
                sr.Close();
            }

            Dictionary<string, string> user = new Dictionary<string, string>(); //заполняем данные о новом пользователе
            user["id"] = usersDb.Count.ToString();
            user["f_name"] = f_name;
            user["patronymic"] = patronymic;
            user["s_name"] = s_name;
            user["phone"] = phone;
            user["email"] = email;
            user["token"] = token;
            user["role"] = "base";
            user["reff"] = "";
            user["description"] = "";
            user["password"] = (password);

            usersDb.Add(user);

            using (StreamWriter sw = new StreamWriter(DB_handler.users))
            {
                sw.Write(JsonConvert.SerializeObject(usersDb));
                sw.Close();
            }
        }

        public static Dictionary<string, string> getUser(string token) 
        {
            List<Dictionary<string, string>> db = null;
            try
            {
                using (StreamReader sr = new StreamReader(users))
                {
                    db = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
                    sr.Close();
                }
            }

            catch (Exception e)
            {

            }
            try
            {
                foreach (Dictionary<string, string> user in db)
                {
                    if (((string)user["token"]).Equals(token))
                    {
                        return user;
                    }
                }
            }
            catch (Exception e)
            {

            }


            return null;

        }

        public static string role(string token) 
        {
            List<Dictionary<string, string>> db;
            using (StreamReader sr = new StreamReader(users))
            {
                db = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
                sr.Close();
            }

            foreach (Dictionary<string, string> user in db)
            {
                if (((string)user["token"]).Equals(token))
                {
                    return (string)user["role"];
                }
            }

            return null;
        }

        public static bool AddReff(string token, string reff, string description)  
        {
            List<Dictionary<string, string>> database;
            using (StreamReader sr = new StreamReader(users))
            {
                database = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
                sr.Close();
            }

            foreach (Dictionary<string, string> user in database)
            {
                if (((string)user["token"]).Equals(token)) 
                {
 
                    user["reff"] = reff;
                    user["description"] = description;
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(users))
                        {
                            sw.Write(JsonConvert.SerializeObject(database));
                            sw.Close();
                        }
                    }
                    catch (Exception e)
                    {

                    }



                    return true;
                }
            }
            return false;
        }



        public static string getToken(string email, string password) 

        {
            List<Dictionary<string, string>> db;
            using (StreamReader sr = new StreamReader(users))
            {
                db = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
                sr.Close();
            }
            foreach (Dictionary<string, string> user in db)
            {
                if (user["email"].Equals(email) && user["password"].Equals(password))
                {
                    return (string)user["token"];
                }



            }

            return null;  

        }

        public static string getNewToken()
        {
            Guid g = Guid.NewGuid();
            string GuidString = Convert.ToBase64String(g.ToByteArray());
            GuidString = GuidString.Replace("=", "");
            GuidString = GuidString.Replace("+", "");
            return GuidString;
        }

        public static void changeItem(string vac, string time, string demands, string conditions, string salary)
        {  
            List<Dictionary<string, string>> Vac;
            using (StreamReader sr = new StreamReader(vacancy))
            {
                Vac = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd()); 
                sr.Close();
            }
            foreach (Dictionary<string, string> item in Vac)
            {
                item["vacancy"] = vac;
                item["time"] = time;
                item["demands"] = demands;
                item["salary"] = salary;
                item["conditions"] = conditions;
            }
            using (StreamWriter sw = new StreamWriter(DB_handler.vacancy)) 
            {
                sw.Write(JsonConvert.SerializeObject(Vac));
                sw.Close();
            }
        }
    }
}
