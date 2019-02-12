using System;
using System.Windows.Forms;

namespace PersonalizarFormulario
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            txtVisor.Text += ((Button) sender).Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double valor1 = 0;
            double resultado = 0;
            var operador = "+";

            //1+2+1+3
 
            for (var i = 0; i < txtVisor.Text.Length; i++)

                switch (txtVisor.Text.Substring(i, 1))
                {
                    case "+":
                        operador = "+";
                        break;
                    case "-":
                        operador = "-";
                        break;
                    case "*":
                        operador = "*";
                        break;
                    case "/":
                        operador = "/";
                        break;

                    default:
                        if (valor1 == 0)
                        {
                            double.TryParse(txtVisor.Text.Substring(i, 1), out valor1);
                        }
                        else
                        {
                            double.TryParse(txtVisor.Text.Substring(i, 1), out var valor2);

                            resultado = Calcular(valor1, valor2, operador);
                            valor1 = resultado;
                        }
                        break;
                }

            txtVisor.Text = resultado.ToString();
        }

        private double Calcular(double valor1, double valor2, string operacao)
        {
            switch (operacao)
            {
                case "+":
                    return valor1 + valor2;

                case "-":
                    return valor1 - valor2;

                case "*":
                    return valor1 * valor2;
                case "/":
                    return valor1 / valor2;
            }

            return 0;
        }
    }
}