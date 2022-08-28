using System;

namespace PizzaLaMejor.App.Dominio
{
    public class Carrito
    {
        public int Id {get; set;}
        public string EstadoPedido {get; set;}
        public Pedido Pedido {get; set;}
        public Producto Producto {get; set;}
               
    }
}