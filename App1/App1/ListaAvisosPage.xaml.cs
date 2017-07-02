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
    public partial class ListaAvisosPage : ContentPage
    {
        AvisoController avisos;
        private string teste;

        public ListaAvisosPage(AvisoController _avisos)
        {
            InitializeComponent();

            avisos = _avisos;
            paginavisos.ItemsSource = avisos.ListaAvisos; //adiciona os objetos à listview
        }
    }
}

