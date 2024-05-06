namespace Gestor_de_treas___P1.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contraseña { get; set; }
        public List<Tarea> TareasAsignadas { get; set; }
    }

}
