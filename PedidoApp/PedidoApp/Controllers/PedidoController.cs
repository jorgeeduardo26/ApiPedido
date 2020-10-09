using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidoApp.Application.Interfaz;
using PedidoApp.Domain;

namespace PedidoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedido _pedido;

        public PedidoController(IPedido pedido)
        {
            _pedido = pedido;
        }

        [HttpPost]
        public ActionResult PostPedido(Pedido pedido)
        {
            try
            {
                _pedido.Agregar(pedido);
                return CreatedAtAction("GetPedido", new { id = pedido.PedidoId }, pedido);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        [HttpGet("{id}")]
        public IActionResult GetPedido(int id)
        {
            //consultar el pedido 
            Pedido pedido = null;
            try
            {
                pedido = _pedido.Consultar(id);
            }
            catch (Exception ex)
            {                
            }
            
            return Ok(pedido);
        }

        [HttpDelete("{id}")]
        public ActionResult<Pedido> DeletePedido(int id)
        {
            try
            {
                _pedido.Eliminar(id);
            }
            catch (Exception ex)
            {
                return null;
               
            }         

            return Ok();
        }

    }
}
