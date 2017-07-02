using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Controllers;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mestrados : ContentPage
    {
        CursoController cursos;
        private string teste;

        public Mestrados(CursoController _cursos)
        {
            InitializeComponent();

            cursos = _cursos;
            exemplo.ItemsSource = cursos.ListaCursos; //adiciona os objetos à listview
        }
    }
}
