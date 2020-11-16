using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ReporteE
    {
        public int Cantidad { get; set; }
        public string Categoria { get; set; }

        public ReporteE() { }

        public ReporteE(int cantidad, string categoria)
        {
            Cantidad = cantidad;
            Categoria = categoria;
        }
    }
}
