using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Logic
{
    public class LProducto
    {
        /*
         This method receives all the information of a Product in the parameters. This information is saved on an object of type
         producto. After that the object is saved in the data base
             */

        public void RegistrarProducto(string nombre, string categoria, string descripcion, decimal precio, decimal cantidad)
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

        /*
         This method receives name and a category of a product in the parameters. With these parameters is consulted the products 
         in the data bases. When there is a product with this information, it is saved in a list.
         The method returns the list with objects. 
             */

        public List<ProductoE> CargarProducto(string nombre, string categoria)
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                List<ProductoE> lista = new List<ProductoE>();
                var lst = from producto in db.producto
                          where producto.nombre.Contains(nombre) && producto.categoria.Contains(categoria)
                          select producto;
                foreach (var i in lst)
                {
                    ProductoE produ = new ProductoE();
                    produ.Id = i.id;
                    produ.Nombre = i.nombre;
                    produ.Categoria = i.categoria;
                    produ.Descripcion = i.descripcion;
                    produ.Precio = Convert.ToDecimal(i.precio);
                    produ.Cantidad = Convert.ToDecimal(i.cantidad);
                    lista.Add(produ);
                }
                return lista;
            }

        }

        public List<string> CargarCategoriaProducto()
        {
            using (var i = new FerreteriaEntities())
            {
                return i.Database.SqlQuery<string>("SELECT * FROM v_categoria_producto").ToList();
            }
        }

        /*
         This method receives all the information of a Product in the parameters. Data base find this product with the id and 
         edit the necessary information
             */

        public void EditarProducto(string nombre, string categoria, string descripcion, decimal precio, decimal cantidad, int id)
        {

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

        /*
         This method receives the id of a Product in the parameters. Data base find this product with the id and 
         delete the register
             */

        public void EliminarProducto(int id)
        {
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
