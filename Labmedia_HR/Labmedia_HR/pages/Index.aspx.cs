using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using App_Code;
using Newtonsoft.Json;

public partial class pages_Index : System.Web.UI.Page
{
    private HttpCookie cookie;
    private static string vacancy = Config.VacanciesDB;
    protected void Page_Load(object sender, EventArgs e)
    {
        sendbut.ServerClick += SignUP;
        cookie = Request.Cookies.Get("data");
        my_enter.ServerClick += ServerClik;
    }

    public void SignUP(object sendler, EventArgs e)
    {
        string token = DB_handler.getNewToken();
        DB_handler.AddUser(
            first_name.Value,
            patronymic.Value,
            second_name.Value,
            phone.Value,
            email_inline.Value,
            password.Value,
            token
                      
            );

        HttpCookie cookie = new HttpCookie("data"); //прописываем его в кукИ
        cookie.Value = token;
        cookie.Expires = DateTime.Now.AddMinutes(10);
        Response.Cookies.Add(cookie);



        Response.Redirect("Index.aspx");
    }

    private void ServerClik(object Sedler, EventArgs e)
    {
        string token = DB_handler.getToken(usernameEnter.Value, passwordEnter.Value); //получаем токен пользователя для входа в его учетку
        if (token != null && token == "DC2RNa5dTUCbKhIlh0bHKg")
        {
            Response.Cookies.Add(getCookie(token)); //запихиваем токен в кукИ
            Response.Redirect("HR.aspx");  // Переходим на главную
        }
        else if (token != null)
        {
            Response.Cookies.Add(getCookie(token)); //запихиваем токен в кукИ
            Response.Redirect("send_project.aspx");  // Переходим на главную
        }

    }
    private HttpCookie getCookie(string token)  //перезаписываем кукИ
    {
        HttpCookie cookie = new HttpCookie("data");
        cookie.Value = token;
        cookie.Expires = DateTime.Now.AddMinutes(100);
        return cookie;

    }

    public void PageGen()
    {
        {  
            Response.Write("");  
            int count = 0;
            List<Dictionary<string, string>> Vac;
            using (StreamReader sr = new StreamReader(vacancy))
            {
                Vac = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd()); 
                sr.Close();
            }  
            foreach (Dictionary<string, string> item in Vac)
            {


                Response.Write(String.Format(@"
                    <div class='row ' style='border: black'>
                        <div class='col s5 offset-s1'>
                            <a class='btn-floating btn-large waves-effect waves-light indigo' href='../test task/testtask.doc'><i class='material-icons'>cloud_download</i></a>
                            <span class='info_title'> {0}  ({1})
                            </span>
                        </div>
                    
                    </div>

                        <div class='col s5 offset-s1 info_card'>
                            <div>
                                <span>Обязанности: {2}
                                </span>
                            </div>
                            <div>
                                <span>ЗП: {3}
                                </span>
                            </div>
                            <div>
                                <span>Требования: {4}
                                </span>
                            </div>
                        
                    
                ", item["vacancy"], item["time"], item["demands"], item["salary"], item["conditions"]));  
                count++;  
            }
            Response.Write("</div>");  
        }

    }

}