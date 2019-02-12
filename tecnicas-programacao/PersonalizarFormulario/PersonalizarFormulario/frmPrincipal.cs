using System.Windows.Forms;

namespace PersonalizarFormulario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (var form = new frmCalculadora())
            {
                form.ShowDialog();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente finalizar o sistema?", "Sair", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;

            Application.Exit();
        }
    }
}