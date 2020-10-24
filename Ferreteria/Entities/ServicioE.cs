using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ServicioE : VentaE
    {
        public ServicioE() { }

        public ServicioE(int id, string nombre, string categoria, string descripcion, double precio)
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
