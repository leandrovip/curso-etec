<?php

echo '<a href="index.php">Voltar</a> <br /><br />';

$cnpj = $_POST["txtValor"];

if ($cnpj == 'Preencha o CNPJ e tente novamente') {
    return;
}

if (strlen($cnpj) != 14) {
    echo 'O CNPJ deve ter 14 dígitos. Por favor, tente novamente';
    return;
}

echo validar($cnpj);

function Validar($valor)
{
    $lista1 = [5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];
    $lista2 = [6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2];

    $digito1 = GerarDigito($lista1, $valor);
    $digito2 = GerarDigito($lista2, $valor);

    if ($digito1 == substr($valor, 12, 1) && $digito2 == substr($valor, 13, 1)) {
        return "CNPJ válido! :)";
    }

    return "CNPJ inválido! :(";
}

function GerarDigito($lista, $valor)
{
    $soma = 0;
    $i = 0;

    foreach ($lista as $numero) {
        $soma += substr($valor, $i, 1) * $numero;
        $i++;
    }

    $resultado = $soma % 11;

    if ($resultado < 2) {
        return 0;
    } else {
        return 11 - $resultado;
    }
}
