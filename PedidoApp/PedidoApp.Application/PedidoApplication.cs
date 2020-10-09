using Microsoft.EntityFrameworkCore;
using PedidoApp.Application.Interfaz;
using PedidoApp.Data;
using PedidoApp.Domain;
using System;
using System.Linq;

namespace PedidoApp.Application
{
    public class PedidoApplication : IPedido
    {
        private readonly PedidoContext _pedidoContext;
        public PedidoApplication(PedidoContext pedidoContext)
        {
            _pedidoContext = pedidoContext;
        }

        public bool Agregar(Pedido _pedido)
        {
            bool resultadoOperacion = false;
            try
            {
                _pedidoContext.Pedido.Add(_pedido);
                _pedidoContext.SaveChanges();
                resultadoOperacion = true;
            }
            catch (Exception ex)
            {
                //ToDo: log               
                throw;
            }
            return resultadoOperacion;


        }

        public Pedido Consultar(int idPedido)
        {
           var pedido = _pedidoContext.Pedido
                                    .Include(c => c.Cliente)
                                    .Include(p => p.PedidoProducto)
                                    .ThenInclude(p => p.Producto)
                                    .FirstOrDefault(c => c.PedidoId == idPedido);

            if (pedido == null)
            {
                throw new ArgumentException("Pedido inexistente");
            }

            return pedido;

        }

        public void Eliminar(int idPedido)
        {
            try
            {
                var pedido = _pedidoContext.Pedido.Find(idPedido);

                if (pedido == null)
                {                   
                    throw new ArgumentException("Pedido inexistente");
                }
                _pedidoContext.Pedido.Remove(pedido);
                _pedidoContext.SaveChanges();

            }
            catch (Exception ex)
            {
                //log
                throw;
            }
           
        }
    }
}
