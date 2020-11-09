using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ServicioE : VentaE
    {
        //public int id { get; set; }
        //public string nombre { get; set; }
        //public string categoria { get; set; }
        //public string descripcion { get; set; }
        //public double precio { get; set; }

        public ServicioE() { }

        public ServicioE(int id, string nombre, string categoria, string descripcion, decimal precio)
            : base(id, nombre, categoria, descripcion, precio)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}

