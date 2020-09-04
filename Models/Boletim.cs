using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NAC01Enterprise.Models
{
    public class Boletim
    {
        [HiddenInput]
        public int Codigo { get; set; }

        public float NotaPortugues { get; set; }

        public float NotaMatematica { get; set; }

        public float NotaIngles { get; set; }

    }
}
