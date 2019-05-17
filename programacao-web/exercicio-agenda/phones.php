<?php
$id = $_GET["id"];
?>
<h1>Insira os Telefones para o Contato Selecionado</h1>
<h2>Contato: <?php echo $_GET["nome"]; ?></h2>

<form method="post" action="savePhones.php">
    <input type="hidden" name="id_contato" value="<?php echo $id; ?>">
    <table align="center">
        <tr>
            <td>Telefone</td>
            <td><input type="text" name="telefone"></td>
            <td><input type="submit" value="Salvar"></td>
        </tr>
    </table>
</form>

<?php
include "conexao.php";
$lista = mysqli_query($link, "select * from tb_telefones where id_contato = '$id'");
echo "<br \>";

echo "<table width='500' border='1' align='center'>";
echo "<tr><td>ID</td><td>Telefone</td><td>Ações</td></tr>";

while ($registros = mysqli_fetch_array($lista)) {
	echo "<tr>";
	echo "<td>" . $registros["id"] . "</td>";
	echo "<td><a href='?action=phones&id="
		. $registros["id"] . "'>" . $registros["telefone"] . "</a></td>";

	echo "<td align='center'>";

	// echo '<a href="editContact.php?id=' . $registros["id"] . '">
	// <img src="imgs/edit.png" width="16" heigth="16" border="0"></a>';

	echo '<a href="removePhone.php?id=' . $registros["id"] . '">
	<img src="imgs/remove.png" width="16" heigth="16" border="0"></a>';

	echo "</td>";
	echo "</tr>";
}

echo "</table>";
?>