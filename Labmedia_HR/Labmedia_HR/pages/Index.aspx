<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="pages_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <title>Вакансии</title>

    <link href="http://www.clipartbest.com/cliparts/KTn/XBo/KTnXBo5Lc.png" rel="icon"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lora"/>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/css/materialize.min.css"/>
    <link rel="stylesheet" href="../css/style.css"/>


    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/js/materialize.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="row indigo darken-4 card header">
            <div class="col s3 offset-s1">
                <div class="col company-name">
                    <span>Лабмедиа</span>
                </div>
            </div>
            <div class="col s8" style="text-align: right; margin-bottom: -25px; margin-top:-10px"; >
                <div class="input-field col s3 offset-s5" style="font-weight: bold">
                    <input placeholder="Логин (email)" id="usernameEnter" runat="server" type="email" class="validate"/>                  
                </div>
                <div class="input-field col s3">
                     <input placeholder="Пароль" id="passwordEnter" runat="server" type="password" class="validate"/>                  
                </div>
                <div class="input-field col s1">
                    <a id="my_enter" runat="server" class="waves-effect waves-light btn  white" style=" font-weight: bold; color: black">Вход</a>            
                </div>
            </div>

                
        </div>

        <div class="row  info_card">
            <div class="row info_title">
                <div class="col s10 offset-s1">
                    <span class="open-vacation">Открытые вакансии:</span>
                    <hr/>
                </div>
            </div>

            <%PageGen();%>

            <div class="row ">
                <div class="col s3 offset-s1 white card " style="border-radius: 30px; margin-top: -70px;">
                    <div class="col s12 user_card">
                        <span>Откликнуться
                        </span>
                    </div>
                    <div style="margin: 0 auto; width: 70%">
                        <div class="row">
                            <div class="input-field col s12 " style="margin-bottom: -10%">
                                <input id="second_name" type="text" runat="server" class="validate" />
                                <label for="second_name">Фамилия</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col s12" style="margin-bottom: -10%">
                                <input id="first_name" type="text" runat="server" class="validate" />
                                <label for="first_name">Имя</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col s12" style="margin-bottom: -10%">
                                <input id="patronymic" type="text" runat="server" class="validate" />
                                <label for="patronymic">Отчество</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col s12" style="margin-bottom: -10%">
                                <input id="phone" type="text" runat="server" class="validate" />
                                <label for="first_name">Номер телефона</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="input-field col s12" style="margin-bottom: -10%">
                                <input id="email_inline" runat="server" type="email" class="validate" />
                                <label for="email_inline">Email</label>
                            </div>
                        </div>

                        <div class=" row">
                            <div class="input-field col s12">
                                <input id="password" runat="server" type="password" class="validate"/>
                                <label for="password">Пароль</label>
                            </div>
                        </div>
                        <div class="col s12 center" style="margin-bottom: 3%">
                            <a id="sendbut" runat="server" class="waves-effect waves-light btn indigo" href="enter.aspx"><i class="material-icons left ">send</i>Отправить данные</a>
                        </div>

                    </div>
                </div>
            </div>

        </div>


        

    </form>

       <script  src="../js/index.js"></script>

</body>
</html>
