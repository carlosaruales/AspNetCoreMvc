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
                    Id = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Carlos",
                    Id = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Pepe",
                    Id = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Andrés",
                    Id = Guid.NewGuid().ToString()
                },
                new Alumno {
                    Nombre = "Evanisto",
                    Id = Guid.NewGuid().ToString()
                }
            };

            return View("MultiAlumno", listAlumno);
        }
    }
}
