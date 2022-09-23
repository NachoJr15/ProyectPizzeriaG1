using PizzaLaMejor.App.Dominio;
using System.Collections.Generic;

namespace PizzaLaMejor.App.Persistencia
{
    public interface IRepositorioPedidos 
    {
        Pedido CrearPedido(Pedido pedido);
        Pedido ConsultarPedido(int id);
        IEnumerable<Pedido> ConsultarPedido();
        Pedido ActualizarPedido(Pedido pedido);
        void EliminarPedido(int PedidoId);


    }
}