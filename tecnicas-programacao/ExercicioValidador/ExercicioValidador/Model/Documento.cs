using System;
using ExercicioValidador.Utils;

namespace ExercicioValidador.Model
{
    public class Documento
    {
        #region Propriedades

        public string Numero { get; private set; }

        public string MensagemRetorno { get; private set; }

        public bool Valido { get; private set; }

        #endregion

        #region Construtores

        public Documento(string numero)
        {
            Numero = numero.OnlyNumbers();
            Validar();
        }

        #endregion

        #region Métodos

        private void Validar()
        {
            Valido = true;

            if (Numero.IsNullOrEmpty()) Numero = "0";

            if (Numero.Length > NumeroMaxLength)
            {
                MensagemRetorno = $"O campo Cpf ou Cnpj deve ter no máximo {NumeroMaxLength} caracteres";
                Valido = false;
            }

            if (!ValidarNumero(Numero))
            {
                MensagemRetorno = "CPF ou CNPJ inválido.";
                Valido = false;
            }
        }

        public string FormatarNumero()
        {
            if (Numero.IsNullOrEmpty())
                return string.Empty;

            var tempNumero = Numero.OnlyNumbers();
            switch (tempNumero.Length)
            {
                case 11:
                    return Convert.ToInt64(tempNumero).ToString(@"000\.000\.000\-00");
                case 14:
                    return Convert.ToInt64(tempNumero).ToString(@"00\.000\.000\/0000\-00");
                default:
                    return Numero;
            }
        }

        #endregion

        #region Constantes

        public const int NumeroMaxLength = 20;

        #endregion

        #region Métodos Estáticos

        public static bool ValidarNumero(string numero)
        {
            if (numero.IsNullOrEmpty())
                return false;

            numero = numero.OnlyNumbers();
            return numero.Length == 14 ? ValidarCnpj(numero) : ValidarCpf(numero);
        }

        private static bool ValidarCnpj(string numero)
        {
            var digito = numero.Substring(12, 2);

            numero = numero.Substring(0, 12);
            numero += GerarDigito(numero);
            numero += GerarDigito(numero);

            return digito == numero.Substring(12, 2);
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

        #endregion
    }
}