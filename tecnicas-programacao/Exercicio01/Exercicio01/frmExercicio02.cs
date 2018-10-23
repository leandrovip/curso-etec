using System;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class frmExercicio02 : Form
    {
        public frmExercicio02()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(txtNumero1.Text);
            decimal numero2 = Convert.ToDecimal(txtNumero2.Text);
            decimal numero3 = Convert.ToDecimal(txtNumero3.Text);

            decimal resultado = (numero1 + numero2 + numero3) / 3;

            if (resultado >= 6)
            {
                MessageBox.Show($"Média: {resultado} \r\n\r\n APROVADO!");
            }
            else
            {
                MessageBox.Show($"Média: {resultado} \r\n\r\n REPROVADO!");
            }
        }
    }
}