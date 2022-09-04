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
    public class RegistroModel : PageModel
    {   
        private readonly IRepositorioClientes _repoCliente;

        public RegistroModel (IRepositorioClientes repoCliente)
        {
            _repoCliente = repoCliente;
        }

        [BindProperty]
        public Cliente cliente {get; set;}
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid){
                return Page();
            }
            _repoCliente.CrearCliente(cliente);
            return RedirectToPage("/Index");
        }
    }
}
