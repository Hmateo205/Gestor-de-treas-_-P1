namespace Gestor_de_treas___P1.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Tarea> Tareas { get; set; }
    }
}
