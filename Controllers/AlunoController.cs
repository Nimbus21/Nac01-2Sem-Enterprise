﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NAC01Enterprise.Models;

namespace NAC01Enterprise.Controllers
{
    public class AlunoController : Controller
    {
        private static List<Aluno> _alunos = new List<Aluno>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Remover(int codigo)
        {
            _alunos.RemoveAt(_alunos.FindIndex(a => a.Codigo == codigo));
            TempData["msg"] = "Aluno removido"; // Pode tirar depois
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            aluno.Codigo = _alunos.Count + 1;
            _alunos.Add(aluno);
            TempData["msg"] = "Aluno cadastrado"; // Pode tirar depois de testar
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
