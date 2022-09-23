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
    public class RegistrarProductoModel : PageModel
    {
        private readonly IRepositorioProductos _repoProducto;
        [BindProperty]
        public Producto producto{get; set;}   
        public RegistrarProductoModel(IRepositorioProductos repoProducto)
        {
            _repoProducto = repoProducto;
        }
        public void OnGet()
        {
            producto = new Producto();
        }
         public async Task<IActionResult> OnPost()
        {
            producto = _repoProducto.CrearProducto(producto);
            if(producto!=null)
            {
                return RedirectToPage("/Index");    
            }
            return RedirectToPage("/Error");
        }
    }
}
