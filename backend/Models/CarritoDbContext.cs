using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Models
{
    public class CarritoDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //indicamos que la entidad Pedido tiene un usuario como campo
            modelBuilder.Entity<Pedido>().HasRequired(x => x.Usuario);
            //indicamos que la entidad Pago tiene una Factura como campo
            modelBuilder.Entity<Pago>().HasRequired(x => x.Factura);
            //Indicamos que la entidad Factura tiene un Pedido como campo
            modelBuilder.Entity<Factura>().HasRequired(x => x.Pedido);
            base.OnModelCreating(modelBuilder);
        }


    }
}
