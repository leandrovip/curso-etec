/*
  Desenvolvido por:
  
  Leandro Ferreira
  3º DS - Viradouro
  leandro@vipsolucoes.com
*/

using System;
using System.Windows.Forms;
using ExercicioValidador.Data;
using ExercicioValidador.Model;
using ExercicioValidador.Utils;

namespace ExercicioValidador
{
    public partial class frmPrincipal : Form
    {
        #region Construtores

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Preencha o campo e tente novamente.", "Validador de Documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.SelectAll();
                txtValor.Focus();
                return;
            }

            var documento = new Documento(txtValor.Text);
            txtValor.Text = documento.Numero;

            try
            {
                var service = new DocumentoService();
                service.InserirRegistro(
                    documento.Numero,
                    documento.Valido,
                    documento.Valido ? "Documento válido!" : documento.MensagemRetorno);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}\r\n\r\nVerifique e tente novamente", "Erro na execução do sistema");
                return;
            }

            if (!documento.Valido)
            {
                MessageBox.Show(documento.MensagemRetorno, "Validador de documento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.SelectAll();
                txtValor.Focus();
                return;
            }

            txtValor.Text = documento.FormatarNumero();
            MessageBox.Show("Documento válido!", "Validador de documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtValor.SelectAll();
            txtValor.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}