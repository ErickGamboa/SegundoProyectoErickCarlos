using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductoE : VentaE
    {
        private double cantidad;

        public ProductoE() { }

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

        public double Cantidad
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
