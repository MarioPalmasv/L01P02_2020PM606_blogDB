using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2020PM606.Models
{
    public class comentarios
    {
        
        [Key]
        [Display(Name = "id comentatio")]
        public int comentarioId { get; set; }

        [Display(Name = "id publicacion")]
        public int publicacionId { get; set;}

        [Display(Name = "comentario")]
        public string? comentario { get; set;}

        [Display(Name = "id usuario")]
        public int usuarioId { get; set;}
    }
}
