using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public decimal valor1;
        public decimal valor2;
        public string operador;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void TextBox_Numero(object sender, EventArgs e)
        {
            txtResultado.Text += ((Button) sender).Text;
        }

        private void TextBox_Operador(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
                return;

            valor1 = decimal.Parse(txtResultado.Text);
            operador = ((Button) sender).Text;

            txtResultado.Text = string.Empty;
        }

        private void txtIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
                return;

            valor2 = decimal.Parse(txtResultado.Text);

            switch (operador)
            {
                case "+":
                    txtResultado.Text = (valor1 + valor2).ToString();
                    break;

                case "-":
                    txtResultado.Text = (valor1 - valor2).ToString();
                    break;

                case "*":
                    txtResultado.Text = (valor1 * valor2).ToString();
                    break;

                case "/":
                    txtResultado.Text = (valor1 / valor2).ToString();
                    break;
            }
        }

        private void txtLimpar_Click(object sender, EventArgs e)
        {
            operador = "";
            valor1 = 0m;
            valor2 = 0m;
            txtResultado.Text = string.Empty;
        }
    }
}