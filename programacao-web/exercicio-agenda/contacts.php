<center>
	<h1>Cadastro de Contatos</h1>
	<form method="post" action="saveContacts.php?action=insert">
		<input type="hidden" name="id" value="0">
		<table>
			<tr>
				<td>Nome</td>
				<td><input type="text" name="nome"></td>
				<td><input type="submit" value="Salvar"></td>
			</tr>
		</table>
	</form>
</center>


<?php
include "conexao.php";
$lista = mysqli_query($link, "select * from tb_contatos");
echo "<br \>";

echo "<table width='500' border='1' align='center'>";
echo "<tr><td>ID</td><td>Nome</td><td>Ações</td></tr>";

while ($registros = mysqli_fetch_array($lista)) {
	echo "<tr>";
	echo "<td>" . $registros["id"] . "</td>";
	echo "<td><a href='?action=phones&id="
		. $registros["id"] ."&nome=". $registros["nome"] . "'>" . $registros["nome"] . "</a></td>";

	echo "<td align='center'>";

	echo '<a href="?action=editContacts&id=' . $registros["id"] . '&nome='. $registros["nome"] .'">
	<img src="imgs/edit.png" width="16" heigth="16" border="0"></a>';

	echo '<a href="removeContact.php?id=' . $registros["id"] . '">
	<img src="imgs/remove.png" width="16" heigth="16" border="0"></a>';

	echo "</td>";
	echo "</tr>";
}

echo "</table>";
?>