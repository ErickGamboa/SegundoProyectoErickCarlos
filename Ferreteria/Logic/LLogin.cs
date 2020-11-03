using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entities;
using System.Data.SqlClient;
using System.Configuration;

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
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            
                            return "entrooo";
                        }
                        else {
                            return "NOOO";
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
