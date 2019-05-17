<?php
$id = $_GET["id"];
include "conexao.php";

$apagar = mysqli_query($link, "delete from tb_contatos where id = '$id'");
if ($apagar) {
    echo '<script>alert("Contato excluído com sucesso!")</script>';
    echo '<meta http-equiv="Refresh" content="0;url=admin.php?action=contacts">';
} else {
    echo 'Deu erro :(';
}
