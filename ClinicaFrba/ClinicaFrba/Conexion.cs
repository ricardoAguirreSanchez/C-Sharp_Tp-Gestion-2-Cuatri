using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ClinicaFrba
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;

        /*para dgv = da + dt
          para solo leer filas = cm +  dr*/
        public void conectar()
        {
            try
            {
                cn = new SqlConnection("Data Source=RICARDO-PC\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016");
                cn.Open();
                
            }
            catch (Exception error)
            {
                MessageBox.Show("no se pudo conectar por:" + error.ToString());
              
            }


        }
        public Boolean verificarLogeo(String id, String clave)
        {
            
            Boolean result = false;
            //ejecuta el comando select para buscar si existe 
            cm = new SqlCommand("Execute SOLARIS.buscarUsuario '" + clave + "'", cn);
            dr = cm.ExecuteReader();
            //se lee, si no hay nada, no entra en el while, si hay algo, entra
            while (dr.Read())
            {
                result = true;
            }
            dr.Close();
            return result;
            

        }

        public DataTable roles(String id)
        {
            //ejecuta el comando select para buscar si existe 
            da = new SqlDataAdapter("Execute SOLARIS.buscarRoles '" + id + "'", cn);

            

            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}
