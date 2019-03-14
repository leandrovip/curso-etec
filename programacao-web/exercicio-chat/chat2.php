<?php
session_start();
if (isset($_POST["nome"])) {
    $_SESSION['usuario'] = $_POST["nome"];
}

if (isset($_SESSION["usuario"])) {
    echo "Bem vindo: <strong> " . $_SESSION["usuario"] . "</strong> ";
} else {
    header("Location: index.html");
}
?>

<a href="sair.php">Efetuar LogOff</a>

<br />
<br />
<iframe src="conversa.php" width="100%" height="200" frameborder="0"></iframe>

<br />
<br />

<form method="post" action="">
    <textarea name="mensagem" id="mensagem" cols="50" rows="10"></textarea>
    <input type="submit" value="Enviar Mensagem">
</form>

<?php

if (isset($_POST['mensagem'])) {
    $mensagem = $_SESSION['usuario'] . 'Diz: ' & $_POST['mensagem'] . '%#10';

    $file = fopen('teste.txt', 'a+');
    fwrite($file, $mensagem);
    fclose($file);
}

?>