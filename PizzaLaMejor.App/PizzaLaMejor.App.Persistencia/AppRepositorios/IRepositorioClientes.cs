using PizzaLaMejor.App.Dominio;
using System.Collections.Generic;

namespace PizzaLaMejor.App.Persistencia
{
    public interface IRepositorioClientes 
    {
        Cliente CrearCliente(Cliente cliente);
        Cliente ConsultarCliente(int id);
        IEnumerable<Cliente> ConsultarCliente();
        Cliente ActualizarCliente(Cliente cliente);
        void EliminarCliente(int id);





    }
}
