using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    class Aviso
    {
        public int id_aviso { get; set; }
        public string tipo { get; set; }
        public int dia { get; set; }
        public int hora { get; set; }
        public string local { get; set; }
        public string descricao { get; set; }
    }
}