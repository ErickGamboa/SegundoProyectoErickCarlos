using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoSoloServicioE : PedidoE
    {
        public string CodigoUsuario { get; set; }
        public string Observaciones { get; set; }

        public PedidoSoloServicioE() { }

        public PedidoSoloServicioE(int id, string cedulaCliente, string codigoUsuario,
            string observaciones, DateTime? horaRecibidoBodega, DateTime? horaSalidaBodega,
            string codigoConductor, DateTime? horaIniciaTransporte, DateTime? horaFinalizaTransporte,
            DateTime? fechaFactura, string codigoCajero, decimal? subTotal, decimal? iva, decimal? total)
            : base(id, cedulaCliente, horaRecibidoBodega, horaSalidaBodega, codigoConductor,
                  horaIniciaTransporte, horaFinalizaTransporte, fechaFactura, codigoCajero, subTotal, iva, total)
        {
            Id = id;
            CedulaCliente = cedulaCliente;
            CodigoUsuario = codigoUsuario;
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
