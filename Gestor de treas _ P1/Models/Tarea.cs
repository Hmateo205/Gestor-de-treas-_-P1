namespace Gestor_de_treas___P1.Models
{
    public class Tarea
    {
        public int TareaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public Prioridad Prioridad { get; set; }
        public Estado Estado { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public List<Etiqueta> Etiquetas { get; set; }
        public List<Asignacion> Asignaciones { get; set; }
    }

}
