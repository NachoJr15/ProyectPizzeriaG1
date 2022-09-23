using Microsoft.EntityFrameworkCore;
using PizzaLaMejor.App.Dominio;

namespace PizzaLaMejor.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Carrito> Carritos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=SQL5063.site4now.net;Initial Catalog=db_a8d220_pizzalamejor;User Id=db_a8d220_pizzalamejor_admin;Password=20Septiembre2022");
            }
        }
    }   
}



