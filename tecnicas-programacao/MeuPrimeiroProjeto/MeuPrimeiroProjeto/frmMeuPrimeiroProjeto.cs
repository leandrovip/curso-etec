using System;
using System.Windows.Forms;

namespace MeuPrimeiroProjeto
{
    public partial class frmMeuPrimeiroProjeto : Form
    {
        public frmMeuPrimeiroProjeto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = $"{txtPrimeiroNome.Text.Trim()} {txtSobrenome.Text.Trim()}";

            MessageBox.Show($"O resultado é {txtResultado.Text}", "Meu primeiro projeto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}