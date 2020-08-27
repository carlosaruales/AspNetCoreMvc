using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvc.Models
{
    public class EscuelaContext: DbContext
    {
        public EscuelaContext(DbContextOptions<EscuelaContext> options): base(options)
        {

        }

        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var Escuela = new Escuela();
            Escuela.AñoDeCreación = 2020;
            Escuela.Id = Guid.NewGuid().ToString();
            Escuela.Nombre = "Platzi School";
            Escuela.Ciudad = "Bogotá";
            Escuela.Pais = "Colombia";
            Escuela.Dirección = "Avd Siempre Viva";
            Escuela.TipoEscuela = TiposEscuela.Secundaria;

            modelBuilder.Entity<Escuela>().HasData(Escuela);
            modelBuilder.Entity<Asignatura>().HasData(new List<Asignatura>() {
                new Asignatura {
                    Nombre = "Inglés",
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura {
                    Nombre = "Español",
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura {
                    Nombre = "Francés",
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura {
                    Nombre = "Portugues",
                    Id = Guid.NewGuid().ToString()
                },
                new Asignatura {
                    Nombre = "Latin",
                    Id = Guid.NewGuid().ToString()
                }
            }.ToArray());

            //modelBuilder.Entity<Alumno>().HasData(new List<Alumno>() {
            //    new Alumno {
            //        Nombre = "Pedro",
            //        Id = Guid.NewGuid().ToString()
            //    },
            //    new Alumno {
            //        Nombre = "Carlos",
            //        Id = Guid.NewGuid().ToString()
            //    },
            //    new Alumno {
            //        Nombre = "Pepe",
            //        Id = Guid.NewGuid().ToString()
            //    },
            //    new Alumno {
            //        Nombre = "Andrés",
            //        Id = Guid.NewGuid().ToString()
            //    },
            //    new Alumno {
            //        Nombre = "Evanisto",
            //        Id = Guid.NewGuid().ToString()
            //    }
            //});
        }
    }
}
