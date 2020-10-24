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
        protected DateTime HoraIniciaTransporte { get; set; }
        protected DateTime HoraFinalizaTransporte { get; set; }

        protected PedidoE() { }

        protected PedidoE(int id, string cedulaCliente, LinkedList<LinkedList<object>> servicios,
            DateTime horaRecibidoBodega, DateTime horaSalidaBodega,
            DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte)
        {
            Id = id;
            CedulaCliente = cedulaCliente;
            Servicios = servicios;
            HoraRecibidoBodega = horaRecibidoBodega;
            HoraSalidaBodega = horaSalidaBodega;
            HoraIniciaTransporte = horaIniciaTransporte;
            HoraFinalizaTransporte = horaFinalizaTransporte;
        }
    }
}
