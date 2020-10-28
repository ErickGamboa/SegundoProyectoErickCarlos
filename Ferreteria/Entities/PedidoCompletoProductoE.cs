using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoCompletoProductoE : PedidoVentaE
    {
        public PedidoCompletoProductoE() { }

        public PedidoCompletoProductoE(int id, int idPedidoCompleto, int idProducto,
            double cantidad, double precioTotal)
            : base(id, idPedidoCompleto, idProducto, cantidad, precioTotal)
        {
            Id = id;
            IdPedido = idPedidoCompleto;
            IdVenta = idProducto;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
        }
    }
}
