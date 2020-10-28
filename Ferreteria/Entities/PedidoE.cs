using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class PedidoE
    {
        protected int Id { get; set; }
        protected string CedulaCliente { get; set; }
        protected LinkedList<LinkedList<object>> Servicios { get; set; }
        protected DateTime HoraRecibidoBodega { get; set; }
        protected DateTime HoraSalidaBodega { get; set; }
        protected string CodigoConductor { get; set; }
        protected DateTime HoraIniciaTransporte { get; set; }
        protected DateTime HoraFinalizaTransporte { get; set; }
        protected DateTime FechaFactura { get; set; }
        protected string CodigoCajero { get; set; }
        protected double SubTotal { get; set; }
        protected double IVA { get; set; }
        protected double Total { get; set; }

        protected PedidoE() { }

        protected PedidoE(int id, string cedulaCliente, LinkedList<LinkedList<object>> servicios,
            DateTime horaRecibidoBodega, DateTime horaSalidaBodega, string codigoConductor,
            DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte, DateTime fechaFactura,
            string codigoCajero, double subTotal, double iva, double total)
        {
            Id = id;
            CedulaCliente = cedulaCliente;
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
        }
    }
}
