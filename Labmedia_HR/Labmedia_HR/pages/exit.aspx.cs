﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_exit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["data"];

        cookie.Expires = DateTime.Now.AddDays(-1);  // Удаляем cookie

        Response.Cookies.Add(cookie);
        Response.Redirect("Index.aspx");  // Переходим на главную
    }
}