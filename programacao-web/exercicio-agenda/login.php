<?php
session_start();
$email = $_POST["email"];
$senha = $_POST["password"];

//Fazemos a conexão com o Banco de dados
include("conexao.php");
//verificar se existe algum usuário cadastrado
$verificausuario = mysqli_query($link,"select * from tb_usuarios limit 1");
//Conto quantos registros a consulta acima retornou
if (mysqli_num_rows($verificausuario) == 0){
  //Inserimos um usuário no Banco de Dados :) 
   $inserirUser = mysqli_query($link,"insert into tb_usuarios 
   VALUES (null,'Administrador', 'admin@etec.com', '123')");
}

$validalogin = mysqli_query($link,"select * from tb_usuarios
where email = '$email' and senha = '$senha'");

if (mysqli_num_rows($validalogin) == 0){
  echo "Usuário ou senha inválidos!";
  include("index.php");
}else{
   //Gravo os dados do usuário na sessão
   $_SESSION["usuario"] = mysqli_fetch_array($validalogin);
   //Redireciono para a Pagina admin.php
   header("Location:admin.php");
}