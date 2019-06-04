<?php
$id = $_GET["id"];
$nome = $_GET["nome"];

include "conexao.php";

$apagar = mysqli_query($link, "delete from tb_telefones where id = '$id'");
if ($apagar) {
    echo '<meta http-equiv="Refresh" content="0;url=admin.php?action=phones&id='. $id .'&nome='. $nome .'">';
} else {
    echo 'Deu erro :(';
}
