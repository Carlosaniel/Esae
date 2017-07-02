using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App1.Models
{
    class Horario
    {
        public int id_horario { get; set; }
        public string disciplina { get; set; }
        public int dia { get; set; }
        public string hora_inicio { get; set; }
        public string hora_fim { get; set; }
        public int sala { get; set; }
        public string tipo { get; set; }
    }
}
