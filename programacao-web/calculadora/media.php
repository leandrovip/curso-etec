<!-- Develop by Leandro Ferreira
email: oi@leandro.in -->

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Exercício Média</title>
</head>
<body>
    <h1>Exercício da Média aritimética</h1>
    <br />

    <form action="" method="post">
        Número 1 <input type="number" name="numero1"> <br />
        Número 2 <input type="number" name="numero2"> <br /> <br />

        <input type="submit" value="Calcular"><br /><br />
    </form>

    <?php
            if ($_POST){
                $resultado = $_POST["numero1"] + $_POST["numero2"];
                $resultado = $resultado / 2;

                echo "O resultado da média é: ". $resultado;
            }        
    ?>
</body>
</html>