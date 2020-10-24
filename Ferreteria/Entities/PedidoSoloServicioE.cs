using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoSoloServicioE : PedidoE
    {
        public string Observaciones { get; set; }

        public PedidoSoloServicioE() { }

        public PedidoSoloServicioE(int id, string cedulaCliente, LinkedList<LinkedList<object>> servicios,
            DateTime horaRecibidoBodega, DateTime horaSalidaBodega,
            DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte, string observaciones)
            : base(id, cedulaCliente, servicios, horaRecibidoBodega, horaSalidaBodega,
                  horaIniciaTransporte, horaFinalizaTransporte)
        {
            Id = id;
            CedulaCliente = cedulaCliente;
            Servicios = servicios;
            HoraRecibidoBodega = horaRecibidoBodega;
            HoraSalidaBodega = horaSalidaBodega;
            HoraIniciaTransporte = horaIniciaTransporte;
            HoraFinalizaTransporte = horaFinalizaTransporte;
            Observaciones = observaciones;
        }
    }
}
