using System.Security.Cryptography.Xml;

namespace ModeladoDatosLuisZamora.Models
{
    public class Calificaciones
    {
        public int Id { get; set; }
        public string Observacion { get; set; } = null!;
        public DateTime FechaCalificacion { get; set; }
        public float Nota { get; set; }

        public Estudiantes Estudiante { get; set; } = null!;
        public Asignaturas Asignatura { get; set; } = null!;

    }
}
