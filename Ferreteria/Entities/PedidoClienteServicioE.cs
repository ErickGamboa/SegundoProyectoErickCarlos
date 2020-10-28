using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoClienteServicioE : PedidoVentaE
    {
        public PedidoClienteServicioE() { }

        public PedidoClienteServicioE(int id, int idPedidoCliente, int idServicio,
            double cantidad, double precioTotal)
            : base(id, idPedidoCliente, idServicio, cantidad, precioTotal)
        {
            Id = id;
            IdPedido = idPedidoCliente;
            IdVenta = idServicio;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
        }
    }
}
