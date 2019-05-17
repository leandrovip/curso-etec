<?php
  $nome = $_POST["nome"];
  include("conexao.php");

  $gravar = mysqli_query($link,
	    	 "insert into tb_contatos (nome) VALUES ('$nome')");

  if ($gravar){
	  echo '<script>alert("Contato salvo com sucesso!")</script>';
	  echo '<meta http-equiv="Refresh" content="0;url=admin.php?action=contacts">';
	 }else{
	  echo "Ocorreu algum problema na Gravação";
	  echo '<a href="admin.php?action=contacts">Voltar</a>';
  }
