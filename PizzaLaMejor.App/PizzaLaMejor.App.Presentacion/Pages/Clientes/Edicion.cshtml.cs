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
    public class EdicionModel : PageModel
    {
        private readonly IRepositorioClientes _repoCliente;
        [BindProperty]
        public Cliente cliente{get;set;}
        public EdicionModel(IRepositorioClientes repoCliente)
        {
            _repoCliente = repoCliente;
        }
        public void OnGet(int clienteId)
        {
            cliente= _repoCliente.ConsultarCliente(clienteId);
        }
        public async Task<IActionResult> OnPost()
        {
            cliente = _repoCliente.ActualizarCliente(cliente);
            if(cliente==null){
                return Page();
            }
            return RedirectToPage("/Clientes/Consulta");
        }
    }
}
 