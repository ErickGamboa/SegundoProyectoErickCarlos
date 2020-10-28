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
        public LinkedList<LinkedList<object>> Productos { get; set; }
        public string Estado { get; set; }

        public PedidoClienteE() { }

        public PedidoClienteE(int id, string cedulaCliente, string nombreCliente, DateTime fecha,
            LinkedList<LinkedList<object>> productos, LinkedList<LinkedList<object>> servicios,
            DateTime horaRecibidoBodega, DateTime horaSalidaBodega, string codigoConductor,
            DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte, DateTime fechaFactura,
            string codigoCajero, double subTotal, double iva, double total, string estado)
            : base(id, cedulaCliente, servicios, horaRecibidoBodega, horaSalidaBodega, codigoConductor,
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
