using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvc.Models;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreMvc.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AnoFundacion = 2005;
            escuela.Nombre = "Platzi";
            escuela.EscuelaId = Guid.NewGuid().ToString();
            return View(escuela);
        }
    }
}
