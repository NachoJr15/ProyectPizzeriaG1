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
    public class RegistrarPedidoModel : PageModel
    {
        private readonly IRepositorioPedidos _repoPedido;
        [BindProperty]
        public Pedido pedido{get; set;}   
        public RegistrarPedidoModel(IRepositorioPedidos repoPedido)
        {
            _repoPedido = repoPedido;
        }
        public void OnGet()
        {
            pedido = new Pedido();
        }
         public async Task<IActionResult> OnPost()
        {
            /*pedido = _repoPedido.CrearPedido(pedido);
            if(pedido!=null)
            {
                return RedirectToPage("/Index");    
            }
            return RedirectToPage("/Error"); */

            if(!ModelState.IsValid){
                return Page();
            }
            _repoPedido.CrearPedido(pedido);
            return RedirectToPage("/Index");
        }
    }
}
