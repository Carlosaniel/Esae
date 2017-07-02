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
    public class DisciplinaController
    {
        private WS servidor; //ligação ao servidor
        public List<Disciplina> ListaDisciplinas; //lista de objetos do model

        public DisciplinaController()
        {
            servidor = new WS();
            ListaDisciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(servidor.PedidoServidor("http://10.0.2.2/app_hibrida/public/api/disciplinas").ReadLine());
        }
    }
}
