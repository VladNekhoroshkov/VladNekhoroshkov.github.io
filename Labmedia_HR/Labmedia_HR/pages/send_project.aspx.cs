using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;
using Newtonsoft.Json;

public partial class pages_send_project : System.Web.UI.Page
{
    private HttpCookie cookie;
    private static string vacancy = Config.VacanciesDB;
    protected void Page_Load(object sender, EventArgs e)
    {
        sendproj.ServerClick += SendProjClik;
        cookie = Request.Cookies.Get("data");
    }

    public void SendProjClik(object Sedler, EventArgs e)
    {
        string token = Request.Cookies["data"].Value;
        if (token != null)
        {
            string name = GenerateName();
            upload.PostedFile.SaveAs(Server.MapPath("") + Config.SolutionPAth + name);
            string reff = Config.SolutionPAth + name;

            DB_handler.AddReff(token, reff, description.Value);
            Response.Redirect("send_project.aspx");
        }
        else
        {
            Response.Redirect("HR.aspx");
        }
    }

    private string GenerateName()
    {
        string name = "";
        char[] base64 = new char[]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a',
            'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
            't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1',
            '2','3','4','5','6','7','8','9'
        };
        for (int i = 0; i < 11; i++)
        {
            name += base64[new Random().Next(0, base64.Length - 1)];
        }
        return name + ".zip";
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
            }  // Читаем базу данных из файла
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
                        <div class='col s5 offset-s2 info_card'>
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