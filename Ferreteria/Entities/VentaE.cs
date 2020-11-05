using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class VentaE
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        private double precio;

        public VentaE() { }

        public VentaE(int id, string nombre, string categoria, string descripcion, double precio)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
            Precio = precio;
        }

        public double Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio no puede ser menor a 0 (cero)");
                }
                else
                {
                    precio = value;
                }
            }
        }
    }
}
