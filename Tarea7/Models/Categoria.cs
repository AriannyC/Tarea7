﻿namespace Tarea7.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        //navigation
        public List<Producto> Productos { get; set; }
    }
}
