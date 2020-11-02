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
