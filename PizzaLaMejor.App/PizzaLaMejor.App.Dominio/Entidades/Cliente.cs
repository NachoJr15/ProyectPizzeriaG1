using System;
using System.ComponentModel.DataAnnotations; 

namespace PizzaLaMejor.App.Dominio
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Cedula {get; set;}
        [Required]
        public string Nombres {get; set;}
        [Required]
        public string Apellidos {get; set;}
        public string CorreoElectronico {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public string Telefono {get; set;}
        public string Direccion {get; set;}
        public String Contraseña {get; set;}
        public Pedido Pedido {get; set;}
        public Producto Producto {get; set;}

    }
}