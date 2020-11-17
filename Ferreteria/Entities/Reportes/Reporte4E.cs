using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Reportes
{
    public class Reporte4E
    {
        public int Cantiddad { get; set; }
        public string CodigoVendedor { get; set; }

        public Reporte4E() { }

        public Reporte4E(int cantiddad, string codigoVendedor)
        {
            Cantiddad = cantiddad;
            CodigoVendedor = codigoVendedor;
        }
    }
}
