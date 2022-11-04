using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Alcancia.Clases.Conexion
{
    class conexion
    {
        SqlConnection con = new SqlConnection("Server=TAVOET98\\SQLEXPRESS; Database=AHORRO; integrated security = true;");

        public SqlConnection ConDesBD(out string mensaje)
        {
            string msj_salida = "";
            try
            {
                if (con.State == ConnectionState.Closed)//VALIDAMOS SI LA CONEXION ES CERRADA
                {
                    con.Open();
                    msj_salida = "conexion abierta";
                }
                else if(con.State == ConnectionState.Open)//VALIDAMOS SI LA CONEXION ES ABIERTA
                {
                    con.Close();
                    msj_salida = "conexion cerrada";
                }
                mensaje = msj_salida;
                return con; 
            }
            catch (SqlException x)
            {
                mensaje = "no hay conexion con la base de datos. \n" + x.ToString();
                return null;
            }
        }
    }
}
