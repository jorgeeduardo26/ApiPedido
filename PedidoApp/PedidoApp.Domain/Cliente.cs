using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoApp.Domain
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
    }
}
