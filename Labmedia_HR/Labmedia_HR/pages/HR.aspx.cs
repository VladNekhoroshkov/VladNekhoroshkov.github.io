using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;
using Newtonsoft.Json;

public partial class pages_HR : System.Web.UI.Page
{
    private static string vacancy = Config.VacanciesDB;
    private HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {
        cookie = Request.Cookies.Get("data");
        s.ServerClick += saveChanges;
    }

    

    
    private HttpCookie getCookie(string token)  //перезаписываем кукИ
    {
        HttpCookie cookie = new HttpCookie("data");
        cookie.Value = token;
        cookie.Expires = DateTime.Now.AddMinutes(100);
        return cookie;

    }
    public void saveChanges(object sendler, EventArgs args)
    {  // Метод, который сохраняет изменения, внесенные администратором
        DB_handler.changeItem(vac.Value, time.Value, demands.Value, conditions.Value, salary.Value);
        Response.Redirect("HR.aspx");
    }

    public void PageGen()
    {
        {  // Метод отвечает за генерацию товаров на странице с возможностью редактирования
            Response.Write("");  // Пишем в aspx начальную строчку
            int count = 0;
            List<Dictionary<string, string>> Vac;
            using (StreamReader sr = new StreamReader(vacancy))
            {
                Vac = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd()); //формат данных из json -> string
                sr.Close();
            }  // Читаем базу данных из файла
            foreach (Dictionary<string, string> item in Vac)
            {


                Response.Write(String.Format(@" 
                        <div class='col s3 offset-s1 info_card'>
                            <div >
                                <div class='form-group' >
                                    <label for='item['vacancy']'>Вакансия:</label>
                                    <input id='vacChange' type='text' class='form-control' value='{0}'>
                                </div>
                            </div>
                            <div class='form-group'>
                                <label for='item['time']'>График работы</label>
                                <input id='timeChange' type='text' class='form-control' value='{1}'>
                            </div>
                            <div class='form-group'>
                                <label for='item['demands']'>Описание:</label>
                                <textarea id='demandsChange' class='form-control'  rows'5'>{2}</textarea>
                            </div>
                            <div class='form-group'>
                                <label for='price{0}'>ЗП:</label>
                                <input id='salaryChange'type='text' class='form-control price' value='{3}'>
                            </div>
                            <div class='form-group'>
                                <label for='item['demands']' style='font-weight: bold' >Обязанности:</label>
                                <textarea id='conditionsChange' class='form-control' rows'5'>{4}</textarea>
                            </div>
                            <div style='text-align: center;'>
                                <a id='change' runat='server' class='waves-effect waves-light btn indigo save link add ' >Сохранить изменения</a>
                            </div>
                        
                ", item["vacancy"], item["time"], item["demands"], item["salary"], item["conditions"]));  // Тут генерируем разметку 1 товара
                count++; 
            }
            Response.Write("</div>");
            
            
        }
        

    }

    public void PageAboutUser_gen() 
    {
        int number = 0;
        string pageabout_body = "";
        List<Dictionary<string, string>> userProj;


        using (StreamReader sr = new StreamReader(Server.MapPath("~/databases/users.json")))
        {
            userProj = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
        }



        foreach (Dictionary<string, string> proj in userProj) 
        {
            if (number == 0)
            {
                number++;
                continue;
            }
            if (number % 1 == 0 && number != 0)
            {
               
                pageabout_body += "<div class='row'>";
                pageabout_body += "<div class='col s12'>";
            }

            pageabout_body += String.Format(@"
                <div class='col s12'>                    
                    <div>
                        <span class=' brown-text'>
                            Пользователь: {0} {1} {2} ({3}) <br>
                            Тестовое + комментарий: {4}
                        </span>
                    </div>                    
                </div>
            
                ", proj["s_name"], proj["f_name"], proj["patronymic"], proj["email"], GetUserProj(proj["reff"]));  //вызываем метод на получение товаров из корзины(полных названий, а не id)

            number++;
        }
        pageabout_body += "</div>";
        Response.Write(pageabout_body);


    }
    private string GetUserProj(string reff) 
    {
        List<Dictionary<string, string>> proj;
        string page_proj = "";
        using (StreamReader sr = new StreamReader(Server.MapPath("~/databases/users.json")))
        {
            proj = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(sr.ReadToEnd());
        }

        foreach (Dictionary<string, string> p in proj)
        {
            if (p["role"] == "HR" || p["reff"] == "")
            {
                continue;
            }            
            page_proj += " <a class='btn-floating btn-small waves-effect waves-light indigo' + href =' ";            
            page_proj += p["reff"];
            page_proj += " 'download><i class='material-icons'>cloud_download</i></a>  ";
            page_proj += p["description"];
            page_proj += "</br></br>";

        }
        return page_proj;
    }
}