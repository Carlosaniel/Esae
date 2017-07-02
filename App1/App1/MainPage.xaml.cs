using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Net;

using Xamarin.Forms.Xaml;
using App1.Controllers;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        CursoController cursos;
        AvisoController avisos;

        public MainPage()
        {
            InitializeComponent();

            cursos = new CursoController(); //inicia o controller de cursos
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //PUSH (adiciona à pilha) e o POP (remove da pilha)
            ListaMestradosPage lmp = new ListaMestradosPage(cursos); //cria a página adicionar
            Navigation.PushModalAsync(lmp);//adiciona a página à pilha
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Log l = new Log();
            Navigation.PushModalAsync(l);
        }

		private void Button_Clicked_3(object sender, EventArgs e)
		{
            ListaAvisosPage lap = new ListaAvisosPage(avisos); //cria a página adicionar
            Navigation.PushModalAsync(lap);

        }


		private void Button_Clicked_4(object sender, EventArgs e)
		{
		}

    }
}
