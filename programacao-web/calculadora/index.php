<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Calculadora</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" type="text/css" media="screen" href="main.css" />
    <script src="main.js"></script>
</head>
<body>
    <h1>Calculadora</h1>

    <form method="post" action="">
        Número 1 <input type="number" name="n1"><br />
        Número 2 <input type="number" name="n2"><br />

        Operação 
        <select name="operacao">
            <option value="soma">+</option>
            <option value="subtracao">-</option>
            <option value="multiplicacao">*</option>
            <option value="divisao">/</option>
            <option value="media">Média</option>
        </select><br />
        <input type="submit" value="Calcular">
    </form>

    <?php 
        if (isset(($_POST["operacao"]))) {
            if ($_POST["operacao"] == "soma") {
                $resultado = $_POST["n1"] + $_POST["n2"];
            }else if ($_POST["operacao"] == "subtracao") {
                $resultado = $_POST["n1"] - $_POST["n2"];
            }else if ($_POST["operacao"] == "multiplicacao") {
                $resultado = $_POST["n1"] * $_POST["n2"];
            }else if ($_POST["operacao"] == "divisao") {
                $resultado = $_POST["n1"] / $_POST["n2"];
            }else if ($_POST[operacao] == "media") {
                $resultado = $_POST["n1"] + $_POST["n2"] / 2;
            }
        }

        echo "O resultado é: ". $resultado;
    ?>
</body>
</html>