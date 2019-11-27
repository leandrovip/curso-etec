using System;
using System.Reactive.Linq;
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            var observer = Observable.Interval(TimeSpan.FromSeconds(5))
                    .Do((x) => Teste());

            observer.Subscribe((x) =>
            {
                Console.WriteLine($"teste {x}");
            });
        }

        private void Teste()
        {
            MessageBox.Show(DateTime.Now.ToString());
        }
    }
}