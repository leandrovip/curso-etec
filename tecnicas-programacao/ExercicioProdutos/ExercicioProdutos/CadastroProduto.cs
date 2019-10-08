using System;
using System.Linq;
using System.Windows.Forms;

namespace ExercicioProdutos
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja finalizar o sistema?", "Sair...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            #region Validação

            if (!SeCamposPreenchidos())
            {
                MessageBox.Show("Preencha todos os campos e tente novamente.", "Exercício Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            #endregion

            var negocio = new NegocioProduto();
            var resultado = negocio.InserirProduto(txtCodigoBarras.Text, txtDescricao.Text, txtValorCusto.Text.ToDecimal(), txtValorVenda.Text.ToDecimal());

            if (!resultado)
            {
                MessageBox.Show("Erro ao salvar produto. Por favor, tente novamente", "Exercício Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Produto salvo com sucesso!", "Exercício Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void LimparCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }

        private bool SeCamposPreenchidos()
        {
            var result = true;

            foreach (var textBox in Controls.OfType<TextBox>())
                if (textBox.Text.IsNullOrEmpty())
                    result = false;

            return result;
        }
    }
}