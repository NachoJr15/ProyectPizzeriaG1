using PizzaLaMejor.App.Dominio;
using System.Collections.Generic;

namespace PizzaLaMejor.App.Persistencia
{
    public interface IRepositorioProductos 
    {
        Producto CrearProducto(Producto producto);
        Producto ConsultarProducto(int id);
        IEnumerable<Producto> ConsultarProducto();
        Producto ActualizarProducto(Producto producto);
        void EliminarProducto(int ProductoId);


    }
}