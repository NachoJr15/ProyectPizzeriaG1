using System.Net.Http;
using System;
using PizzaLaMejor.App.Dominio;
using PizzaLaMejor.App.Persistencia;
using System.Collections.Generic; 

namespace PizzaLaMejor.App.Consola
{
    class Program
    {
        //private static IRepositorioClientes _repoCliente = new RepositorioClientes(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CrearCliente();
            ///EliminarCliente(); ///Para eliminar se quita comentarios y se ponen en la linea anterior CrearCliente(), para que se pueda eliminar los datos señalados en la BD
        }

        /*private static void EliminarCliente()
        {
            _repoCliente.EliminarCliente(1); ///el numero es la posicion de los datos registrados en la BD
        }
        private static void CrearCliente(){
            var cliente = new Cliente
            {
                Cedula = "67890",
                Nombres = "Mark",
                Apellidos = "Antony",
                CorreoElectronico = "mark1326@gmail.com",
                Telefono = "4111111",
                Direccion = "Av 170 Cll 9",
                Contraseña = "1002",
                FechaNacimiento = new DateTime (2001,09,29) 
            };
            _repoCliente.CrearCliente(cliente);
        }
        */
    }
}
