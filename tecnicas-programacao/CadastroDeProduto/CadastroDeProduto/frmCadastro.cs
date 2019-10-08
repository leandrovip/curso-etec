using System;
using System.Linq;
using System.Windows.Forms;

namespace CadastroDeProduto
{
    public partial class frmCadastro : Form
    {
        #region Propriedades

        private string _mensagemErro = "";

        #endregion

        #region Construtores

        public frmCadastro()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja limpar os campos?", "Cadastro de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No) return;

            LimparCampos();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!SeValido())
            {
                MessageBox.Show(_mensagemErro, "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja realmente inserir o registro?", "Cadastro de Produto", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No) return;

            var service = new Service();
            var result = service.InserirProduto(txtCodigo.Text, txtDescricao.Text, txtMedida.Text, txtValorCusto.Text.ToDecimal(),
                txtValorVenda.Text.ToDecimal(), txtEstoque.Text.ToDecimal(), txtObservacao.Text);

            if (!result)
            {
                MessageBox.Show("Erro ao inserir o Produto desejado!", "Cadastro de Produtos");
                return;
            }

            MessageBox.Show("Produto inserido com sucesso!", "Cadastro de Produtos");
            LimparCampos();
        }

        #endregion

        #region Métodos

        private bool SeValido()
        {
            _mensagemErro = "";

            if (txtCodigo.Text.IsNullOrEmpty()) _mensagemErro += "Código\r\n";
            if (txtDescricao.Text.IsNullOrEmpty()) _mensagemErro += "Descrição do Produto\r\n";
            if (txtMedida.Text.IsNullOrEmpty()) _mensagemErro += "Medida\r\n";
            if (!txtValorCusto.Text.IsDecimal()) _mensagemErro += "R$ Custo\r\n";
            if (!txtValorVenda.Text.IsDecimal()) _mensagemErro += "R$ Venda\r\n";
            if (!txtEstoque.Text.IsDecimal()) _mensagemErro += "Estoque\r\n";
            if (txtObservacao.Text.IsNullOrEmpty()) _mensagemErro += "Observação\r\n";

            if (!_mensagemErro.IsNullOrEmpty())
            {
                _mensagemErro = "Verifique os campos abaixo:\r\n\r\n" + _mensagemErro;
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = "";
                txtCodigo.Focus();
            }
        }

        #endregion
    }
}