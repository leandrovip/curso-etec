using System;
using System.Windows.Forms;

namespace Navegador
{
    public partial class frmNavegador : Form
    {
        public frmNavegador()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            var enderecoUrl = txtEndereco.Text.Trim();

            if (string.IsNullOrEmpty(enderecoUrl))
            {
                MessageBox.Show("Informe o endereço e tente novamente.", "Navegador", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!enderecoUrl.Contains("http://"))
                enderecoUrl = "http://" + enderecoUrl;

            webBrowser.Url = new Uri(enderecoUrl);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void txtEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIr.PerformClick();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void frmNavegador_Load(object sender, EventArgs e)
        {
            btnIr.PerformClick();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}