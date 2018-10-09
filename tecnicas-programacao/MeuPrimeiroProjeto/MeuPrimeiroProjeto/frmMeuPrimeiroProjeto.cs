using System;
using System.Globalization;
using System.Windows.Forms;

namespace MeuPrimeiroProjeto
{
    public partial class frmMeuPrimeiroProjeto : Form
    {
        public frmMeuPrimeiroProjeto()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = $"{txtPalavra1.Text.Trim()} {txtPalavra2.Text.Trim()}";

            MessageBox.Show($"O resultado é {txtResultado.Text}", "Meu primeiro projeto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            var valor1 = Convert.ToDouble(txtPalavra1.Text);
            var valor2 = Convert.ToDouble(txtPalavra2.Text);

            txtResultado.Text = (valor1 + valor2).ToString(CultureInfo.CurrentCulture);
        }
    }
}