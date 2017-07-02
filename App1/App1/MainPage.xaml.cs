using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //PUSH (adiciona à pilha) e o POP (remove da pilha)
            Mestrados sp = new Mestrados(); //cria a página adicionar
            Navigation.PushModalAsync(sp); //adiciona a página à pilha
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Posgraduacoes sp = new     Posgraduacoes(); 
            Navigation.PushModalAsync(sp); 
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Log sp = new Log();
            Navigation.PushModalAsync(sp);
        }

		private void Button_Clicked_3(object sender, EventArgs e)
		{
            Noticias sp = new Noticias();
			Navigation.PushModalAsync(sp);
		}


		private void Button_Clicked_4(object sender, EventArgs e)
		{
            Eventos sp = new Eventos();
			Navigation.PushModalAsync(sp);
		}
    }
}
