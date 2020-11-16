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

        /*
         This method consults the transports in the data bases. These transports are saved in a list.
         The method returns the list with objects. 
             */

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

        /*
         This method receives all the information of a Transport in the parameters. Data base find this transport with the id and 
         edit the necessary information
             */

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

        /*
         This method receives the id of a Transport in the parameters. Data base find this transport with the id and 
         delete the register
             */

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
