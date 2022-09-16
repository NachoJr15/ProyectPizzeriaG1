using System;

namespace PizzaLaMejor.App.Dominio
{
    public class Producto
    {
        public int Id {get; set;}
        public Categoria Categoria {get; set;}
        public float Precio {get; set;}
        public string Ingredientes {get; set;}
        
    }
}
