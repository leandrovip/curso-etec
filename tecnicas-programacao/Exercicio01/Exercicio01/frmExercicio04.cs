using System;
using System.Linq;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class frmExercicio04 : Form
    {
        // Faça um algorítimo que leia 3 números inteiros e mostre o menor deles.

        public frmExercicio04()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt16(txtNumero1.Text);
            int numero2 = Convert.ToInt16(txtNumero2.Text);
            int numero3 = Convert.ToInt16(txtNumero3.Text);

            var listNumeros = new[]
            {
                numero1, numero2, numero3
            };

            txtMenorNumero.Text = listNumeros.Min().ToString();
        }
    }
}