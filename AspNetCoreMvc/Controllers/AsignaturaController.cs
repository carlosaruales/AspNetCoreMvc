﻿using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreMvc.Controllers
{
    public class AsignaturaController : Controller
    {
        private EscuelaContext _context;

        public AsignaturaController(EscuelaContext Escuela)
        {
            _context = Escuela;
        }
        public IActionResult Index()
        {
            return View(_context.Asignaturas.FirstOrDefault());
        }


        public IActionResult MultiAsignatura()
        {
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAsignatura", _context.Asignaturas);
        }
    }
}
