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
        public decimal cantidad;
        public decimal PrecioTotal { get; set; }

        public PedidoVentaE() { }

        public PedidoVentaE(int id, int idPedido, int idVenta, decimal cantidad, decimal precioTotal)
        {
            Id = id;
            IdPedido = idPedido;
            IdVenta = idVenta;
            Cantidad = cantidad;
            PrecioTotal = precioTotal;
        }

        public decimal Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La cantidad no puede ser menor a 0 (cero)");
                }
                else
                {
                    cantidad = value;
                }
            }
        }
    }
}
