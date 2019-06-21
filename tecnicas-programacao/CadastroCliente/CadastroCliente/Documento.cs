using System;

namespace CadastroCliente
{
	public class Documento
	{
		public static bool Validar(string numero)
		{
			if (numero.IsNullOrEmpty())
				return false;

			numero = numero.OnlyNumbers();
			return numero.Length == 14 ? ValidarCnpj(numero) : ValidarCpf(numero);
		}

		private static bool ValidarCpf(string numero)
		{
			if (numero.Length != 11)
				return false;

			var digito = numero.Substring(9, 2);

			numero = numero.Substring(0, 9);
			numero += GerarDigito(numero);
			numero += GerarDigito(numero);

			return digito == numero.Substring(9, 2);
		}

		private static bool ValidarCnpj(string numero)
		{
			var digito = numero.Substring(12, 2);

			numero = numero.Substring(0, 12);
			numero += GerarDigito(numero);
			numero += GerarDigito(numero);

			return digito == numero.Substring(12, 2);
		}

		private static string GerarDigito(string numero)
		{
			var peso = 2;
			var soma = 0;

			var cnpj = numero.Length > 11;

			for (var i = numero.Length - 1; i >= 0; i--)
			{
				soma += peso * Convert.ToInt32(numero[i].ToString());
				peso++;

				if (cnpj && peso == 10)
					peso = 2;
			}

			var digito = 11 - soma % 11;
			if (digito > 9)
				digito = 0;

			return digito.ToString();
		}
	}
}