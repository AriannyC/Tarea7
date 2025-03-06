﻿namespace Tarea7.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }



        //Navigation
        public Proveedor Proveedor { get; set; }
        public Categoria Categoria { get; set; }
    }
}
