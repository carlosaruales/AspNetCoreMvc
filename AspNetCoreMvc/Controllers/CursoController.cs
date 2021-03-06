﻿using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvc.Controllers
{
    public class CursoController : Controller
    {
        private EscuelaContext _context;

        public CursoController(EscuelaContext Escuela)
        {
            _context = Escuela;
        }

        public IActionResult Index(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                var cursos = from curso in _context.Curso
                                 where curso.Id == id
                                 select curso;
                return View(cursos.SingleOrDefaultAsync());
            } else
            {
                return View("MultiAsignatura", _context.Curso);
            }
        }


        public IActionResult MultiCurso()
        {
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiCurso", _context.Curso);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            if(ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();
                curso.Escuela.Id = escuela.Id;
                _context.Curso.Add(curso);
                _context.SaveChanges();
                return View("Index",curso);
            }
            else
            {
                return View(curso);
            }
            

            
        }



    }
}
