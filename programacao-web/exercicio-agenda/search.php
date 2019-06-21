<center>
  <h1>Pesquisar Contatos</h1>
	<form method="post" action="">
		<input type="text" name="txtpesquisa">
		<input type="submit" value="Pesquisar">
	</form>
	<?php
	  if (isset($_POST["txtpesquisa"])){
		  include("conexao.php");
          
          $pesquisa = $_POST["txtpesquisa"];
          $pesquisar = mysqli_query($link,"select * from tb_contatos where upper(nome) like upper('%$pesquisa%')");

          echo '<br /><table width="400" border="1" align="center">';
          
		  while ($contatos = mysqli_fetch_array($pesquisar)){
			  echo "<tr><td><a href='?action=phones&id=".$contatos["id"]."&nome=".$contatos["nome"]."'>".$contatos["nome"]."</a></td></tr>";		  
          }
          echo '</table>';
	  }
	?>
</center>