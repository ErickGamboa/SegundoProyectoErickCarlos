using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoCompletoServicioE : PedidoVentaE
    {
        public PedidoCompletoServicioE() { }

        public PedidoCompletoServicioE(int id, int idPedidoCompleto, int idServicio,
            decimal cantidad, decimal precioTotal)
            : base(id, idPedidoCompleto, idServicio, cantidad, precioTotal)
        {
            Id = id;
            IdPedido = idPedidoCompleto;
            IdVenta = idServicio;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
        }
    }
}
