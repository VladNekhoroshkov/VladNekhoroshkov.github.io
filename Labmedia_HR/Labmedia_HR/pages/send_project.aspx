<%@ Page Language="C#" AutoEventWireup="true" CodeFile="send_project.aspx.cs" Inherits="pages_send_project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Отправка задания</title>

    <link href="http://www.clipartbest.com/cliparts/KTn/XBo/KTnXBo5Lc.png" rel="icon"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lora"/>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/css/materialize.min.css"/>
    <link rel="stylesheet" href="../css/style.css"/>


    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/js/materialize.min.js"></script>

</head>
<body>
    <form id="form2" runat="server">
        <div class="row indigo darken-4 card header">
            <div class="col s3 offset-s1">
                <div class="col company-name">
                    <span>Лабмедиа</span>
                </div>
            </div>
            <div class="col s8" style="text-align:right">
                <a id="exit" runat="server" class="waves-effect waves-light btn-large white" style=" font-weight: bold; color: black" href="exit.aspx"><i class="material-icons left"></i>Выход</a> 
            </div>
        </div>

        <div class="row info_card">
            <div class="row info_title">
                <div class="col s10 offset-s1">
                    <span class="open-vacation">Открытые вакансии:</span>
                    <hr />
                </div>
            </div>

            <%PageGen();%>

            
            <div class="row ">
                <div class="col s4 offset-s1 white card " style="border-radius: 30px; margin-top:-70px">
                    <div class="col s12 user_card">
                        <span>Прекрепите выполненное задание (zip архивом)
                        </span>
                    </div>
                    <div style="margin: 0 auto; width: 70%">
                        <div class="col s12 center" style="margin-bottom: 3%">
                            <input id="upload" runat="server" type="file" required />
                        </div>
                        <div class="col s12">
                            <textarea id="description" runat="server" placeholder="Ваш комментарий" required></textarea>
                        </div>
                        <div class="col s12">                            
                            <label>
                                <input id="indeterminate-checkbox" type="checkbox" />
                                <span>Задание выполнено</span>
                            </label>                            
                        </div>
                        <div class="col s12 center" style="margin-bottom: 3%">
                            
                            <a id="sendproj" runat="server" class="waves-effect waves-light btn indigo"><i class="material-icons left ">send</i>Отправить</a> 
                        </div>

                    </div>
                </div>
            </div>
         </div>

        




    </form>

    <!-- <script src="js/index.js"></script> -->


</body>
</html>
