using System.ComponentModel.DataAnnotations;

namespace Tarea7.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre ")]

        public string Nombre{ get; set; }

        //navigation Property
        public ICollection<Producto> ProductosNC { get; set; }
    }
}
