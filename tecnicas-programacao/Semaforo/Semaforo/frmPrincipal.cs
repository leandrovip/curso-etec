using System;
using System.Windows.Forms;
using Semaforo.Properties;

namespace Semaforo
{
    public partial class frmPrincipal : Form
    {
        private int tempo = 10;
        private Cor CorSemaforo = Cor.Vermelho;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ptbSemaforo.Image = Resources.semaforo_vermelho;
            lblTempo.Text = "00";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo--;
            lblTempo.Text = tempo.ToString("00");

            if (tempo == 0)
                switch (CorSemaforo)
                {
                    case Cor.Vermelho:
                        MudarSemaforo(Cor.Verde);
                        break;
                    case Cor.Amarelo:
                        MudarSemaforo(Cor.Vermelho);
                        break;
                    case Cor.Verde:
                        MudarSemaforo(Cor.Amarelo);
                        break;
                }
        }

        private void MudarSemaforo(Cor cor)
        {
            switch (cor)
            {
                case Cor.Vermelho:
                    ptbSemaforo.Image = Resources.semaforo_vermelho;
                    CorSemaforo = Cor.Vermelho;
                    lblTempo.Text = "10";
                    tempo = 10;
                    break;
                case Cor.Amarelo:
                    ptbSemaforo.Image = Resources.semaforo_amarelo;
                    CorSemaforo = Cor.Amarelo;
                    lblTempo.Text = "04";
                    tempo = 4;
                    break;
                case Cor.Verde:
                    ptbSemaforo.Image = Resources.semaforo_verde;
                    CorSemaforo = Cor.Verde;
                    lblTempo.Text = "10";
                    tempo = 10;
                    break;
            }
        }
    }
}