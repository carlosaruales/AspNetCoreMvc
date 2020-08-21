using System;
using System.Collections.Generic;
using AspNetCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;


namespace AspNetCoreMvc.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            List<Alumno> listAlumno = new List<Alumno>() {
                new Alumno {
                    Nombre = "Pedro",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Carlos",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Pepe",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Andrés",
                    UniqueId = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Evanisto",
                    UniqueId = Guid.NewGuid().ToString()
                }
            };

            return View("MultiAlumno", listAlumno);
        }
    }
}
