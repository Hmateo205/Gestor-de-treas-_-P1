namespace Gestor_de_treas___P1.Models
{
    public class Asignacion
    {
        public int AsignacionId { get; set; }
        public int TareaId { get; set; }
        public int UsuarioId { get; set; }
        public Tarea Tarea { get; set; }
        public Usuario Usuario { get; set; }
    }

}
