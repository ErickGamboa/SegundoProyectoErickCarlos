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

        /*
         This method receives all the information of a Transport in the parameters. This information is saved on an object of type
         transporte. After that the object is saved in the data base
             */

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

        public void EditarTransporte(string numeroVehiculo, string idConductor, Boolean estado, int id)
        {

            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                transporte trans = null;

                trans = db.transporte.Find(id);
                trans.numero_vehiculo = numeroVehiculo;
                trans.codigo_conductor = idConductor;
                trans.disponible = estado;
                db.Entry(trans).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }


        }

        public void EliminarTransporte(int id)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                transporte trans;
                trans = db.transporte.Find(id);
                db.transporte.Remove(trans);
                db.SaveChanges();
            }

        }
    }
}
