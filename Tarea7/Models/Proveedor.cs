﻿namespace Tarea7.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        //navigation
        public ICollection<Producto> ProductosN { get; set; }
    }
}
