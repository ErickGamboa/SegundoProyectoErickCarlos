using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Reportes
{
    public class Reporte7E
    {
        public decimal? Total { get; set; }
        public decimal? IVA { get; set; }

        public Reporte7E() { }

        public Reporte7E(decimal? total, decimal? iva)
        {
            Total = total;
            IVA = iva;
        }
    }
}
