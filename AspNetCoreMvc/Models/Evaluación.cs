using System;

namespace AspNetCoreMvc.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; }

        public Alumno AlumnoId { get; set; }
        public Asignatura Asignatura  { get; set; }

        public string AsignaturaId{ get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}