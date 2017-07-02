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
    public class HorarioController
    {
        private WS servidor; //ligação ao servidor
        public List<Horario> ListaHorarios; //lista de objetos do model

        public HorarioController()
        {
            servidor = new WS();
            ListaHorarios = JsonConvert.DeserializeObject<List<Horario>>(servidor.PedidoServidor("http://10.0.2.2/app_hibrida/public/api/horarios").ReadLine());
        }
    }
}
