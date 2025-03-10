﻿using System.ComponentModel.DataAnnotations;

namespace Tarea7.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre ")]

        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe colocar el contacto ")]

        public string Contacto { get; set; }
        //navigation
        public ICollection<Producto> ProductosN { get; set; }
    }
}
