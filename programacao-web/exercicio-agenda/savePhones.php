<?php
$telefone = $_POST["telefone"];
$id_contato = $_POST["id_contato"];
$nome = $_POST["nome"];

include("conexao.php");

$gravar = mysqli_query($link, "insert into tb_telefones (id_contato, telefone) VALUES ('$id_contato', '$telefone')");

if ($gravar) {
    echo '<meta http-equiv="Refresh" content="0;url=admin.php?action=phones&id='. $id_contato .'&nome='. $nome .'">';
} else {
    echo 'Ocorreu algum problema na Gravação';
    echo '<a href="admin.php?action=contacts">Voltar</a>';
}
