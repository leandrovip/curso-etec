<?php
session_start();

if (empty($_SESSION['usuario'])) {
    header("Location: index.php");
}
?>

<!DOCTYPE html>
<html lang="pt-BR">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Agenda de Contatos</title>

    <style>
        a {
            text-decoration: none;
        }
    </style>
</head>

<body>
    <div id="menu" style="width: 960px; margin: auto; heigth: 55px; text-align:center">
        <?php
        echo "<p>Seja Bem vindo " . $_SESSION["usuario"]["nome"] . "</p>";
        ?>

        <a href="?action=contacts">
            <img src="imgs/book.png" width="50" heigth="50">
        </a>

        <a href="?action=search">
            <img src="imgs/search.png" width="50" heigth="50">
        </a>

        <a href="exit.php">
            <img src="imgs/exit.png" width="50" heigth="50">
        </a>
    </div>

    <div id="content" style="width: 960px; margin: auto; border: solid #000 1px; height: 600px; text-align:center">

        <?php
        if (isset($_GET["action"])) {
            switch ($_GET["action"]) {
                case "contacts":
                    $incluir = 'contacts.php';
                    break;
                case "phones":
                    $incluir = 'phones.php';
                    break;
                case "editContacts":
                    $incluir = 'editContacts.php';
                    break;
                case "search":
                    $incluir = 'search.php';
                    break;
                default:
                    $incluir = 'empty.php';
                    break;
            }
            include "$incluir";
        } else {
            echo "<h1>Selecione um Item no Menu Acima!</h1>";
        }
        ?>
    </div>
</body>

</html>