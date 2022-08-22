using System;

namespace PizzaLaMejor.App.Dominio
{
    public class Clientes : Pedido
    {
        public int Id {get; set;}
        public string Cedula {get; set;}
        public string Nombres {get; set;}
        public string Apellidos {get; set;}
        public string CorreoElectronico {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string Telefono {get; set;}
        public string Direccion {get; set;}
        public string Contraseña {get; set;} 
        
    }
}