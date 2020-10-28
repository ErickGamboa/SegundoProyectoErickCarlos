using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class PedidoVentaE
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdVenta { get; set; }
        public double Cantidad { get; set; }
        public double PrecioTotal { get; set; }

        public PedidoVentaE() { }

        public PedidoVentaE(int id, int idPedido, int idVenta, double cantidad, double precioTotal)
        {
            Id = id;
            IdPedido = idPedido;
            IdVenta = idVenta;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
        }
    }
}
