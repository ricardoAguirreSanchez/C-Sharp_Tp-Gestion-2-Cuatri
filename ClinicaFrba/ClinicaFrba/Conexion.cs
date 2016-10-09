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

        //trae todos los roles de un usuario especifico
        public DataTable roles(String usuario)
        {

            da = new SqlDataAdapter("Execute SOLARIS.buscarRoles '" + usuario + "'", cn);

            

            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        //verifica la existencia de algun rol
        public Boolean verificarRoles()
        {

            Boolean result = false;
            
            cm = new SqlCommand("Execute SOLARIS.buscarRolesTotal ", cn);
            dr = cm.ExecuteReader();
            //se lee, si no hay nada, no entra en el while, si hay algo, entra
            while (dr.Read())
            {
                result = true;
            }
            dr.Close();
            return result;


        }

        public DataTable rolesTotal()
        {
            
            da = new SqlDataAdapter("Execute SOLARIS.buscarRolesTotal ", cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        //verifica la existencia de un rol espeficifo
        public Boolean buscarRolesPorNombre(String id)
        {

            Boolean result = false;

            cm = new SqlCommand("Execute SOLARIS.buscarRolesPorNombre '" + id + "'", cn);
            dr = cm.ExecuteReader();
            //se lee, si no hay nada, no entra en el while, si hay algo, entra
            while (dr.Read())
            {
                result = true;
            }
            dr.Close();
            return result;


        }
        //total de funcionalidades
        public DataTable funcionalidadesTotales()
        {

            da = new SqlDataAdapter("Execute SOLARIS.funcionalidadesTotal ", cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


        public void agregaRol(String nombreRol)
        {
            cm = new SqlCommand("Execute SOLARIS.insertaRol " + nombreRol, cn);
            cm.ExecuteNonQuery();

        }
        public void agregaFuncionalidadARol(String nombreRol, String nombreFuncionalidad)
        {
            cm = new SqlCommand("Execute SOLARIS.insertaFuncionalidadARol " + nombreRol +",'"+ nombreFuncionalidad+"'", cn);
            cm.ExecuteNonQuery();

        }
    }
}
