<?php
$email = $_POST["email"];
$senha = $_POST["password"];

// Faz conexão com banco de dados
include("conexao.php");

// Verificar se existe usuário cadastrado
$buscaUsuariosCadastrados = mysqli_query($link, "select * from tb_usuarios limit 1");

// Verfica a quantidade de registros
$quantidadeDeRegistros = mysqli_num_rows($buscaUsuariosCadastrados);
if ($quantidadeDeRegistros < 1) {

    // Inserir usuário padrão
    $inserirUsuario = mysqli_query($link, "insert into tb_usuarios VALUES (null, 'Administrador', 'admin@etec.com.br', '1234')");
}

$validaLogin = mysqli_query($link, "select * from tb_usuarios where email = '$email' and senha = '$senha'");
if (mysqli_num_rows($validaLogin) == 0)
{
    echo "Usuário ou senha inválidos!";
    include("index.php");
} else {
    // Grava os dados do usuário na sessão
    session_start();
    $_SESSION["usuario"] = mysqli_fetch_array($validaLogin);

    // Redireciona para a página admin.php
    header("Location: admin.php");
}
