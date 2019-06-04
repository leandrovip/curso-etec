<?php
$nome = $_POST["nome"];
$id = $_POST["id"];
$action = $_GET["action"];

include("conexao.php");

if ($action == 'insert') {
	$gravar = mysqli_query($link,"insert into tb_contatos (nome) VALUES ('$nome');");
} else {
	$gravar = mysqli_query($link, "update tb_contatos set nome = '$nome' where id = '$id';");
}

if ($gravar) {
	echo '<script>alert("Contato salvo com sucesso!")</script>';
	echo '<meta http-equiv="Refresh" content="0;url=admin.php?action=contacts">';
} else {
	echo "Ocorreu algum problema na Gravação";
	echo '<a href="admin.php?action=contacts">Voltar</a>';
}
