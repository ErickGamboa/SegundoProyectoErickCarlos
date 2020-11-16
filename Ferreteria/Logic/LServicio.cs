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
                db.servicio.Add(servicio);
                db.SaveChanges();
            }

        }

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

        public void EditarServicio(string nombre, string categoria, string descripcion, decimal precio, int id)
        {

            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                servicio servi = null;

                servi = db.servicio.Find(id);
                servi.nombre = nombre;
                servi.categoria = categoria;
                servi.descripcion = descripcion;
                servi.precio = precio;
                db.Entry(servi).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }


        }

        public void EliminarServicio(int id)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                servicio servi;
                servi = db.servicio.Find(id);
                db.servicio.Remove(servi);
                db.SaveChanges();
            }

        }


    }
}
