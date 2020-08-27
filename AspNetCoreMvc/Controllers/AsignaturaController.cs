using System;
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
            var asignaturas = _context.Asignaturas.ToList();
            return View("MultiAsignatura", asignaturas);
        }
    }
}
