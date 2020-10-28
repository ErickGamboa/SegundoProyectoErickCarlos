using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoSoloServicioE : PedidoE
    {
        public string CodigoConstructor { get; set; }
        public string Observaciones { get; set; }

        public PedidoSoloServicioE() { }

        public PedidoSoloServicioE(int id, string cedulaCliente, LinkedList<LinkedList<object>> servicios,
            string codigoConstructor, string observaciones, DateTime horaRecibidoBodega, DateTime horaSalidaBodega,
            string codigoConductor, DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte,
            DateTime fechaFactura, string codigoCajero, double subTotal, double iva, double total)
            : base(id, cedulaCliente, servicios, horaRecibidoBodega, horaSalidaBodega, codigoConductor,
                  horaIniciaTransporte, horaFinalizaTransporte, fechaFactura, codigoCajero, subTotal, iva, total)
        {
            Id = id;
            CedulaCliente = cedulaCliente;
            Servicios = servicios;
            CodigoConstructor = codigoConstructor;
            Observaciones = observaciones;
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
