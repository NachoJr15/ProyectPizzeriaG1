
using System;
using PizzaLaMejor.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace PizzaLaMejor.App.Persistencia
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly AppContext _appContext = new AppContext();

        
        public Cliente CrearCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity; 
        }

        public Cliente ConsultarCliente(int Id)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(p=> p.Id == Id);
            return clienteEncontrado;
        }

        public Cliente ConsultarClientePorCorreo(string CorreoElectronico)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(p=> p.CorreoElectronico == CorreoElectronico);
            return clienteEncontrado;
        }
        public IEnumerable<Cliente> ConsultarCliente()
        {
            return _appContext.Clientes;  
        }
        
        public Cliente ActualizarCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(p => p.Id== cliente.Id);
            if(clienteEncontrado!=null){
                clienteEncontrado.Cedula = cliente.Cedula;
                clienteEncontrado.Nombres = cliente.Nombres;
                clienteEncontrado.Apellidos = cliente.Apellidos;
                clienteEncontrado.CorreoElectronico = cliente.CorreoElectronico;
                clienteEncontrado.FechaNacimiento = cliente.FechaNacimiento;
                clienteEncontrado.Telefono = cliente.Telefono;
                clienteEncontrado.Direccion = cliente.Direccion;
                clienteEncontrado.Contraseña = cliente.Contraseña;
                clienteEncontrado.Pedido = cliente.Pedido;
                clienteEncontrado.Producto = cliente.Producto;
                
                _appContext.SaveChanges();
            } 
            return clienteEncontrado;
        }
        
        public void EliminarCliente(int clienteId)
        {
            var cliente=_appContext.Clientes.FirstOrDefault(c=> c.Id==clienteId);
            if (cliente !=null){
                _appContext.Clientes.Remove(cliente);
                _appContext.SaveChanges();
            }
        }

        
        
    } 
}

