using PizzaLaMejor.App.Dominio;
using System.Collections.Generic;
using System.Linq;



namespace PizzaLaMejor.App.Persistencia
{
    public class RepositorioPedidos : IRepositorioPedidos
    {
        private readonly AppContext _appContext = new AppContext();
        
        public Pedido CrearPedido(Pedido pedido)
        {
            var pedidoA = _appContext.Pedidos.Add(pedido);
            _appContext.SaveChanges();
            return pedidoA.Entity;  
        }   
        public Pedido ConsultarPedido(int idpedido)
        {
            return _appContext.Pedidos.FirstOrDefault(p=>p.Id==idpedido);
        }
        public IEnumerable<Pedido> ConsultarPedido()
        {
            return _appContext.Pedidos;
        }
        public  Pedido ActualizarPedido(Pedido pedido)
        {
            var resultado = _appContext.Pedidos.FirstOrDefault(p=>p.Id==pedido.Id);
            if (resultado!=null){
                resultado.FechaPedido=pedido.FechaPedido;
                resultado.Total=pedido.Total;
                
                _appContext.SaveChanges();
            }
            return resultado;
        }
        public void EliminarPedido(int Id)
        {
            var pedidoE = _appContext.Pedidos.FirstOrDefault(p=>p.Id==Id);
            if(pedidoE!=null)
            {
                _appContext.Pedidos.Remove(pedidoE);
                _appContext.SaveChanges();
            }
        }
    }
    
}
