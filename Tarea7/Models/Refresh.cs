using System.ComponentModel.DataAnnotations;

namespace Tarea7.Models
{
    public class Refresh
    {
        [Required]
        public string refreshtoken { get; set; }
        public DateTime Expires { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
    }
}
