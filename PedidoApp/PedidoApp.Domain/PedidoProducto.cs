using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoApp.Domain
{
    public class PedidoProducto
    {
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public Pedido Pedido { get; set; }
        public Producto Producto { get; set; }
    }
}
