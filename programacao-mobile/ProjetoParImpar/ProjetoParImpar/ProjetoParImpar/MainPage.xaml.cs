using System;
using Xamarin.Forms;

namespace ProjetoParImpar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnValidar_OnClicked(object sender, EventArgs e)
        {
            int.TryParse(txtValor.Text, out var valor);
            var mensagem = valor % 2 == 0 ? "Número Par" : "Número Ímpar";

            DisplayAlert("Resultado", mensagem, "Voltar");
        }
    }
}