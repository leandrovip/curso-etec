<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Atividade</title>
</head>
<body>
    <form action="" method="post">
        <p>Digite o valor 1</p>
        <input type="text" name="txtValor1" id="txtValor1">
        <p>Digite o valor 2</p>
        <input type="text" name="txtValor2" id="txtValor2"> <br \><br \>
        <input type="submit" value="Validar">
    </form>
</body>
</html>

<?php
if (!empty($_POST['txtValor1'])) {
    $valor1 = $_POST['txtValor1'];
    echo '<br \><br \>';
    echo 'Valor 1 é: ' . $valor1;
}

if (!empty($_POST['txtValor2'])) {
    $valor2 = $_POST['txtValor2'];
    echo '<br \><br \>';
    echo 'Valor 2 é: ' . $valor2;
}
?>