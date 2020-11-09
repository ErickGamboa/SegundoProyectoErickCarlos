using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductoE : VentaE
    {
        //public int id { get; set; }
        //public string Nombre { get; set; }
        //public string Categoria { get; set; }
        //public string Descripcion { get; set; }
        //public double Precio { get; set; }
        public decimal cantidad;
        
        public ProductoE() { }

        public ProductoE(int id, string nombre, string categoria, string descripcion,
            decimal precio, decimal cantidad) : base(id, nombre, categoria, descripcion, precio)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }

        public decimal Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La cantidad no puede ser menor a 0 (cero)");
                }
                else
                {
                    cantidad = value;
                }
            }
        }
    }
}
