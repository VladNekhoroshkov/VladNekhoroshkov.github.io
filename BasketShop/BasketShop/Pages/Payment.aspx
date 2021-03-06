﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Payment.aspx.cs" Inherits="Pages_Payment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8"/>
    <title>Оплата</title>

    <link href="https://www.basketshop.ru/images/favicon/favicon.ico" rel="icon"/>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet"/>
    <link rel="stylesheet" href="../css/pages_style.css"/>
</head>
<body>
    <form id="form1" runat="server" >
        <div class="demo">
        <div class="payment-card">
            <div class="bank-card">
                <div class="bank-card__side bank-card__side_front">
                    <div class="bank-card__inner">
                        <label class="bank-card__label bank-card__label_holder">
                            <span class="bank-card__hint">Holder of card</span>
                            <input type="text" class="bank-card__field" placeholder="Holder of card" pattern="[A-Za-z, ]{2,}" name="holder-card" required/>
                        </label>
                    </div>
                    <div class="bank-card__inner">
                        <label class="bank-card__label bank-card__label_number">
                            <span class="bank-card__hint">Number of card</span>
                            <input type="text" class="bank-card__field" placeholder="Number of card" pattern="[0-9]{16}" name="number-card" required/>
                        </label>
                    </div>
                    <div class="bank-card__inner">
                        <span class="bank-card__caption">valid thru</span>
                    </div>
                    <div class="bank-card__inner bank-card__footer">
                        <label class="bank-card__label bank-card__month">
                            <span class="bank-card__hint">Month</span>
                            <input type="text" class="bank-card__field" placeholder="MM" maxlength="2" pattern="[0-9]{2}" name="mm-card" required/>
                        </label>
                        <span class="bank-card__separator">/</span>
                        <label class="bank-card__label bank-card__year">
                            <span class="bank-card__hint">Year</span>
                            <input type="text" class="bank-card__field" placeholder="YY" maxlength="2" pattern="[0-9]{2}" name="year-card" required/>
                        </label>
                    </div>
                </div>
                <div class="bank-card__side bank-card__side_back">
                    <div class="bank-card__inner">
                        <label class="bank-card__label bank-card__cvc">
                            <span class="bank-card__hint">CVC</span>
                            <input type="password" class="bank-card__field" placeholder="CVC" maxlength="3" pattern="[0-9]{3}" name="cvc-card" required/>
                        </label>
                    </div>
                </div>
            </div>
            <div class="payment-card__footer">
                <button class="payment-card__button">Send</button>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
