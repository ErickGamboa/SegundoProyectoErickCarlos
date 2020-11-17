using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Logic
{
    public class LLogin
    {

        /*
         This method receive two string in the parameters. The first string is the user and the second string is the password.
         With a query the method search the parameters in the database. If the ExecuteReader could read the method return an 
         object. Else the method throw an exception
             */

        public UsuarioE Login(string usuario, string contra) {
            UsuarioE u = new UsuarioE();
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "ASUS-X412FA-CAR";
            builder.InitialCatalog = "Ferreteria";
            builder.IntegratedSecurity = true;
            var connectionString = builder.ToString();
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM usuario WHERE cedula ='" + usuario + "' AND contrasena ='" + contra + "'", conexion))
                {
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable res = new DataTable();
                    data.Fill(res);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        u.Id = Convert.ToInt32(res.Rows[0]["id"]);
                        u.Codigo = Convert.ToString(res.Rows[0]["codigo"]);
                        u.Nombre = Convert.ToString(res.Rows[0]["nombre"]);
                        u.Contrasena = Convert.ToString(res.Rows[0]["contrasena"]);
                        u.Cedula = Convert.ToString(res.Rows[0]["cedula"]);
                        u.Tipo = Convert.ToString(res.Rows[0]["tipo"]);
                        dr.Close();
                        return u;
                    }
                    else
                    {
                        throw new Exception("Credenciales no válidos");
                    }
                }

            }
        }
    }
}
