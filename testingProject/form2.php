<html>
    <head>
        <meta charset="UTF-8">
    </head
    <body>
        Спасибо за ваше обращение, в ближайшее время с вами свяжутся наши специалисты!
    </body>
</html>


<?php
$name = $_POST['name'];
$phone = $_POST['phone'];
$email = $_POST['email'];
$question = $_POST['question'];

$name = htmlspecialchars($name);
$phone = htmlspecialchars($phone);
$email = htmlspecialchars($email);
$question = htmlspecialchars($question);

$name = urldecode($name);
$phone = urldecode($phone);
$email = urldecode($email);
$question = urldecode($question);

$name = trim($name);
$phone = trim($phone);
$email = trim($email);
$question = trim($question);

$formcontent=" Заявка с сайта: \n Имя: $name \n Email: $email \n Телефон: $phone \n Вопрос: $question \n Заявку принял: Орлов В.Л. \n Ссылка на сайт: http://arspro1u.beget.tech  ";
$recipient = "ars_pro@bk.ru, job@qwerty.bz";
$subject = "Заявка с сайта";
$mailheader = "From: ars_pro@bk.ru";
$result = mail($recipient, $subject, $formcontent, $mailheader);

if ($result) {
    echo "Спасибо за заявку!";
} else {
    echo "Произошла ошибка при отправке письма.";
}

?>
