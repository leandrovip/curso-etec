using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ValidadorCNPJ
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            txtValor.Text = OnlyNumbers(txtValor.Text.Trim());

            if (ValidarCnpj(txtValor.Text))
                MessageBox.Show("CNPJ válido! :)", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("CNPJ inválido! :(", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            txtValor.SelectAll();
            txtValor.Focus();
        }

        private bool ValidarCnpj(string valor)
        {
            #region Validações

            if (string.IsNullOrEmpty(valor))
                return false;

            valor = OnlyNumbers(valor);
            if (valor.Length != 14)
                return false;

            #endregion

            var listaDigito1 = new[] {5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};
            var listaDigito2 = new[] {6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};

            var digito1 = CalculateDigits(listaDigito1, valor);
            var digito2 = CalculateDigits(listaDigito2, valor);

            return valor.Substring(12, 2) == $"{digito1}{digito2}";
        }

        private int CalculateDigits(IEnumerable<int> lista, string valor)
        {
            var soma = 0;
            var i = 0;

            foreach (var numero in lista)
            {
                soma += int.Parse(valor[i].ToString()) * numero;
                i++;
            }

            var resultado = soma % 11;
            if (resultado < 2)
                return 0;

            return 11 - resultado;
        }

        private string OnlyNumbers(string value)
        {
            return string.IsNullOrEmpty(value) ? "" : new string(value.Where(char.IsDigit).ToArray());
        }
    }
}