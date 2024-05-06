namespace Gestor_de_treas___P1.Models
{
    public class TareaEtiqueta
    {
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }
        public int EtiquetaId { get; set; }
        public Etiqueta Etiqueta { get; set; }
    }
}
