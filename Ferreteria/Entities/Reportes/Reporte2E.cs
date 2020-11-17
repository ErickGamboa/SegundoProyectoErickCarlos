using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reporte2E
    {
        public decimal? Cantidad { get; set; }
        public string Categoria { get; set; }

        public Reporte2E() { }

        public Reporte2E(decimal? cantidad, string categoria)
        {
            Cantidad = cantidad;
            Categoria = categoria;
        }
    }
}
