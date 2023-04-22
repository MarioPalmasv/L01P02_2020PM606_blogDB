using System.ComponentModel.DataAnnotations;
    
namespace L01P02_2020PM606.Models
{
    public class calificaciones
    {
        [Key]

        [Display (Name = "id calificacion")]
        public int calificacionId { get; set; }

        [Display(Name = "id publicacion")]
        public int publicacionId { get; set; }

        [Display(Name = "id usuario")]
        public int usuarioId { get; set; }

        [Display(Name = "calificacion")]
        public int calificacion { get; set; }

    }
}
