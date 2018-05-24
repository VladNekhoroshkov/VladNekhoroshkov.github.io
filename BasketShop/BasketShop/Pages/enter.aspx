<%@ Page Language="C#" AutoEventWireup="true" CodeFile="enter.aspx.cs" Inherits="Pages_enter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Вход</title>

    <link href="https://www.basketshop.ru/images/favicon/favicon.ico" rel="icon" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lora" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/css/materialize.min.css" />
    <link rel="stylesheet" href="../css/pages_style.css" />

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/js/materialize.min.js"></script>
    <script src="../js/pages_js.js"></script>
</head>
<body>
    <form id="form_enter" runat="server">
        <div style="width: 100%;">
            <div class="white card ">
                <div class="row">
                    <div class="col s12" style="text-align: center">
                        <span class="brand">Вход</span>
                    </div>
                </div>

                <div style="margin: 0 auto; width: 35%">
                    <div class="row">
                        <div class="input-field  col s12 ">
                            <input id="email_inline" type="email" class="validate" />
                            <label for="email_inline">Email</label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="input-field col s12">
                            <input id="password" type="password" class="validate">
                            <label for="password">Password</label>
                        </div>
                    </div>
                    <div class="col s12 center">
                        <a class="waves-effect waves-light btn brown"><i class="material-icons left ">airplay</i>Войти</a>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
