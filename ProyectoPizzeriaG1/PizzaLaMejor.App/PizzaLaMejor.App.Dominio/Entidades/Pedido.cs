using System;

namespace PizzaLaMejor.App.Dominio
{
    public class Pedido : Cliente
    {
        
        public int IdPedido {get; set;}
        public DateTime FechaPedido {get; set;}
        public int IdMenu {get; set;}
        public float Precio {get; set;}

        public Producto Producto {get; set;} 



    }
}