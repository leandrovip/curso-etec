<?php
session_start();

if (isset($_POST["nome"])) {
    $_SESSION['usuario'] = $_POST['nome'];
} else {

}

echo "<br />";
echo "<br />";
echo "<strong> Usuario: " . $_SESSION['usuario'];
?>


