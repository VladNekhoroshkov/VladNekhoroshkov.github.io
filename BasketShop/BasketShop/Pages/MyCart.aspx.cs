using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

using App_Code;







public partial class Pages_MyCart : System.Web.UI.Page
{

}


public partial class Basket : System.Web.UI.Page
{

    private HttpCookie cookie;
    private Dictionary<string, string> user;
    private List<string> basket;

    public void Page_Load()
    {
        cookie = Request.Cookies["data"];
        if (cookie == null)
        {
            Response.Redirect("/");
        }
        user = Explorer.getUser(cookie.Value);
        basket = JsonConvert.DeserializeObject<List<string>>(user["basket"].ToString());
        delete.ServerClick += onDeleteClick;
    }
        public void onDeleteClick(object sendler, EventArgs e)
        {
            Explorer.deleteBasketItem(cookie.Value, field.Value.Split('m')[1]);  // Удаляем товар из корзины
            Response.Redirect("/basket");  // Делаем перезагрузку страницы, чтобы обновить список мотоциклов
        }

        public void Page_gen()
        {
            int number = 0;
            string page_body = "<div class='row'>";
            page_body += "<div class='col s12 offset-s2'>";
            List<Dictionary<string, string>> balls;
            using (StreamReader sr = new StreamReader(Server.MapPath("~/DataBase/database.json")))
            {
                balls = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
            }

            foreach (Dictionary<string, string> ball in balls)
            {
                if (number % 4 == 0 && number != 0)
                {
                    page_body += "<div class='row'>";
                    page_body += "<div class='col s12'>";
                }

                page_body += String.Format(@"
            
                <div class='col s2 '>
                    <div class='orange card'>
                        <div class='card-image'>
                            <img style = 'padding: 5px' src = '{0}'>

                        </div>
                        <div class='card-content '>
                            <span class='card-title brown-text'>
                                {1}
                            </span>
                            <div class='bay-button'>
                                <a class='waves-effect waves-light btn brown '><i class='material-icons left'>account_balance_wallet</i>{2} руб.</a>
                            </div>
                        </div>
                    </div>
                </div>
            
                ", ball["href-foto"], ball["name"], ball["price"]);

                number++;
            }

            page_body += "</div>";
            page_body += "</div>";
            Response.Write(page_body);
        }
    }
 


    /*public string getUser()
    {
        return (string)name["name"];
    }*/
