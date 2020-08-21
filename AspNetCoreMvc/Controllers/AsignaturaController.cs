using System;
using System.Collections.Generic;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreMvc.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            List<Asignatura> listAsignaturas = new List<Asignatura>() {
                new Asignatura {
                    Nombre = "Inglés",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Asignatura {
                    Nombre = "Español",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Asignatura {
                    Nombre = "Francés",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Asignatura {
                    Nombre = "Portugues",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Asignatura {
                    Nombre = "Latin",
                    UniqueId = Guid.NewGuid().ToString()
                }
            };

            return View("MultiAsignatura",listAsignaturas);
        }
    }
}
