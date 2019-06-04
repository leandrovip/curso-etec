<?php
$id = $_GET["id"];
$nome = $_GET["nome"];
?>

<center>
	<h1>Editar de Contato</h1>
	<form method="post" action="saveContacts.php?action=edit">
		<input type="hidden" name="id" value="<?php echo $id; ?>">	
		<table>
			<tr>
				<td>Nome</td>
				<td><input type="text" name="nome" value="<?php echo $nome ?>"></td>
				<td><input type="submit" value="Salvar"></td>
			</tr>
		</table>
	</form>
</center>


<?php
// include "conexao.php";
// $lista = mysqli_query($link, "select * from tb_contatos");
// echo "<br \>";

// echo "<table width='500' border='1' align='center'>";
// echo "<tr><td>ID</td><td>Nome</td><td>Ações</td></tr>";

// while ($registros = mysqli_fetch_array($lista)) {
// 	echo "<tr>";
// 	echo "<td>" . $registros["id"] . "</td>";
// 	echo "<td><a href='?action=phones&id="
// 		. $registros["id"] ."&nome=". $registros["nome"] . "'>" . $registros["nome"] . "</a></td>";

// 	echo "<td align='center'>";

// 	echo '<a href="editContact.php?id=' . $registros["id"] . '">
// 	<img src="imgs/edit.png" width="16" heigth="16" border="0"></a>';

// 	echo '<a href="removeContact.php?id=' . $registros["id"] . '">
// 	<img src="imgs/remove.png" width="16" heigth="16" border="0"></a>';

// 	echo "</td>";
// 	echo "</tr>";
// }

// echo "</table>";
?>