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
        public string NombreVendedor { get; set; }
        public LinkedList<LinkedList<object>> Productos { get; set; }
        public DateTime HoraAtencion { get; set; }
        public DateTime HoraVenta { get; set; }

        public PedidoCompletoE() { }

        public PedidoCompletoE(int id, string codigoVendedor, string nombreVendedor, string cedulaCliente,
            LinkedList<LinkedList<object>> productos, LinkedList<LinkedList<object>> servicios,
            DateTime horaAtencion, DateTime horaVenta, DateTime horaRecibidoBodega, DateTime horaSalidaBodega,
            DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte)
            : base(id, cedulaCliente, servicios, horaRecibidoBodega, horaSalidaBodega,
                  horaIniciaTransporte, horaFinalizaTransporte)
        {
            Id = id;
            CodigoVendedor = codigoVendedor;
            NombreVendedor = nombreVendedor;
            CedulaCliente = cedulaCliente;
            Productos = productos;
            Servicios = servicios;
            HoraAtencion = horaAtencion;
            HoraVenta = horaVenta;
            HoraRecibidoBodega = horaRecibidoBodega;
            HoraSalidaBodega = horaSalidaBodega;
            HoraIniciaTransporte = horaIniciaTransporte;
            HoraFinalizaTransporte = horaFinalizaTransporte;
        }
            
    }
}
