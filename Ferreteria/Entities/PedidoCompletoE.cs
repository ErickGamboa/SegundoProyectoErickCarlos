using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoCompletoE : PedidoE
    {
        public string CodigoVendedor { get; set; }
        public LinkedList<LinkedList<PedidoCompletoProductoE>> Productos { get; set; }
        public LinkedList<LinkedList<PedidoCompletoServicioE>> Servicios { get; set; }
        public DateTime HoraAtencion { get; set; }
        public DateTime HoraVenta { get; set; }

        public PedidoCompletoE() { }

        public PedidoCompletoE(int id, string codigoVendedor, string cedulaCliente,
            LinkedList<LinkedList<PedidoCompletoProductoE>> productos,
            LinkedList<LinkedList<PedidoCompletoServicioE>> servicios,
            DateTime horaAtencion, DateTime horaVenta, DateTime horaRecibidoBodega, DateTime horaSalidaBodega,
            string codigoConductor, DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte,
            DateTime fechaFactura, string codigoCajero, double subTotal, double iva, double total)
            : base(id, cedulaCliente, horaRecibidoBodega, horaSalidaBodega, codigoConductor,
                  horaIniciaTransporte, horaFinalizaTransporte, fechaFactura, codigoCajero, subTotal, iva, total)
        {
            Id = id;
            CodigoVendedor = codigoVendedor;
            CedulaCliente = cedulaCliente;
            Productos = productos;
            Servicios = servicios;
            HoraAtencion = horaAtencion;
            HoraVenta = horaVenta;
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
        }
    }
}
