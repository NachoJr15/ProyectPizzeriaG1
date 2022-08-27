using System;

namespace PizzaLaMejor.App.Dominio
{
    public class Pedido : Producto
    {
        public int IdPedido {get; set;}
        public DateTime FechaPedido {get; set;}
        public float Total {get; set;} 
            
    }
}