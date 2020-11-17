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
        private decimal precio;
        public bool Activo { get; set; }

        public VentaE() { }

        public VentaE(int id, string nombre, string categoria, string descripcion, decimal precio, bool activo)
        {
            Id = id;
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
            Precio = precio;
            Activo = activo;
        }

        public decimal Precio
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
