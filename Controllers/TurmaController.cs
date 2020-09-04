using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NAC01Enterprise.Models;

namespace NAC01Enterprise.Controllers
{
    public class TurmaController : Controller
    {

        //Banco simulado
        private static List<Turma> _banco = new List<Turma>();

        public IActionResult Index()
        {
            return View(_banco);
        }

        [HttpPost]
        public IActionResult Cadastrar(Turma turma)
        {
            turma.Codigo = _banco.Count + 1; //sequence simulado
            _banco.Add(turma);
            TempData["msg"] = "Turma cadastrada!";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
