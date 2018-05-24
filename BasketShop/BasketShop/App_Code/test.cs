using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для test
/// </summary>
namespace Alex.algorithms
{
    public class Handlers
    {

        private static string database = "../DataBase/database.json";
        private static string users = "../DataBase/users.json";
        private static string orders = "../DataBase/orders.json";

        public static Dictionary<string, string> getUser(string token)
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
                    return user;
                }
            }

            return null;  // Если пользователь не найден

        }

       

        public static void addItem(string name, string price, string href_foto)
        {

            List<Dictionary<string, string>> db;
            using (StreamReader sr = new StreamReader(database))
            {
                db = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
                sr.Close();
            }

            int newId = Int32.Parse((string)db[db.Count - 1]["id"]);

            Dictionary<string, string> item = new Dictionary<string, string>();

            item["id"] = (newId + 1).ToString();
            item["name"] = name;
            item["price"] = price;
            item["href_foto"] = JsonConvert.SerializeObject(href_foto);

            db.Add(item);

            using (StreamWriter sw = new StreamWriter(database))
            {
                sw.Write(JsonConvert.SerializeObject(db));
                sw.Close();
            }
        }

        public static bool addToCart(string id, string itemId)
        {
            List<Dictionary<string, string>> database;
            using (StreamReader sr = new StreamReader(users))
            {
                database = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
                sr.Close();
            }

            foreach (Dictionary<string, string> user in database)
            {
                if (((string)user["token"]).Equals(id))
                {
                    List<string> cart = JsonConvert.DeserializeObject<List<string>>(user["cart"].ToString());
                    cart.Add(itemId);
                    user["cart"] = JsonConvert.SerializeObject(cart);
                    using (StreamWriter sw = new StreamWriter(users))
                    {
                        sw.Write(JsonConvert.SerializeObject(database));
                        sw.Close();
                    }
                    return true;
                }
            }
            return false;
        }


        public static List<string> getBasket(string token)
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
                    List<string> cart = JsonConvert.DeserializeObject<List<string>>(user["cart"].ToString());  // Получаем корзину пользователя
                    return cart;
                }
            }
            return null;
        }




        public static void deleteBasketItem(string token, string id)
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
                    List<string> cart = JsonConvert.DeserializeObject<List<string>>(user["cart"].ToString());
                    cart.Remove(id);

                    user["cart"] = JsonConvert.SerializeObject(cart);
                    using (StreamWriter sw = new StreamWriter(users))
                    {
                        sw.Write(JsonConvert.SerializeObject(db));
                        sw.Close();
                    }
                    return;
                }
            }

        }

    }
}