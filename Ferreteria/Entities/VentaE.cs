using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class VentaE
    {
        protected int Id { get; set; }
        protected string Nombre { get; set; }
        protected string Categoria { get; set; }
        protected string Descripcion { get; set; }
        private double precio;

        protected VentaE() { }

        protected VentaE(int id, string nombre, string categoria, string descripcion, double precio)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
            Precio = precio;
        }

        protected double Precio
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
