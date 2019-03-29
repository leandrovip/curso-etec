<!DOCTYPE html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Média</title>
</head>
<body>
    <form action="" method="post">
        <input type="number" name="txtValor1" id="txtValor1">
        <input type="number" name="txtValor2" id="txtValor2">
        <input type="number" name="txtValor3" id="txtValor3">
        <input type="number" name="txtValor4" id="txtValor4">
        <input type="submit" value="Validar">
    </form>
</body>
</html>

<?php
$valor1 = 0;
$valor2 = 0;
$valor3 = 0;
$valor4 = 0;

if (!empty($_POST['txtValor1'])) {
    $valor1 = $_POST['txtValor1'];
}

if (!empty($_POST['txtValor2'])) {
    $valor2 = $_POST['txtValor2'];
}

if (!empty($_POST['txtValor3'])) {
    $valor3 = $_POST['txtValor3'];
}

if (!empty($_POST['txtValor4'])) {
    $valor4 = $_POST['txtValor4'];
}

$resultado = ($valor1 + $valor2 + $valor3 + $valor4) / 4;

if ($resultado != 0)
{
    echo '<br \><br \> O resultado da média é: ' .$resultado;
}   

?>