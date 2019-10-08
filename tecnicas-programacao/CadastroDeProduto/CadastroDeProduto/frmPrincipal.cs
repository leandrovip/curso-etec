using System;
using System.Windows.Forms;

namespace CadastroDeProduto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente finalizar o sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new frmCadastro())
                form.ShowDialog();
        }
    }
}