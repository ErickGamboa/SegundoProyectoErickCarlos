﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class PedidoE
    {
        public int Id { get; set; }
        public string CedulaCliente { get; set; }
        public DateTime HoraRecibidoBodega { get; set; }
        public DateTime HoraSalidaBodega { get; set; }
        public string CodigoConductor { get; set; }
        public DateTime HoraIniciaTransporte { get; set; }
        public DateTime HoraFinalizaTransporte { get; set; }
        public DateTime FechaFactura { get; set; }
        public string CodigoCajero { get; set; }
        public decimal SubTotal { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }

        public PedidoE() { }

        public PedidoE(int id, string cedulaCliente, DateTime horaRecibidoBodega, DateTime horaSalidaBodega,
            string codigoConductor, DateTime horaIniciaTransporte, DateTime horaFinalizaTransporte,
            DateTime fechaFactura, string codigoCajero, decimal subTotal, decimal iva, decimal total)
        {
            Id = id;
            CedulaCliente = cedulaCliente;
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
