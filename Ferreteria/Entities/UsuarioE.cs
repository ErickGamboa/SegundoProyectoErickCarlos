﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UsuarioE
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }

        public UsuarioE() { }

        public UsuarioE(int id, string codigo, string nombre, string contrasena)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Contrasena = contrasena;
        }
    }
}
