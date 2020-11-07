using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Logic
{
    public class LTransporte
    {
        public void RegistrarTransporte(string numeroVehiculo, string idConductor, Boolean estado)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                transporte transporte = new transporte();
                transporte.numero_vehiculo = numeroVehiculo;
                transporte.codigo_conductor = idConductor;
                transporte.disponible = estado;
                db.transporte.Add(transporte);
                db.SaveChanges();
            }

        }
        public List<TransporteE> CargarTransportes()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                List<TransporteE> lista = new List<TransporteE>();
                var lst = from transporte in db.transporte
                          select transporte;
                foreach (var i in lst)
                {
                    TransporteE trans = new TransporteE();
                    trans.Id = i.id;
                    trans.numeroVehiculo = i.numero_vehiculo;
                    trans.CodigoConductor = i.codigo_conductor;
                    trans.Disponible = i.disponible;
                    lista.Add(trans);
                }
                return lista;
            }

        }
    }
}
