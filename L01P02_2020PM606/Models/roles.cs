using System.ComponentModel.DataAnnotations;

namespace L01P02_2020PM606.Models
{
    public class roles
    {

        [Key]
        [Display(Name = "id rol")]
        public int rolId { get; set; }

        [Display(Name = "rol")]
        public string? rol { get; set; }

    }
}
