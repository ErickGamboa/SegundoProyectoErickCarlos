//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class v_spedido_completo
    {
        public int id { get; set; }
        public string codigo_vendedor { get; set; }
        public string cedula_cliente { get; set; }
        public Nullable<System.DateTime> hora_atencion { get; set; }
        public Nullable<System.DateTime> hora_venta { get; set; }
        public Nullable<System.DateTime> hora_recibido_bodega { get; set; }
        public Nullable<System.DateTime> hora_salida_bodega { get; set; }
        public string codigo_conductor { get; set; }
        public Nullable<System.DateTime> hora_inicia_transporte { get; set; }
        public Nullable<System.DateTime> hora_finaliza_transporte { get; set; }
        public Nullable<System.DateTime> fecha_factura { get; set; }
        public string codigo_cajero { get; set; }
        public Nullable<decimal> subtotal { get; set; }
        public Nullable<decimal> iva { get; set; }
        public Nullable<decimal> total { get; set; }
        public Nullable<bool> paga_solo_producto { get; set; }
    }
}
