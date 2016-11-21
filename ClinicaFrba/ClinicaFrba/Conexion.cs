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
            //creo el objeto de la clase appconfig para poder obtenere el host
            AppConfig archivoConfig = new AppConfig();
            try
            {
                cn = new SqlConnection(archivoConfig.obtenerHost());
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
            cm = new SqlCommand("Execute SOLARIS.buscarUsuario '" + clave + "',"+id, cn);
            dr = cm.ExecuteReader();
            
            //se lee, si no hay nada, no entra en el while, si hay algo, entra
            while (dr.Read())
            {
                result = true;
            }
            dr.Close();
            return result;
        }

        
        public Boolean verificarLogeoInhabilitado(String id, String clave)
        {
            
            Boolean result = false;
            //ejecuta el comando select para buscar si existe 
            cm = new SqlCommand("Execute SOLARIS.verificarLogeoInhabilitado " + id + "", cn);
            dr = cm.ExecuteReader();
            
            //se lee, si no hay nada, no entra en el while, si hay algo, entra
            while (dr.Read())
            {
                result = true;
            }
            dr.Close();
            return result;
        }

        //inhabilitoUsuario 
        public void inhabilitoUsuario(String id, String clave)
        {
            cm = new SqlCommand("Execute SOLARIS.inhabilitoUsuario '" + id + "'", cn);
            cm.ExecuteNonQuery();

        }

        public DataTable traigoEspecialidades()
        {

            da = new SqlDataAdapter("SOLARIS.traigoEspecialidad", cn);
            
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable traigoHorario()
        {

            da = new SqlDataAdapter("SOLARIS.traigoHorario", cn);

            dt = new DataTable();
            da.Fill(dt);
            return dt;
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
        public DataTable buscarPacientePorID(string ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SOLARIS.buscarPacientePorID", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@ID_Paciente", ID);
            da.Fill(dt);
            return dt;
        }

        //del github
        public string traigoNombrePlan(Int64 idPlan)
        {
            SqlCommand command = new SqlCommand("SOLARIS.traigoDescripcionPlan", cn);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter descripcion = new SqlParameter("@plm_descripcion", SqlDbType.VarChar, 255);
            descripcion.Direction = ParameterDirection.Output;
            command.Parameters.Add(descripcion);

            command.Parameters.AddWithValue("@plm_codigo", idPlan);
            command.ExecuteScalar();
            return command.Parameters["@plm_descripcion"].Value.ToString();

        }

        //del github
        public int traigoIDPlan(string nombrePlan)
        {
            SqlCommand command = new SqlCommand("SOLARIS.traigoIDPlan", cn);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter ID = new SqlParameter("@plm_codigo", SqlDbType.VarChar, 255);
            ID.Direction = ParameterDirection.Output;
            command.Parameters.Add(ID);

            command.Parameters.AddWithValue("@plm_descripcion", nombrePlan);
            command.ExecuteScalar();
            return int.Parse(command.Parameters["@plm_codigo"].Value.ToString());
        }
        
        public void modificarAfiliado(int tex_numero_afiliado, String tex_Nombre, String tex_apellido, int tex_dni, DateTime dtp_fecha_nacimiento, String tex_direccion, int tex_telefono, String tex_mail, Char sexo, int com_plan_medico)
        {
            SqlCommand command = new SqlCommand("SOLARIS.modificarPaciente", cn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@pac_nro_afiliado", tex_numero_afiliado);
            command.Parameters.AddWithValue("@pac_nombre", tex_Nombre);
            command.Parameters.AddWithValue("@pac_apellido", tex_apellido);
            command.Parameters.AddWithValue("@pac_nro_doc", tex_dni);
            command.Parameters.AddWithValue("@pac_fecha_nac", dtp_fecha_nacimiento);
            command.Parameters.AddWithValue("@pac_direccion", tex_direccion);
            command.Parameters.AddWithValue("@pac_telefono", tex_telefono);
            command.Parameters.AddWithValue("@pac_mail", tex_mail);
            command.Parameters.AddWithValue("@pac_sexo", sexo);
            command.Parameters.AddWithValue("@pac_plan_medico", com_plan_medico);

            command.ExecuteNonQuery();

        }
        public void insertarAfiliado(String tex_Nombre, String tex_apellido, int tex_dni, DateTime dtp_fecha_nacimiento, String tex_direccion, int tex_telefono, String tex_mail, Char sexo, int com_plan_medico)
        {
            SqlCommand command = new SqlCommand("SOLARIS.insertaPaciente", cn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@pac_nombre", tex_Nombre);
            command.Parameters.AddWithValue("@pac_apellido", tex_apellido);
            command.Parameters.AddWithValue("@pac_nro_doc", tex_dni);
            command.Parameters.AddWithValue("@pac_fecha_nac", dtp_fecha_nacimiento);
            command.Parameters.AddWithValue("@pac_direccion", tex_direccion);
            command.Parameters.AddWithValue("@pac_telefono", tex_telefono);
            command.Parameters.AddWithValue("@pac_mail", tex_mail);
            command.Parameters.AddWithValue("@pac_sexo", sexo);
            command.Parameters.AddWithValue("@pac_plan_medico", com_plan_medico);

            command.ExecuteNonQuery();

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

      
        public DataTable especialidadesNombreCodigo()
        {

            da = new SqlDataAdapter("Execute SOLARIS.especialidadesNombreCodigo ", cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        
        public DataTable especialidadPorCodigoMedico(int codigoMedico)
        {

            da = new SqlDataAdapter("Execute SOLARIS.especialidadPorCodigoMedico "+ codigoMedico , cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable nombreMedicoPorCodigoEspecialidad(String codigoEspecialidad)
        {

            da = new SqlDataAdapter("Execute SOLARIS.nombreMedicoPorCodigoEspecialidad " + Convert.ToInt32(codigoEspecialidad), cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable datosTurnoPorCodigoMedico(int codigoMedico, int dia, int mes, int anio, int codigoEspecialidad)
        {

            da = new SqlDataAdapter("Execute SOLARIS.datosTurnoPorCodigoMedico " + codigoMedico + "," + dia + "," + mes + "," + anio + "," + codigoEspecialidad, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable bonosDisponiblesPorAfiliado(int codigoAfiliado)
        {

            da = new SqlDataAdapter("Execute SOLARIS.bonosDisponiblesPorAfiliado " + codigoAfiliado, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void registrarConsulta(int codigoTurno, int codigoBono, DateTime dt)
        {
            cm = new SqlCommand("Execute SOLARIS.registrarConsulta " + codigoTurno + " , " + codigoBono + ", '"+ dt +"'", cn);
            cm.ExecuteNonQuery();

        }

        public void completarCamposEnBonoPorUnaConsulta(int codigoTurno, int codigoBono)
        {
            cm = new SqlCommand("Execute SOLARIS.completarCamposEnBonoPorUnaConsulta " + codigoTurno + " , " + codigoBono , cn);
            cm.ExecuteNonQuery();

        }

         //esto completa lo q faltaba en consulta
        public void completarCamposEnConsultaPorRegistroResultado(int codigoConsulta,String sintomas, String diagnostico, DateTime dtSistema)
        {
            cm = new SqlCommand("Execute SOLARIS.completarCamposEnConsultaPorRegistroResultado " + codigoConsulta + ",'" + sintomas + "','" + diagnostico + "','" + dtSistema+"'", cn);
            cm.ExecuteNonQuery();

        }
        //esto cambia de estado el turno
        public void cambioEstadoTurnoPorUnaConsultaFinalizada(int codigoConsulta)
        {
            cm = new SqlCommand("Execute SOLARIS.cambioEstadoTurnoPorUnaConsultaFinalizada "+codigoConsulta, cn);
            cm.ExecuteNonQuery();

        }

        //trae el  numero,afiliado,medico y fecha de consulta 
        public DataTable buscarConsultasPorID(int codigoMedico, int dia, int mes, int anio)
        {
            da = new SqlDataAdapter("Execute SOLARIS.buscarConsultasPorID " + codigoMedico + "," + dia + "," + mes + "," + anio, cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        internal void bajarAfiliado(int codigo)
        {
            SqlCommand command = new SqlCommand("SOLARIS.bajarPacientes", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@plm_codigo",codigo);
            command.ExecuteNonQuery();
        }
        public int consultarPrecioBono(Int64 codigo)
        {
            SqlCommand command = new SqlCommand("SOLARIS.calcularPrecioCompraBono", cn);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter precio = new SqlParameter("@pac_precio_bono_consulta",SqlDbType.Int);
            precio.Direction = ParameterDirection.Output;
            command.Parameters.Add(precio);
            command.Parameters.AddWithValue("@pac_nro_afiliado", codigo);
            
            command.ExecuteScalar();
            return int.Parse(command.Parameters["@pac_precio_bono_consulta"].Value.ToString());

        }
        public int consultarPrecioFarmacia(Int64 codigo)
        {
            SqlCommand command = new SqlCommand("SOLARIS.calcularPrecioCompraFarmacia", cn);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter precio = new SqlParameter("@pac_precio_bono_farmacia", SqlDbType.Int);
            precio.Direction = ParameterDirection.Output;
            command.Parameters.Add(precio);
            command.Parameters.AddWithValue("@pac_nro_afiliado", codigo);

            command.ExecuteScalar();
            return int.Parse(command.Parameters["@pac_precio_bono_farmacia"].Value.ToString());
        }

        public void comprarBono(Int64 codigo, Char tipoBono)
        {
            try
            {
                AppConfig ac = new AppConfig();
                DateTime fechaSistema = Convert.ToDateTime(ac.obtenerFecha());

                SqlCommand command = new SqlCommand("SOLARIS.insertarUnBono", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bon_afiliado_compra", codigo);
                command.Parameters.AddWithValue("@bon_tipo_bono", tipoBono);
                command.Parameters.AddWithValue("@fecha_de_hoy", fechaSistema);
                command.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        //trae el  codigo y tipo de cancelacion 
        public DataTable tiposCancelacion()
        {
            da = new SqlDataAdapter("Execute SOLARIS.tiposCancelacion ", cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        
        //trae los dias de la agenda del medico posteriores a la fecha del sistema
        public DataTable diasDeAgendaParaCancelar(int codigoMedico, DateTime dtSistema)
        {
            da = new SqlDataAdapter("Execute SOLARIS.diasDeAgendaParaCancelar " + codigoMedico + ",'" + dtSistema + "'", cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //cancela todos los turnos del medico y de ese dia
        public void cancelarTurnos(DateTime  dt, int codigoMedico, string detalle, int codigoTipoTurno)
        {
            cm = new SqlCommand("Execute SOLARIS.cancelarTurnos '" + dt + "', " + codigoMedico+",'"+detalle+"',"+codigoTipoTurno, cn);
            cm.ExecuteNonQuery();

        }

        //borra los horarios del medico de su agenda respecto a la fecha pedida
        public void borrarDiaDeAgenda(DateTime dt, int codigoMedico)
        {
            cm = new SqlCommand("Execute SOLARIS.borrarDiaDeAgenda '" + dt + "', " + codigoMedico, cn);
            cm.ExecuteNonQuery();

        }

        
         //cancela todos los turnos del medico y de ese dia en el horario indicado
        public void cancelarTurnosHorarios(DateTime dt, int codigoMedico, string detalle, int codigoTipoTurno, DateTime desde, DateTime hasta)
        {
            cm = new SqlCommand("Execute SOLARIS.cancelarTurnosHorarios '" + dt + "', " + codigoMedico + ",'" + detalle + "'," + codigoTipoTurno+",'"+desde+"','"+hasta+"'", cn);
            cm.ExecuteNonQuery();

        }

        //borra los horarios del medico de su agenda respecto a la fecha pedida en el horario pedido
        public void borrarDiaDeAgendaHorarios(DateTime dt, int codigoMedico, DateTime desde, DateTime hasta)
        {
            cm = new SqlCommand("Execute SOLARIS.borrarDiaDeAgendaHorarios '" + dt + "', " + codigoMedico+",'"+desde+"','"+hasta+"'", cn);
            cm.ExecuteNonQuery();

        }

        public DataTable datosTurnoPorNumeroAfiliado(int numeroAfiliado, DateTime fecha)
        {

            da = new SqlDataAdapter("Execute SOLARIS.datosTurnoPorNumeroAfiliado " + numeroAfiliado + ", '" + fecha + "'", cn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        //cancela el turno elegido
        //cancelarTurnoElegido(codigoTurno, numeroAfiliado, detalle, codigoTipoTurno);
        public void cancelarTurnoElegido(int codigoTurno, int numeroAfiliado, String detalle, int codigoTipoTurno)
        {
            cm = new SqlCommand("Execute SOLARIS.cancelarTurnoElegido " + codigoTurno + "," + numeroAfiliado + ",'" + detalle + "'," + codigoTipoTurno, cn);
            cm.ExecuteNonQuery();

        }

        
        public void insertarAgendaMedico(int codigoMedico, int codigoEspecialidad, DateTime fechafinal )
        {
            cm = new SqlCommand("Execute SOLARIS.insertarAgendaMedico " + codigoMedico + "," + codigoEspecialidad + ",'" + fechafinal + "'", cn);
            cm.ExecuteNonQuery();

        }
    }
}
