﻿using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvc.Controllers
{
    public class AlumnoController : Controller
    {
        private EscuelaContext _context;

        public AlumnoController(EscuelaContext Escuela)
        {
            _context = Escuela;
        }

        public IActionResult Index(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                var alumno = from asig in _context.Alumnos
                                 where asig.Id == id
                             select asig;
                return View(alumno.SingleOrDefaultAsync());
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
        }

        public IActionResult MultiAsignatura()
        {
            ViewBag.CosaDinamica = "La Monja";
            ViewBag.Fecha = DateTime.Now;
            return View("MultiAlumno", _context.Alumnos);
        }

    }
}
