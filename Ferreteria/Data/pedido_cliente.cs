//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedido_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedido_cliente()
        {
            this.pedido_cliente_producto = new HashSet<pedido_cliente_producto>();
            this.pedido_cliente_servicio = new HashSet<pedido_cliente_servicio>();
        }
    
        public int id { get; set; }
        public string cedula_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
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
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedido_cliente_producto> pedido_cliente_producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedido_cliente_servicio> pedido_cliente_servicio { get; set; }
    }
}
