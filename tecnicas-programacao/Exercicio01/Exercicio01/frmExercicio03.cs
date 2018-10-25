using System;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class frmExercicio03 : Form
    {
        // Faça um algoritimo para ler a base e a altura de um triângulo. Em seguida, escreva
        // a sua área.

        public frmExercicio03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var valorBase = Convert.ToDecimal(txtBase.Text);
            var valorAltura = Convert.ToDecimal(txtAltura.Text);

            var areaTriangulo = valorBase * valorAltura / 2;

            txtArea.Text = areaTriangulo.ToString();
        }
    }
}