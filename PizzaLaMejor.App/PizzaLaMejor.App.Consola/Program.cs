using System.Net.Http;
using System;
using PizzaLaMejor.App.Dominio;
using PizzaLaMejor.App.Persistencia;
using System.Collections.Generic; 

namespace PizzaLaMejor.App.Consola
{
    class Program
    {
        private static IRepositorioClientes _repoCliente = new RepositorioClientes(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CrearCliente();
        }
        private void CrearCliente(){
            var cliente = new Cliente
            {
                Cedula = "12345",
                Nombres = "Marcela Maria",
                Apellidos = "Agudelo Giraldo",
                CorreoElectronico = "julmar1326@gmail.com",
                Telefono = "2111111",
                Direccion = "Av 9 Cll 170",
                Contraseña = "0000",
                FechaNacimiento = new DateTime (2000,08,29) 
            };
            _repoCliente.CrearCliente(cliente);
        }
    }
}
