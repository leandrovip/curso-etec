using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CadastroCliente
{
	public partial class frmPrincipal : Form
	{
		#region Propriedades

		#endregion

		#region Construtores

		public frmPrincipal()
		{
			InitializeComponent();
		}

		#endregion

		#region Eventos

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			cboTipoCliente.SelectedIndex = 0;
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboTipoCliente.Text == "Pessoa Física")
			{
				lblDocumento.Text = "CPF";
				mskDocumento.Tag = "CPF";
				lblNome.Text = "Nome";
				txtNome.Tag = "Nome";
				mskDocumento.Mask = "###.###.###-##";
			}
			else
			{
				lblDocumento.Text = "CNPJ";
				mskDocumento.Tag = "CNPJ";
				lblNome.Text = "Razão Social";
				txtNome.Tag = "Razão Social";
				mskDocumento.Mask = "##.###.###/####-##";
			}
		}

		private void mskDocumento_Leave(object sender, EventArgs e)
		{
			if (mskDocumento.Text.OnlyNumbers().IsNullOrEmpty())
				return;

			if (!Documento.Validar(mskDocumento.Text))
			{
				Mensagem("Número de documento inválido!", "Validação Documento");
				mskDocumento.Text = "";
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			#region Validações

			if (!SeCamposValidos())
				return;

			#endregion

			Mensagem("Cadastro realizado com sucesso!", "Cadastro de Cliente");
			LimparCampos();
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			LimparCampos();
		}

		#endregion

		#region Métodos

		private bool SeCamposValidos()
		{
			var mensagemValidacao = new List<string>();

			foreach (var textBox in Controls.OfType<TextBox>().OrderBy(x => x.TabIndex))
				if (textBox.Text.IsNullOrEmpty())
					mensagemValidacao.Add(textBox.Tag.ToString());

			foreach (var campo in Controls.OfType<MaskedTextBox>())
				if (campo.Text.OnlyNumbers().IsNullOrEmpty())
					mensagemValidacao.Add(campo.Tag.ToString());

			if (mensagemValidacao.Any())
			{
				Mensagem($"Verifique os campos abaixo:\r\n\r\n {string.Join(", ", mensagemValidacao)}", "Validação");
				return false;
			}

			return true;
		}

		private void LimparCampos()
		{
			foreach (var textBox in Controls.OfType<TextBox>())
				textBox.Text = "";

			foreach (var mskBox in Controls.OfType<MaskedTextBox>())
				mskBox.Text = "";

			cboTipoCliente.SelectedIndex = 0;
			dtpDataNascimento.Value = DateTime.Now;
			txtNome.Focus();
		}

		private void Mensagem(string mensagem, string titulo)
		{
			MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		#endregion
	}
}

// Requisitos

/*
 * ComboBox deve conter opções de Pessoa Física ou Jurídica - OK
 * Caso seja selecionado Física o campo CPF/CNPJ deverá aparecer a Label de acordo com o selecionado, a mascara deve ser de acordo também. - OK
 * Validador de CPF e CNPJ devem estar em uma classe, utilizar Array e laço de repetição. - OK
 * Validar se todos os campos estáo digitados. - OK
 * Se digitados, exibir mensagem de "Cadastro realizado com suceeso" e limpar as caixas. - OK
 * Exibição de mensagem devem estar em um método. - OK

	*/