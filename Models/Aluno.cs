using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NAC01Enterprise.Models
{
    public class Aluno
    {
        [HiddenInput]
        public int Codigo { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        // public Turno turno { get; set; }
    }
}
