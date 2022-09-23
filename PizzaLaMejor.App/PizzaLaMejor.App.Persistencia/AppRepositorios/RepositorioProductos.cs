using PizzaLaMejor.App.Dominio;
using System.Collections.Generic;
using System.Linq;



namespace PizzaLaMejor.App.Persistencia
{
    public class RepositorioProductos : IRepositorioProductos

    {
        private readonly AppContext _appContext = new AppContext();
        
        public Producto CrearProducto(Producto producto)
        {
            var productoA = _appContext.Productos.Add(producto);
            _appContext.SaveChanges();
            return productoA.Entity;  
        }   
        public Producto ConsultarProducto(int idproducto)
        {
            return _appContext.Productos.FirstOrDefault(p=>p.Id==idproducto);
        }
        public IEnumerable<Producto> ConsultarProducto()
        {
            return _appContext.Productos;
        }
        public  Producto ActualizarProducto(Producto producto)
        {
            var resultado = _appContext.Productos.FirstOrDefault(p=>p.Id==producto.Id);
            if (resultado!=null){
                resultado.Categoria=producto.Categoria;
                resultado.Precio=producto.Precio;
                resultado.Ingredientes=producto.Ingredientes;

                _appContext.SaveChanges();
            }
            return resultado;
        }
        public void EliminarProducto(int Id)
        {
            var productoE = _appContext.Productos.FirstOrDefault(p=>p.Id==Id);
            if(productoE!=null)
            {
                _appContext.Productos.Remove(productoE);
                _appContext.SaveChanges();
            }
        }
    }
}
