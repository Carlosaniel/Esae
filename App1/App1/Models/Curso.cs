using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App1.Models
{
    class Curso
    {
        public int id_curso { get; set; }
        public string curso { get; set; }
        public string coordenador { get; set; }
        public int ects_totais { get; set; }
        public string tipo { get; set; }
    }
}

