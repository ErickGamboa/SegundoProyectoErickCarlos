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

        public List<ServicioE> CargarServicio()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                List<ServicioE> lista = new List<ServicioE>();
                var lst = from servicio in db.servicio
                          select servicio;
                foreach (var i in lst)
                {
                    ServicioE servi = new ServicioE();
                    servi.Id = i.id;
                    servi.Nombre = i.nombre;
                    servi.Categoria = i.categoria;
                    servi.Descripcion = i.descripcion;
                    servi.Precio = Convert.ToDouble(i.precio);
                    lista.Add(servi);
                }
                return lista;
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
