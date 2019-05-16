using System;
using System.Windows.Forms;

namespace ExercicioMetodos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            var hora = dtpHorario.Value.Hour;
            VerificarHorario(hora);
        }

        private void VerificarHorario(int hora)
        {
            if (hora >= 18)
                Mensagem("Boa Noite :)");
            else if (hora >= 12)
                Mensagem("Boa Tarde :P");
            else
                Mensagem("Bom dia Maluco!");
        }

        private void Mensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Olá! :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}