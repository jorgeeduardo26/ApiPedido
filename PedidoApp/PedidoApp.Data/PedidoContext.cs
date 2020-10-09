using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PedidoApp.Domain;

namespace PedidoApp.Data
{
    public class PedidoContext :  DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> options)
            : base (options) // se inyecta la cadena de conexion
        {
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<PedidoProducto> PedidoProducto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            //se indica llave compuesta
            modelBuilder.Entity<PedidoProducto>().HasKey(p => new { p.PedidoId, p.ProductoId });
        }
    }
}
