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

if (isset($_POST['send-button'])))
          {
            mail("ars_pro@bk.ru", "Заявка с сайта", "Имя:'.$name'", "Телефон: '.$phone'", "E-mail: '.$email'" ,"From: https://vk.com \r\n")
          }

        if mail("ars_pro@bk.ru", "Заявка с сайта", "Имя:'.$name'", "Телефон: '.$phone'", "E-mail: '.$email'" ,"From: https://vk.com \r\n")
          {
            echo "Ваше обращение успешно отправлено";
          }

        else
        {
          echo "При отправке обращения возникли ошибки";
        }
}
?>
