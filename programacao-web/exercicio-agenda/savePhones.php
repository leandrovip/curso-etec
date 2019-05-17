<?php
$telefone = $_POST["telefone"];
$id_contato = $_POST["id_contato"];
include("conexao.php");

$gravar = mysqli_query($link, "insert into tb_telefones (id_contato, telefone) VALUES ('$id_contato', '$telefone')");

if ($gravar) {
    echo '<script>alert("Telefone salvo com sucesso!")</script>';
    echo '<meta http-equiv="Refresh" content="0;url=admin.php?action=contacts">';
} else {
    echo "Ocorreu algum problema na Gravação";
    echo '<a href="admin.php?action=contacts">Voltar</a>';
}
