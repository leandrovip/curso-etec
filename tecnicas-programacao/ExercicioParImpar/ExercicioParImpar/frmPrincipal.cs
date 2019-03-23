using System;
using System.Windows.Forms;

namespace ExercicioParImpar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (!SeValido()) return;

            decimal.TryParse(txtValor.Text, out var valor);

            MessageBox.Show(valor % 2 == 0 ? "Número PAR" : "Número ÍMPAR", "Resultado", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtValor.SelectAll();
            txtValor.Focus();
        }

        private bool SeValido()
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Informe o número desejado e tente novamente;", "Par/Ímpar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtValor.SelectAll();
                txtValor.Focus();
                return false;
            }

            decimal.TryParse(txtValor.Text, out var resultado);
            if (resultado == 0)
            {
                MessageBox.Show("Informe o número válido e tente novamente;", "Par/Ímpar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtValor.SelectAll();
                txtValor.Focus();
                return false;
            }

            return true;
        }
    }
}