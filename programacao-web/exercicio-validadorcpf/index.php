<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Exercício Validador CPF</title>
</head>

<body>
<form method="post" action="">
	Informe o CPF:
	<input type="text" name="txtcpf">
	<input type="submit" value="Validar">
</form>

<?php
	$cpfDigitado = $_POST["txtcpf"];	

	function ValidaCPF($cpf){
		//fazer a validação
		$n1 = substr ($cpf,0,1);
	    $n2 = substr ($cpf,1,1);
		$n3 = substr ($cpf,2,1);
		$n4 = substr ($cpf,3,1);
		$n5 = substr ($cpf,4,1);
		$n6 = substr ($cpf,5,1);
		$n7 = substr ($cpf,6,1);
		$n8 = substr ($cpf,7,1);
		$n9 = substr ($cpf,8,1);
		$d1 = substr ($cpf,9,1);
		$d2 = substr ($cpf,10,1);

		$digito1 = ($n1 * 10) + ($n2 * 9) + ($n3 * 8) + ($n4 * 7) + ($n5 * 6) + ($n6 * 5) + ($n7 * 4) + ($n8 * 3) + ($n9 * 2);
		$digito1 = $digito1 % 11;

		if ($digito1 > 9) {
			$digito1 = 0;
		}
		else {
			$digito1 = 11 - $digito1;
		}

        $digito2 = ($n1 * 11) + ($n2 * 10) + ($n3 * 9) + ($n4 * 8) + ($n5 * 7) + ($n6 * 6) + ($n7 * 5) + ($n8 * 4) + ($n9 * 3) + ($d1 * 2);
		$digito2 = $digito2 % 11;

		if ($digito1 == $d1 && $digito2 == $d2) {
			return "CPF Válido";
		}
		else {
			return "CPF Inválido";
		}
    }
    
	echo ValidaCPF($cpfDigitado);	
?>
</body>
</html>