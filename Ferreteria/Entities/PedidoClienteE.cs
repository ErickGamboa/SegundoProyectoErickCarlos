using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PedidoClienteE : PedidoE
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public LinkedList<LinkedList<object>> Productos { get; set; }
        public string Estado { get; set; }

        public PedidoClienteE() { }

        public PedidoClienteE(int id, string cedulaCliente, string nombre, DateTime fecha,
            LinkedList<LinkedList<object>> productos, LinkedList<LinkedList<object>> servicios,
            DateTime horaRecibidoBodega, DateTime horaSalidaBodega,
            DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte, string estado)
            : base(id, cedulaCliente, servicios, horaRecibidoBodega, horaSalidaBodega,
                  horaIniciaTransporte, horaFinalizaTransporte)
        {
            Id = id;
            CedulaCliente = cedulaCliente;
            Nombre = nombre;
            Fecha = fecha;
            Productos = productos;
            Servicios = servicios;
            HoraRecibidoBodega = horaRecibidoBodega;
            HoraSalidaBodega = horaSalidaBodega;
            HoraIniciaTransporte = horaIniciaTransporte;
            HoraFinalizaTransporte = horaFinalizaTransporte;
            Estado = estado;
        }
    }
}
