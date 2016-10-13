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
        public Boolean buscarRolesPorNombreHabilitado(String id)
        {

            Boolean result = false;

            cm = new SqlCommand("Execute SOLARIS.buscarRolesPorNombreHabilitado " + id, cn);
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

            da = new SqlDataAdapter("Execute SOLARIS.funcionalidadesTotales ", cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        
        
        
        
        //funcionalidades restantes
        public DataTable funcionalidadesRestantes(int codigoRol)
        {

            da = new SqlDataAdapter("Execute SOLARIS.funcionalidadesRestantes " + codigoRol, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        //total de funcionalidades por rol
         public DataTable funcionalidadesTotalesPorRol(String nombreRol)
        {

            da = new SqlDataAdapter("Execute SOLARIS.funcionalidadesTotalesPorRol " + nombreRol, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        //Traigo Pacientes por ID
        public Array buscarPacientePorID(string ID)
        {

            //Defino el Store Procedure
            SqlCommand command = new SqlCommand("SOLARIS.buscarPacientePorID", cn);
            command.CommandType = CommandType.StoredProcedure;

            //Defino los parametros que deseo traer
            SqlParameter Nombre = new SqlParameter("Nombre", SqlDbType.VarChar,255);
            Nombre.Direction = ParameterDirection.Output;
            command.Parameters.Add(Nombre);

            SqlParameter Apellido = new SqlParameter("Apellido", SqlDbType.VarChar,255);
            Apellido.Direction = ParameterDirection.Output;
            command.Parameters.Add(Apellido);

            SqlParameter DNI = new SqlParameter("DNI", SqlDbType.VarChar, 255);
            DNI.Direction = ParameterDirection.Output;
            command.Parameters.Add(DNI);

            //SqlParameter Fecha_Nacimiento = new SqlParameter("Fecha_Nacimiento", SqlDbType.Text);
            //Fecha_Nacimiento.Direction = ParameterDirection.Output;
            //command.Parameters.Add(Fecha_Nacimiento);

            SqlParameter Direccion = new SqlParameter("Direccion", SqlDbType.VarChar, 255);
            Direccion.Direction = ParameterDirection.Output;
            command.Parameters.Add(Direccion);

            SqlParameter Telefono = new SqlParameter("Telefono", SqlDbType.VarChar, 255);
            Telefono.Direction = ParameterDirection.Output;
            command.Parameters.Add(Telefono);

            SqlParameter Email = new SqlParameter("Email", SqlDbType.VarChar, 255);
            Email.Direction = ParameterDirection.Output;
            command.Parameters.Add(Email);

            //SqlParameter Sexo = new SqlParameter("Sexo", SqlDbType.Text);
            //Sexo.Direction = ParameterDirection.Output;
            //command.Parameters.Add(Sexo);

            //SqlParameter Plan = new SqlParameter("Plan", SqlDbType.Text);
            //Plan.Direction = ParameterDirection.Output;
            //command.Parameters.Add(Plan);

            SqlParameter DNI_Principal = new SqlParameter("DNI_Principal", SqlDbType.VarChar, 255);
            DNI_Principal.Direction = ParameterDirection.Output;
            command.Parameters.Add(DNI_Principal);

            //Defino los parametros con los que voy a buscar en la base de datos
            command.Parameters.AddWithValue("ID_Paciente", ID);

            command.ExecuteScalar();
            
            string[] resultado = new string[9];

            resultado.SetValue(command.Parameters["Nombre"].Value.ToString(), 0);
            resultado.SetValue(command.Parameters["Apellido"].Value.ToString(), 1);
            resultado.SetValue(command.Parameters["DNI"].Value, 2);
            resultado.SetValue(command.Parameters["Direccion"].Value, 3);
            resultado.SetValue(command.Parameters["Telefono"].Value, 4);
            resultado.SetValue(command.Parameters["Email"].Value, 5);
            resultado.SetValue(command.Parameters["DNI_Principal"].Value, 6);

            //resultado.SetValue(command.Parameters["Fecha_Nacimiento"].Value, 3);
            //resultado.SetValue(command.Parameters["Sexo"].Value, 7);
            //resultado.SetValue(command.Parameters["Plan"].Value, 8);
            
            return resultado;

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

        public void borrarRol(String nombreRol)
        {
            cm = new SqlCommand("Execute SOLARIS.borrarRol " + nombreRol, cn);
            cm.ExecuteNonQuery();

        }

        public void modificarNombreEstado(int codigoRol,String nombreROL, String estado)
        {
            int estadoFinal = 0;
            if (estado == "SI")
            {
                estadoFinal = 1;
            }
            else
            {
                estadoFinal = 0;
            }
           
            cm = new SqlCommand("Execute SOLARIS.modificarNombreEstado " + codigoRol + " ," + nombreROL + " ," + estadoFinal, cn);
            cm.ExecuteNonQuery();

        }

        public void modificarFuncionalidadActual(int codigoRol, String nombreFuncionalidad)
        {
            cm = new SqlCommand("Execute SOLARIS.modificarFuncionalidadActual " + codigoRol + " , '" + nombreFuncionalidad + "'", cn);
            cm.ExecuteNonQuery();

        }


        public void agregoFuncionalidadActual(int codigoRol, String nombreFuncionalidad)
        {
            cm = new SqlCommand("Execute SOLARIS.agregoFuncionalidadActual " + codigoRol + " , '" + nombreFuncionalidad + "'", cn);
            cm.ExecuteNonQuery();

        }

    }
}
