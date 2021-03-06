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

        public IActionResult Index(int? id)
        {
            var lista = _alunos.Where(aluno => (aluno.Codigo == id || id == null)).OrderBy(i => i.Nome).ToList();

            var qtd = _alunos.Count();

            ViewBag.total = qtd;

            return View(lista);
        }

        public IActionResult Remover(int id)
        {
            _alunos.RemoveAt(_alunos.FindIndex(a => a.Codigo == id) );
            TempData["msg"] = "Aluno removido"; // Pode tirar depois
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            aluno.Codigo = _alunos.Count + 1;
            _alunos.Add(aluno);

            if (_alunos.Count > 0) 
            {
                TempData["msg"] = "Aluno cadastrado";
            }            

             // Pode tirar depois de testar
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Editar(Aluno aluno) 
        {
            _alunos[_alunos.FindIndex(a => a.Codigo == aluno.Codigo)] = aluno;
            TempData["msg"] = "Aluno atualizado";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id) 
        {
            var aluno = _alunos.Find(a => a.Codigo == id);
            return View(aluno);
        }

        /*
        [HttpGet]
        public IActionResult Pesquisar(int? id) 
        {
            var lista = _alunos.Where(aluno => aluno.Codigo == id || id == null).OrderBy(i => i.Nome).ToList();

            return View("Index", lista);
        
        }*/


    }
}
