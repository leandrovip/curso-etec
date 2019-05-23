// Leandro Ferreira
// www.github.com/leandrovip

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class frmPrincipal : Form
    {
        #region Propriedades

        private string _ultimoJogador = "";
        private int _jogadasRestantes = 9;

        #endregion

        #region Construtor

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja iniciar um novo Jogo ?", "Jogo da Velha", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                BloquearBotoes();
                return;
            }

            lblJogador.Text = "X";
            _jogadasRestantes = 9;
            _ultimoJogador = "";
            LimparBotoes();
        }

        private void btnJogo_Click(object sender, EventArgs e)
        {
            var botao = (Button) sender;
            botao.Text = _ultimoJogador == "X" ? "O" : "X";
            botao.Enabled = false;
            _ultimoJogador = botao.Text;
            lblJogador.Text = _ultimoJogador == "X" ? "O" : "X";
            _jogadasRestantes -= 1;

            if (TemVencedor())
            {
                MessageBox.Show($"O Jogador {_ultimoJogador} venceu! Parabéns :)", "Aê sim", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnIniciar.PerformClick();
                return;
            }

            if (_jogadasRestantes == 0)
            {
                MessageBox.Show("Ninguém venceu! Amebas!", "Que feio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIniciar.PerformClick();
            }
        }

        #endregion

        #region Métodos

        private void LimparBotoes()
        {
            foreach (var button in Controls.OfType<Button>())
                if (button.Tag != null)
                {
                    button.Text = "";
                    button.BackColor = Color.FromArgb(241, 196, 15);
                    button.Enabled = true;
                }
        }

        private void BloquearBotoes()
        {
            foreach (var button in Controls.OfType<Button>())
                if (button.Tag != null)
                    button.Enabled = false;
        }

        private void MarcarVencedor(IReadOnlyList<string> indices)
        {
            foreach (var button in Controls.OfType<Button>())
                if (button.Tag != null)
                    for (var i = 0; i < 3; i++)
                        if (button.Name == $"btn{indices[i]}")
                            button.BackColor = Color.FromArgb(46, 204, 113);
        }

        private bool TemVencedor()
        {
            if (VerificaDiagonal() || VerificaHorizontal() || VerificaVertical())
                return true;

            return false;
        }

        private bool VerificaHorizontal()
        {
            if (btn1.Text == _ultimoJogador && btn2.Text == _ultimoJogador && btn3.Text == _ultimoJogador)
            {
                MarcarVencedor(new[] {"1", "2", "3"});
                return true;
            }

            if (btn4.Text == _ultimoJogador && btn5.Text == _ultimoJogador && btn6.Text == _ultimoJogador)
            {
                MarcarVencedor(new[] {"4", "5", "6"});
                return true;
            }

            if (btn7.Text == _ultimoJogador && btn8.Text == _ultimoJogador && btn9.Text == _ultimoJogador)
            {
                MarcarVencedor(new[] {"7", "8", "9"});
                return true;
            }

            return false;
        }

        private bool VerificaVertical()
        {
            if (btn1.Text == _ultimoJogador && btn4.Text == _ultimoJogador && btn7.Text == _ultimoJogador)
            {
                MarcarVencedor(new[] {"1", "4", "7"});
                return true;
            }

            if (btn2.Text == _ultimoJogador && btn5.Text == _ultimoJogador && btn8.Text == _ultimoJogador)
            {
                MarcarVencedor(new[] {"2", "5", "8"});
                return true;
            }

            if (btn3.Text == _ultimoJogador && btn6.Text == _ultimoJogador && btn9.Text == _ultimoJogador)
            {
                MarcarVencedor(new[] {"3", "6", "9"});
                return true;
            }

            return false;
        }

        private bool VerificaDiagonal()
        {
            if (btn1.Text == _ultimoJogador && btn5.Text == _ultimoJogador && btn9.Text == _ultimoJogador)
            {
                MarcarVencedor(new[] {"1", "5", "9"});
                return true;
            }

            if (btn3.Text == _ultimoJogador && btn5.Text == _ultimoJogador && btn7.Text == _ultimoJogador)
            {
                MarcarVencedor(new[] {"3", "5", "7"});
                return true;
            }

            return false;
        }

        #endregion
    }
}