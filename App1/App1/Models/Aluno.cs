﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    class Aluno
    {
        public int id_aluno { get; set; }
        public string nome { get; set; }
        public string data_nascimento { get; set; }
        public int cartao_cidadao { get; set; }
        // public List<Aluno> alunos { get; set; }
    }
}