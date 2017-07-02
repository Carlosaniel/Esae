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
    public class AlunoController
    {
        private WS servidor; //ligação ao servidor
        public List<Aluno> ListaAlunos; //lista de objetos do model

        public AlunoController()
        {
            servidor = new WS();
            ListaAlunos = JsonConvert.DeserializeObject<List<Aluno>>(servidor.PedidoServidor("http://10.0.2.2/app_hibrida/public/api/alunos").ReadLine());
        }
    }
}
