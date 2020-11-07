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
        public double Cantidad { get; set; }
        

        public ProductoE() {

        }

        public ProductoE(int id, string nombre, string categoria, string descripcion,
            double precio, double cantidad) : base(id, nombre, categoria, descripcion, precio)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }


    }
}
