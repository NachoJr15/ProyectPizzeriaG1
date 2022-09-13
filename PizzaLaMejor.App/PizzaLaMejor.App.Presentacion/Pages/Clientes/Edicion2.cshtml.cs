using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaLaMejor.App.Dominio;
using PizzaLaMejor.App.Persistencia;


namespace PizzaLaMejor.App.Presentacion.Pages
{
    public class Edicion2Model : PageModel
    {
        
        private readonly IRepositorioClientes _repoCliente;
        [BindProperty]
        public Cliente cliente{get;set;}  
        public Edicion2Model(IRepositorioClientes repoCliente)
        {
            _repoCliente = repoCliente;
        }
        public void OnGet()
        {
            cliente = new Cliente();
        }

        public async Task<IActionResult> OnPost()
        {
            cliente = _repoCliente.ConsultarClientePorCorreo(cliente.CorreoElectronico);
            if(cliente==null)
            {
                return RedirectToPage("/Error");
            } 
            else
            {
                return Page();
            }
            
        }
        public async Task<ActionResult> OnPostEdit()
        {
            cliente = _repoCliente.ActualizarCliente(cliente);
            if(cliente!=null)
            {
                return RedirectToPage("/Clientes/Consulta");
            }
            return RedirectToPage("/Error");
        }
    }
}
