using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Logic
{
    public class LProducto
    {
        public void RegistrarProducto (string nombre, string categoria, string descripcion, decimal precio, decimal cantidad)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                producto producto = new producto();
                producto.nombre = nombre;
                producto.categoria = categoria;
                producto.descripcion = descripcion;
                producto.precio = precio;
                producto.cantidad = cantidad;
                db.producto.Add(producto);
                db.SaveChanges();
            }

        }
        public List<ProductoE> CargarProducto() {
            using (FerreteriaEntities db = new FerreteriaEntities()) {
                List<ProductoE> lista = new List<ProductoE>();
                var lst = from producto in db.producto
                          select producto;
                foreach (var i in lst)
                {
                    ProductoE produ = new ProductoE();
                    produ.id = i.id;
                    produ.Nombre = i.nombre;
                    produ.Categoria = i.categoria;
                    produ.Descripcion = i.descripcion;
                    produ.Precio = Convert.ToDouble(i.precio);
                    produ.Cantidad = Convert.ToDouble(i.cantidad);
                    lista.Add (produ);
                }
                return lista;
            }

        }
        public void EditarProducto(string nombre, string categoria, string descripcion, decimal precio, decimal cantidad, int id) {
            
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                producto producto = null;

                producto = db.producto.Find(id);
                producto.nombre = nombre;
                producto.categoria = categoria;
                producto.descripcion = descripcion;
                producto.precio = precio;
                producto.cantidad = cantidad;
                db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }


            }
        public void EliminarProducto(int id) {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                producto producto;
                producto = db.producto.Find(id);
                db.producto.Remove(producto);
                db.SaveChanges();
            }

            }
    }
}
