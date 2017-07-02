using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Noticias : ContentPage
    {
        public Noticias()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //PUSH (adiciona à pilha) e o POP (remove da pilha)
            MainPage sp = new MainPage(); //cria a página adicionar
            Navigation.PushModalAsync(sp); //adiciona a página à pilha
        }
    }
}