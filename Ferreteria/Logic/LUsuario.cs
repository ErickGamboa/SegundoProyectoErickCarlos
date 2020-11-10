using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;

namespace Logic
{
    public class LUsuario
    {
        public List<UsuarioE> CargarUsuario()
        {
            using (FerreteriaEntities db = new FerreteriaEntities())
            {
                List<UsuarioE> lista = new List<UsuarioE>();
                var lst = from usuario in db.usuario
                          select usuario;
                foreach (var i in lst)
                {
                    UsuarioE usu = new UsuarioE();
                    usu.Id = i.id;
                    usu.Codigo = i.codigo;
                    usu.Nombre = i.nombre;
                    usu.Contrasena = i.contrasena;
                    usu.Cedula = i.cedula;
                    usu.Tipo = i.tipo;
                    lista.Add(usu);
                }
                return lista;
            }

        }

        public void registrarUsuarios(string codigo, string nombre, string contra, string cedula, string tipo) {
            using (FerreteriaEntities db = new FerreteriaEntities()) {
                usuario usuario = new usuario();
                usuario.codigo = codigo;
                usuario.nombre = nombre;
                usuario.contrasena = contra;
                usuario.cedula = cedula;
                usuario.tipo = tipo;
                db.usuario.Add(usuario);
                db.SaveChanges();
            }

        }

    }


    
}
