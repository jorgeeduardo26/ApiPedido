using PedidoApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoApp.Application.Interfaz
{
    public interface IProducto
    {
        public List<Producto> ObtenerProductos();
    }
}
