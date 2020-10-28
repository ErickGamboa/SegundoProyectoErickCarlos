using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoSoloServicioServicioE : PedidoVentaE
    {
        public PedidoSoloServicioServicioE() { }

        public PedidoSoloServicioServicioE(int id, int idPedidoSoloServicio, int idServicio,
            double cantidad, double precioTotal)
            : base(id, idPedidoSoloServicio, idServicio, cantidad, precioTotal)
        {
            Id = id;
            IdPedido = idPedidoSoloServicio;
            IdVenta = idServicio;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
        }
    }
}
