using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoClienteE : PedidoE
    {
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public LinkedList<LinkedList<PedidoClienteProductoE>> Productos { get; set; }
        public LinkedList<LinkedList<PedidoClienteServicioE>> Servicios { get; set; }
        public string Estado { get; set; }

        public PedidoClienteE() { }

        public PedidoClienteE(int id, string cedulaCliente, string nombreCliente, DateTime fecha,
            LinkedList<LinkedList<PedidoClienteProductoE>> productos,
            LinkedList<LinkedList<PedidoClienteServicioE>> servicios,
            DateTime horaRecibidoBodega, DateTime horaSalidaBodega, string codigoConductor,
            DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte, DateTime fechaFactura,
            string codigoCajero, decimal subTotal, decimal iva, decimal total, string estado)
            : base(id, cedulaCliente, horaRecibidoBodega, horaSalidaBodega, codigoConductor,
                  horaIniciaTransporte, horaFinalizaTransporte, fechaFactura, codigoCajero, subTotal, iva, total)
        {
            Id = id;
            CedulaCliente = cedulaCliente;
            NombreCliente = nombreCliente;
            Fecha = fecha;
            Productos = productos;
            Servicios = servicios;
            HoraRecibidoBodega = horaRecibidoBodega;
            HoraSalidaBodega = horaSalidaBodega;
            CodigoConductor = codigoConductor;
            HoraIniciaTransporte = horaIniciaTransporte;
            HoraFinalizaTransporte = horaFinalizaTransporte;
            FechaFactura = fechaFactura;
            CodigoCajero = codigoCajero;
            SubTotal = subTotal;
            IVA = iva;
            Total = total;
            Estado = estado;
        }
    }
}
