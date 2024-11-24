namespace ModeladoDatosLuisZamora.Models
{
    public class Asignaturas
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Creditos { get; set; }
        public Boolean Estado { get; set; }

        public List<Calificaciones> Calificacion { get; set; } = new List<Calificaciones>();
    }
}
