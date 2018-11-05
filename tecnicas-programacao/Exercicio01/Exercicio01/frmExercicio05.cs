using System;
using System.Windows.Forms;

namespace Exercicio01
{
    /*  Elabore um algoritimo que dada a idade de um nadador classifica-o em uma das
        seguintes categorias:

        infantil A = 5-7 anos
        infantil B = 8-10 anos
        juvenil A = 11-13 anos
        juvenil B = 14-17 anos
        adulto = maiores de 18 anos
    */

    public partial class frmExercicio05 : Form
    {
        public frmExercicio05()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var idade = int.Parse(txtIdade.Text);
            var categoria = "";

            if (idade >= 5 && idade <= 7)
                categoria = "Infantil A";
            else if (idade >= 8 && idade <= 10)
                categoria = "Infantil B";
            else if (idade >= 11 && idade <= 13)
                categoria = "Juvenil A";
            else if (idade >= 14 && idade <= 17)
                categoria = "Juvenil B";
            else if (idade >= 18 && idade <= 90)
                categoria = "Adulto";
            else
                categoria = "Inválido";

            txtResultado.Text = categoria;
        }
    }
}