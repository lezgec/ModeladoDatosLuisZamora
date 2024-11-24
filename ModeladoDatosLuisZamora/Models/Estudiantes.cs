namespace ModeladoDatosLuisZamora.Models
{
    public class Estudiantes
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Correo { get; set; }
        public string Telefono { get; set; } = null!;
        public DateOnly FechaNacimiento { get; set; }
        public Boolean  Activo { get; set; }

        public List<Calificaciones> Calificacion { get; set; } = new List<Calificaciones>();

    }
}
