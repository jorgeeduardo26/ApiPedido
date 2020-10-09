using PedidoApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoApp.Application.Interfaz
{
    public interface IPedido
    {
        bool Agregar(Pedido pedido);
        Pedido Consultar(int idPedido);
        void Eliminar(int idPedido);
    }
}
