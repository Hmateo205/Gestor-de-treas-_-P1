namespace Gestor_de_treas___P1.Models
{
    public class Etiqueta
    {
        public int EtiquetaId { get; set; }
        public string NombreEtiqueta { get; set; }
        public ICollection<TareaEtiqueta> TareasEtiquetas { get; set; }
    }
}
