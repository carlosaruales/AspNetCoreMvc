using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvc.Models;
using System.Linq;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreMvc.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;

        public EscuelaController(EscuelaContext Escuela){
            _context = Escuela;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var escuela = _context.Escuelas.FirstOrDefault();
            //var escuela = new Escuela();
            //escuela.AñoDeCreación = 2005;
            //escuela.Nombre = "Platzi";
            //escuela.UniqueId = Guid.NewGuid().ToString();
            //ViewBag.otraPropiedad = "Soy una propiedad ViewBag :D";
            return View(escuela);
        }
    }
}
