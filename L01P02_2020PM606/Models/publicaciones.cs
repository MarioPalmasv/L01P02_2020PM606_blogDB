using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace L01P02_2020PM606.Models
{
    public class publicaciones
    {

        [Key]
        [Display(Name = "id publicacion")]
        public int publicacionId { get; set; }

        [Display(Name = "titulo")]
        public string? titulo { get; set; }

        [Display(Name = "descripcion")]
        public string? descripcion { get; set; }

        [Display(Name = "id usuario")]
        public int usuarioId { get; set; }
    }
}
