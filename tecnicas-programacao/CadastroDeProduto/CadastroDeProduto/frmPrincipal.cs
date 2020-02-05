using System;
using System.Reactive.Linq;
using System.Windows.Forms;
using DFeBR.EmissorNFe;
using DFeBR.EmissorNFe.Builders;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Configurar;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Enderecador;
using DFeBR.EmissorNFe.Dominio.NotaFiscalEletronica.Informacoes.Emitente;
using DFeBR.EmissorNFe.Servicos.VersaoNFe4;
using DFeBR.EmissorNFe.Utilidade;
using DFeBR.EmissorNFe.Utilidade.Entidades;
using DFeBR.EmissorNFe.Utilidade.Tipos;

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
            //var observer = Observable.Interval(TimeSpan.FromSeconds(5))
            //    .Do(x => Teste());

            //observer.Subscribe(x =>
            //{
            //    Console.WriteLine($"teste {x}");
            //});
        }

        private void Teste()
        {
            MessageBox.Show(DateTime.Now.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var certificado = Certificado.ListareObterDoRepositorio();

            var config = new EmissorServicoConfig(VersaoServico.Ve400, Estado.Sp, TipoAmbiente.Homologacao, IndicadorSincronizacao.Assincrono);
            
            config.ConfiguraEmitente("12332134000199", "","LEANDRO DOS SANTOS FERREIRA INFORMATICA ME", "VIP SOLUCOES",
                "715025640119","", "", "", CRT.SimplesNacional, "AV RUI BARBOSA", "489", "", "CENTRO", 3556800, "VIRADOURO",
                "SP", "14740000", null);

            config.ConfiguraCertificadoA3("1234");
            config.Certificado.ManterDadosEmCache = true;
            config.Certificado.Serial = certificado.SerialNumber;
            config.ConfiguraArquivoRetorno(false, "D:\\");

            var servicos = new ServNFe4(config);
            var retorno = servicos.ConsultarStatus();

            var nfe = new NFeBuilder();


            servicos.Autorizar()
                
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var teste = Certificado.ListareObterDoRepositorio();

            MessageBox.Show("");
        }
    }
}