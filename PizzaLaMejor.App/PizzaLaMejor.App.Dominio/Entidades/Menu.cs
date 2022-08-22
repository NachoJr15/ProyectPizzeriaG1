using System;

namespace PizzaLaMejor.App.Dominio
{
    public class Menu : Pedido
    {
        public int Id {get; set;}
        public string Categoria {get; set;}
        public float Precio {get; set;}
        public Ingredientes Ingredientes {get; set;}
        
    }
}
