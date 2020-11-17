using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Reportes
{
    public class Reporte9E
    {
        public string CodigoUsuario { get; set; }
        public int RealizoVentas { get; set; }

        public Reporte9E() { }

        public Reporte9E(string codigoUsuario, int realizoVentas)
        {
            CodigoUsuario = codigoUsuario;
            RealizoVentas = realizoVentas;
        }
    }
}
