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
        public string Login(string usuario, string contra) {
            try
            {
                var builder = new SqlConnectionStringBuilder();
                builder.DataSource = "DESKTOP-R9OGT38";
                builder.InitialCatalog = "Ferreteria";
                builder.IntegratedSecurity = true;
                var connectionString = builder.ToString();
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT cedula, contrasena, tipo FROM usuario Where cedula ='" + usuario + "' AND contrasena ='" + contra + "'", conexion))
                    {
                        SqlDataAdapter data = new SqlDataAdapter(cmd);
                        DataTable res = new DataTable();
                        data.Fill(res);
                        SqlDataReader dr = cmd.ExecuteReader();
                        
                        if (dr.Read())
                        {
                            string tipo = Convert.ToString(res.Rows[0]["tipo"]);
                            return tipo  ;
                        }
                        else
                        {
                            return "Credenciales no validos";
                        }
                    }

                }
            }
            catch (Exception ex) {

                return ex.ToString();
            }

        }
    }
}
