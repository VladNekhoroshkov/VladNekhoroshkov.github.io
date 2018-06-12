<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HR.aspx.cs" Inherits="pages_HR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <title>HR</title>

    <link href="http://www.clipartbest.com/cliparts/KTn/XBo/KTnXBo5Lc.png" rel="icon"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lora"/>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/css/materialize.min.css"/>
    <link rel="stylesheet" href="../css/style.css"/>


    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/js/materialize.min.js"></script>

    <link rel="stylesheet" href="../css/login_style.css"/>
    <script src="../js/login_js.js"></script>
    <script src="../js/ChangeButton.js"></script>
</head>
<body>
    <form id="form1" runat="server">
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

        <div class="row white card info_card">
            <div class="row info_title">
                <div class="col s10 offset-s1 ">
                    <span class="open-vacation">Открытые вакансии:</span>
                    <hr/>
                </div>
            </div>
            

            <%PageGen();%>

            <div class="row ">
                <div class="col s6 offset-s1 white card " style="border-radius: 30px;">
                    <%PageAboutUser_gen(); %>
                </div>
            </div>

        </div>

        <asp:ScriptManager runat="server" ID="sm">
        </asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <a runat="server" id="changediscr" class="hidden"></a>
            </ContentTemplate>
        </asp:UpdatePanel>

        <a id="s" runat="server" style="display: none"></a>
        <input id="vac" runat="server" style="display:none" />
        <input id="time" runat="server" style="display:none" />
        <input id="demands" runat="server" style="display:none" />
        <input id="conditions" runat="server" style="display:none" />
        <input id="salary" runat="server" style="display:none" />

    </form>

    <script  src="../js/index.js"></script>
    

</body>
</html>

