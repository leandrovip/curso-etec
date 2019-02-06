using System;
using System.Windows.Forms;

namespace Calculadora
{
    /// <summary>
    ///     Desenvolvido por Leandro Ferreira
    ///     Email: oi@leandro.in
    /// </summary>
    public partial class frmCalculadora : Form
    {
        /// <summary>
        ///     Váriaveis utilizadas.
        ///     valor1 = Primeiro valor do cálculo
        ///     valor2 = Segundo valor do cálculo
        ///     operador = Guarda o operador desejado para o cálculo
        /// </summary>
        public decimal valor1;

        public decimal valor2;
        public string operador;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Método em comum para todos os TextBox do 'tipo' número. Ao clicar adiciona o 'número' + o que já estiver
        ///     digitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Numero(object sender, EventArgs e)
        {
            txtResultado.Text += ((Button) sender).Text;
            ManterFoco();
        }

        /// <summary>
        ///     Método em comum para todos os tipos de operadores. Ao clicar no botão guarda o primeiro valor do calculo
        ///     juntamente com o tipo de operação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Operador(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
                return;

            valor1 = decimal.Parse(txtResultado.Text);
            operador = ((Button) sender).Text;
            txtResultado.Text = string.Empty;

            ManterFoco();
        }

        /// <summary>
        ///     Botão IGUAL realiza a captura do segundo valor e efetua o calculo com base no tipo de operador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
                return;

            valor2 = decimal.Parse(txtResultado.Text);

            switch (operador)
            {
                case "+":
                    txtResultado.Text = $"{valor1 + valor2}";
                    break;

                case "-":
                    txtResultado.Text = $"{valor1 - valor2}";
                    break;

                case "*":
                    txtResultado.Text = $"{valor1 * valor2}";
                    break;

                case "/":
                    txtResultado.Text = $"{valor1 / valor2}";
                    break;
            }
        }

        /// <summary>
        ///     Limpa as váriaveis para um novo cálculo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            operador = "";
            valor1 = 0m;
            valor2 = 0m;
            txtResultado.Text = string.Empty;
        }

        /// <summary>
        ///     Método para manter o foco do campo txtResultado sempre na última coluna
        ///     permitindo a continuidade da digitação.
        /// </summary>
        private void ManterFoco()
        {
            txtResultado.Focus();
            txtResultado.DeselectAll();
            txtResultado.SelectionStart = txtResultado.TextLength;
        }

        /// <summary>
        ///     Válida o campo txtResultado para aceitar somente números.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            var caracteres = "";

            foreach (var item in txtResultado.Text.ToCharArray())
                if (char.IsDigit(item))
                    caracteres += item;

            txtResultado.Text = caracteres;
            ManterFoco();
        }

        /// <summary>
        ///     Configura atalhos para os botões de operação e resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtResultado_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    Button_Operador(btnAdicao, e);
                    break;
                case Keys.Subtract:
                    Button_Operador(btnSubtracao, e);
                    break;
                case Keys.Multiply:
                    Button_Operador(btnMultiplicacao, e);
                    break;
                case Keys.Divide:
                    Button_Operador(btnDivisao, e);
                    break;
                case Keys.Enter:
                    btnIgual.PerformClick();
                    break;
                case Keys.Escape:
                    btnLimpar.PerformClick();
                    break;
            }
        }
    }
}