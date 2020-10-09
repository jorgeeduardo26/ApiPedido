using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PedidoApp.Domain
{
    public class Producto
    {
        public Producto()
        {
            //instancia 
            PedidoProducto = new List<PedidoProducto>();
        }

        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public decimal  Precio { get; set; }

        public int Existencia { get; set; }
        
        public List<PedidoProducto> PedidoProducto { get; set; }
    }
}
