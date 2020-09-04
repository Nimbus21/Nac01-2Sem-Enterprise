using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAC01Enterprise.Models
{
    public class Turma
    {
        /*
        Referência de relacionamentos 
        Boletim 1 : 1 Aluno N : 1 Turma
        */

        [HiddenInput]
        public int Codigo { get; set; }

        public int AnoLetivo { get; set; }

        //O ID da turma deve ser uma letra
        public char IdTurma { get; set; }

        public Ensino Ensino { get; set; }

        public Turno turno { get; set; }
    }
}
