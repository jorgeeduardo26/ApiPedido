using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoApp.Domain
{
    public class Pedido
    {
        public Pedido()
        {
            //instancia de pedido producto 
            PedidoProducto = new List<PedidoProducto>();
        }

        public int PedidoId { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public List<PedidoProducto> PedidoProducto { get; set; }

    }
}
