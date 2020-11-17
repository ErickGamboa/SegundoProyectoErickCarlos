using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Logic
{
    public class LServicio
    {

        /*
         This method receives all the information of a Service in the parameters. This information is saved on an object of type
         servicio. After that the object is saved in the data base
             */

        public void RegistrarServicio(string nombre, string categoria, string descripcion, decimal precio)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                servicio servicio = new servicio();
                servicio.nombre = nombre;
                servicio.categoria = categoria;
                servicio.descripcion = descripcion;
                servicio.precio = precio;
                servicio.activo = true;
                db.servicio.Add(servicio);
                db.SaveChanges();
            }

        }

        /*
         This method receives name and a category of a service in the parameters. With these parameters is consulted the services 
         in the data bases. When there is a service with this information, it is saved in a list.
         The method returns the list with objects. 
             */

        public List<ServicioE> CargarServicio(string nombre, string categoria)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                List<ServicioE> lista = new List<ServicioE>();
                var lst = from servicio in db.servicio
                          where servicio.nombre.Contains(nombre) && servicio.categoria.Contains(categoria)
                          select servicio;
                foreach (var i in lst)
                {
                    ServicioE servi = new ServicioE();
                    servi.Id = i.id;
                    servi.Nombre = i.nombre;
                    servi.Categoria = i.categoria;
                    servi.Descripcion = i.descripcion;
                    servi.Precio = Convert.ToDecimal(i.precio);
                    servi.Activo = i.activo;
                    lista.Add(servi);
                }
                return lista;
            }

        }

        public List<string> CargarCategoriaServicio()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<string>("SELECT * FROM v_categoria_servicio").ToList();
            }
        }

        /*
         This method receives all the information of a Service in the parameters. Data base find this service with the id and 
         edit the necessary information
             */

        public void EditarServicio(string nombre, string categoria, string descripcion, decimal precio, bool activo, int id)
        {

            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                servicio servi = null;

                servi = db.servicio.Find(id);
                servi.nombre = nombre;
                servi.categoria = categoria;
                servi.descripcion = descripcion;
                servi.precio = precio;
                servi.activo = activo;
                db.Entry(servi).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }


        }

        /*
         This method receives the id of a Service in the parameters. Data base find this service with the id and 
         delete the register
             */

        public void EliminarServicio(int id)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                servicio servi;
                servi = db.servicio.Find(id);
                servi.activo = false;
                db.Entry(servi).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }


    }
}
