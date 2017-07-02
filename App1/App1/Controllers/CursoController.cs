using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using App1.API;
using App1.Models;

namespace App1.Controllers
{
    public class CursoController
    {
        private WS servidor; //ligação ao servidor
        public List<Curso> ListaCursos; //lista de objetos do model

        public CursoController()
        {
            servidor = new WS();
            ListaCursos = JsonConvert.DeserializeObject<List<Curso>>(servidor.PedidoServidor("http://10.0.2.2/app_hibrida/public/api/cursos").ReadLine());
        }
    }
}
