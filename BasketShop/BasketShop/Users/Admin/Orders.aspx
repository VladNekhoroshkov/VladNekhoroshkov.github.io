<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Users_Admin_Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8" />
    <title>Заказы</title>

    <link href="https://www.basketshop.ru/images/favicon/favicon.ico" rel="icon" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lora" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/css/materialize.min.css" />
    <link rel="stylesheet" href="../css/style.css" />
    <link rel="stylesheet" href="../css/slider.css" />
    <link rel="stylesheet" href="../css/BuyButton.css" />

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0-beta/js/materialize.min.js"></script>
    <script src="js/index.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row orange card header">
            <div class="col s2">
                <span class="brand">Basket shop</span>
            </div>
            <div class="col s10 right">
                <a class="waves-effect waves-light btn brown "><i class="material-icons left ">whatshot</i>О нас</a>
                <a class="waves-effect waves-light btn brown"><i class="material-icons left ">shopping_cart</i>Корзина</a>
                <a class="waves-effect waves-light btn brown"><i class="material-icons left ">exit_to_app</i>Выход</a>
            </div>
        </div>

        <div class="images-container">
            <div class="sub-container">
                <div class="slider" id="main-slider">
                    <div class="slider-wrapper">
                        <img src="https://b.fssta.com/uploads/2017/02/021517-fsf-cbk-florida-gators-egbunu-pi.vresize.1200.630.high.26.jpg" class="slide" />
                        <img src="https://b.fssta.com/uploads/2017/11/ball_lilliard.vresize.1200.630.high.95.jpg" class="slide" />
                        <img src="https://b.fssta.com/uploads/2017/06/chris-paul-twitter-reactions.vresize.1200.630.high.0.jpg" class="slide" />
                        <img src="http://rusoboz.ru/images/sport/img-3011-1508320380.jpg" class="slide" />
                    </div>
                </div>
            </div>
        </div>

        <script src="js/slider.js"></script>
    </form>
</body>
</html>
