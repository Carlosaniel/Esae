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
    public class AvisoController
    {
        private WS servidor; //ligação ao servidor
        public List<Aviso> ListaAvisos; //lista de objetos do model

        public AvisoController()
        {
            servidor = new WS();
            ListaAvisos = JsonConvert.DeserializeObject<List<Aviso>>(servidor.PedidoServidor("http://10.0.2.2/app_hibrida/public/api/avisos").ReadLine());
        }
    }
}
