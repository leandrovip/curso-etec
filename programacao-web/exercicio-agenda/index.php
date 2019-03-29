<?php

$usuarioBD = 'root';
$senhaBD = '123';
$database = 'agenda';
$hostBD = 'localhost';

$link = mysqli_connect($hostBD, $usuarioBD, $senhaBD, $database);
if ($link) {
    echo 'BD Conectado com sucesso! <br \><br \>';
}

echo 'Olá!';
