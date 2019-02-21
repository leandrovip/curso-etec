using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
        ///     valor1 = Valor informado para operação
        ///     resultado = Guarda o valor da soma entre os valores contidos na lista.
        ///     operador = Guarda o operador desejado para o cálculo
        ///     ListaValores = Guarda os valores e operações digitadas anteriormente
        /// </summary>
        public decimal valor1;
        public decimal resultado;
        public string operador;
        public List<Tuple<decimal, string>> ListaValores = new List<Tuple<decimal, string>>();

        public frmCalculadora()
        {
            InitializeComponent();

            foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Color.LightCoral;
                button.FlatAppearance.BorderColor = Color.LightCoral;
                button.ForeColor = Color.White;
            }

            dgHistorico.AutoGenerateColumns = true;

        }

        /// <summary>
        ///     Método em comum para todos os TextBox do 'tipo' número. Ao clicar adiciona o 'número' + o que já estiver
        ///     digitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Numero(object sender, EventArgs e)
        {
            if (valor1 != 0 || txtResultado.Text == "0")
            {
                txtResultado.Text = "";
                valor1 = 0;
            }

            txtResultado.Text += ((Button) sender).Text;
        }

        /// <summary>
        ///     Método em comum para todos os tipos de operadores. Ao clicar no botão guarda o valor e o tipo de operação. Caso já
        ///     haja
        ///     valores na lista, realiza a sub soma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Operador(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
                return;

            valor1 = decimal.Parse(txtResultado.Text);
            operador = ((Button) sender).Text;

            ListaValores.Add(new Tuple<decimal, string>(valor1, operador));
            dgHistorico.DataSource = null;
            dgHistorico.DataSource = ListaValores;

            dgHistorico.Columns[0].HeaderText = "Valor";
            dgHistorico.Columns[1].HeaderText = "Operação";
            dgHistorico.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgHistorico.Refresh();

            if (ListaValores.Count > 1)
            {
                CalcularListaResultado();
                return;
            }

            txtResultado.Text = "";
        }

        private void CalcularListaResultado()
        {
            txtResultado.Text = CalcularLista().ToString();
        }

        private decimal CalcularLista()
        {
            decimal valorLista = 0;
            resultado = 0;

            foreach (Tuple<decimal, string> t in ListaValores)
            {
                if (valorLista == 0)
                {
                    valorLista = t.Item1;
                    operador = t.Item2;
                }
                else
                {
                    switch (operador)
                    {
                        case "+":
                            resultado += valorLista + t.Item1; 
                            break;

                        case "-":
                            resultado += valorLista - t.Item1;
                            break;

                        case "*":
                            resultado += valorLista * t.Item1;
                            break;

                        case "/":
                            resultado += valorLista / t.Item1;
                            break;
                    }

                    valorLista = 0;
                    operador = t.Item2;
                }
            }

            return resultado == 0 ? valorLista : resultado;
        }

        /// <summary>
        ///     Botão IGUAL realiza a soma de todos os valores listados mais o valor digitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtResultado.Text))
                return;

            var valor2 = decimal.Parse(txtResultado.Text);
            resultado = CalcularLista();

            switch (operador)
            {
                case "+":
                    resultado += valor2;
                    break;

                case "-":
                    resultado -= valor2;
                    break;

                case "*":
                    resultado *= valor2;
                    break;

                case "/":
                    resultado /= valor2;
                    break;
            }

            ListaValores.Clear();
            dgHistorico.DataSource = null;
            txtResultado.Text = resultado.ToString();
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
            ListaValores.Clear();
            txtResultado.Text = string.Empty;
            dgHistorico.DataSource = null;
        }

        /// <summary>
        ///     Configura atalhos para os botões de operação e resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCalculadora_KeyDown(object sender, KeyEventArgs e)
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
                case Keys.NumPad1:
                case Keys.D1:
                    Button_Numero(btn1, e);
                    break;
                case Keys.NumPad2:
                case Keys.D2:
                    Button_Numero(btn2, e);
                    break;
                case Keys.NumPad3:
                case Keys.D3:
                    Button_Numero(btn3, e);
                    break;
                case Keys.NumPad4:
                case Keys.D4:
                    Button_Numero(btn4, e);
                    break;
                case Keys.NumPad5:
                case Keys.D5:
                    Button_Numero(btn5, e);
                    break;
                case Keys.NumPad6:
                case Keys.D6:
                    Button_Numero(btn6, e);
                    break;
                case Keys.NumPad7:
                case Keys.D7:
                    Button_Numero(btn7, e);
                    break;
                case Keys.NumPad8:
                case Keys.D8:
                    Button_Numero(btn8, e);
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    Button_Numero(btn9, e);
                    break;
                case Keys.NumPad0:
                case Keys.D0:
                    Button_Numero(btn0, e);
                    break;
                case Keys.Back:
                    if (string.IsNullOrEmpty(txtResultado.Text))
                        return;

                    txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
                    if (string.IsNullOrEmpty(txtResultado.Text))
                        txtResultado.Text = "0";

                    break;
            }

            e.SuppressKeyPress = true;
        }
    }
}