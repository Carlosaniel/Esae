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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaMestradosPage : ContentPage
    {
        CursoController cursos;
        private string teste;

        public ListaMestradosPage(CursoController _cursos)
        {
            InitializeComponent();

            cursos = _cursos;
            paginamestrados.ItemsSource = cursos.ListaCursos; //adiciona os objetos à listview
        }
    }
}

