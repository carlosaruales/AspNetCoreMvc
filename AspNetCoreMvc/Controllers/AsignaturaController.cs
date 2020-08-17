using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreMvc.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            Asignatura asignatura = new Asignatura
            {
                Nombre = "Inglés",
                UniqueId = Guid.NewGuid().ToString()
            };

            return View(asignatura);
        }
    }
}
