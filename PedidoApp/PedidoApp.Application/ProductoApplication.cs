using PedidoApp.Application.Interfaz;
using PedidoApp.Data;
using PedidoApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PedidoApp.Application
{
    public class ProductoApplication : IProducto
    {
        private readonly PedidoContext _pedidoContext;
        public ProductoApplication(PedidoContext pedidoContext)
        {
            _pedidoContext = pedidoContext;
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = null;
            try
            {
                productos = _pedidoContext.Producto.ToList();                
            }
            catch (Exception ex)
            {
                //log
                throw;
            }
            return productos;           
        }
    }
}
