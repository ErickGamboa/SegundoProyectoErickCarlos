using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoClienteProductoE : PedidoVentaE
    {
        public PedidoClienteProductoE() { }

        public PedidoClienteProductoE(int id, int idPedidoCliente, int idProducto,
            decimal cantidad, decimal precioTotal)
            : base(id, idPedidoCliente, idProducto, cantidad, precioTotal)
        {
            Id = id;
            IdPedido = idPedidoCliente;
            IdVenta = idProducto;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
        }
    }
}
