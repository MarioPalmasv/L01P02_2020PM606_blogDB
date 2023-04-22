using System.ComponentModel.DataAnnotations;

namespace L01P02_2020PM606.Models
{
    public class usuarios
    {

        [Key]
        [Display(Name = "id usuario")]
        public int usuarioId { get; set; }

        [Display(Name = "id rol")]
        public int rolId { get; set; }

        [Display(Name = "nombre Usuario")]
        public string? nombreUsuario { get; set; }

        [Display(Name = "clave")]
        public string? clave { get; set; }

        [Display(Name = "nombre")]
        public string? nombre { get; set; }

        [Display(Name = "apellido")]
        public string? apellido { get; set; }

    }
}
