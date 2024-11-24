using Microsoft.EntityFrameworkCore;

namespace ModeladoDatosLuisZamora.Models
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Estudiantes> Estudiante { get; set; }

        public DbSet<Asignaturas> Asignatura { get; set; }
        public DbSet<Calificaciones> Calificacion { get; set; }
    }
}
