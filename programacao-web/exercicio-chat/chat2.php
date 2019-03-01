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
<textarea name="conversa" id="conversa" cols="50" rows="10">
<?php
if (file_exists('teste.txt')) {
    $file = fopen('teste.txt', 'r');
    $content = fread($file, filesize('teste.txt'));
    fclose($file);

    echo $content;
}
?>
</textarea>

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