using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FacturaE
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoCajero { get; set; }
        public string NombreCajero { get; set; }
        public string CodigoVendedor { get; set; }
        public LinkedList<LinkedList<object>> Productos { get; set; }
        public LinkedList<LinkedList<object>> Servicios { get; set; }
        public double SubTotal { get; set; }
        public double IVA { get; set; }
        public double Total { get; set; }

        public FacturaE() { }

        public FacturaE(int id, int idPedido, DateTime fecha, string codigoCajero, string nombreCajero,
            string codigoVendedor, LinkedList<LinkedList<object>> productos,
            LinkedList<LinkedList<object>> servicios, double subTotal, double iva, double total)
        {
            Id = id;
            IdPedido = idPedido;
            Fecha = fecha;
            CodigoCajero = codigoCajero;
            NombreCajero = nombreCajero;
            CodigoVendedor = codigoVendedor;
            Productos = productos;
            Servicios = servicios;
            SubTotal = subTotal;
            IVA = iva;
            Total = total;
        }
    }
}
