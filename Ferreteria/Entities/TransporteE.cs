using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TransporteE
    {
        public int Id { get; set; }
        private string numeroVehiculo;
        public string CodigoConductor { get; set; }
        public bool Disponible { get; set; }
        public bool Activo { get; set; }

        public TransporteE() { }

        public TransporteE(int id, string numeroVehiculo, string codigoConductor, bool disponible, bool activo)
        {
            Id = id;
            NumeroVehiculo = numeroVehiculo;
            CodigoConductor = codigoConductor;
            Disponible = disponible;
            Activo = activo;
        }

        public string NumeroVehiculo
        {
            get { return numeroVehiculo; }
            set
            {
                if (value.Length != 6)
                {
                    throw new ArgumentException("El número del vehículo debe tener 6 dígitos");
                }
                else
                {
                    numeroVehiculo = value;
                }
            }
        }
    }
}
