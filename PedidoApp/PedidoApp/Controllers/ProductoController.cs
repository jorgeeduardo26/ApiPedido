using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedidoApp.Application.Interfaz;
using PedidoApp.Domain;

namespace PedidoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProducto _producto;      

        public ProductoController(IProducto producto)
        {
            _producto = producto;
        }

        [HttpGet()]
        public IActionResult GetProducto()
        {
            List<Producto> productos = null;          
          
            try
            {
                productos = _producto.ObtenerProductos();
            }
            catch (Exception ex)
            {

            }

            return Ok(productos);
        }
    }
}
