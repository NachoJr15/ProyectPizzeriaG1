using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLaMejor.App.Persistencia;
using PizzaLaMejor.App.Dominio;

namespace PizzaLaMejor.App.Presentacion.Pages
{
    public class ConsultaModel : PageModel
    {
        private readonly IRepositorioClientes _repoCliente;
        [BindProperty]
        public IEnumerable<Cliente> ListaCliente{get;set;}
        public ConsultaModel(IRepositorioClientes repoCliente)
        {
            _repoCliente = repoCliente;
        }
        public void OnGet(int clienteId)
        {
            ListaCliente = new List<Cliente>(); 
            ListaCliente = _repoCliente.ConsultarCliente();
            _repoCliente.EliminarCliente(clienteId); 
        }
    }
}
