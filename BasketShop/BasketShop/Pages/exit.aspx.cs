using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_exit : System.Web.UI.Page
{
    protected void Page_Load()
    {
        HttpCookie cookie = Request.Cookies["data"];

        cookie.Expires = DateTime.Now.AddDays(-1);  // Удаляем cookie

        Response.Cookies.Add(cookie);
        Response.Redirect("/");  // Переходим на главную
    }


}