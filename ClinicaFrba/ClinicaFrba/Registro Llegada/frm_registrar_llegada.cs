using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class frm_registrar_llegada : Form
    {
        public frm_registrar_llegada()
        {
            InitializeComponent();
        }

        private void frm_registrar_llegada_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();

            //el dgv tendra codigo(0) y descripcion de especialidad(1) del medico
            dgv_especialidades.DataSource = conexion.especialidadesNombreCodigo();
            
            //oculata la columna "Codigo"
            this.dgv_especialidades.Columns["Codigo"].Visible = false;

        }

        private void but_buscar_medico_Click(object sender, EventArgs e)
        {
            

        }

        private void dgv_listado_medicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dgv_especialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            
        }

        private void dgv_listado_medicos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_especialidades_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_especialidades_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_especialidades_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //al hacer click en una fila del dgv_especialidades, va a mostrar el listado de nombre de medicos con dicha especialidad a cargo
            Conexion conexion = new Conexion();
            conexion.conectar();
            //el dgv tendra codigo(0) ,nombre(1) y apellido(2) del medico
            dgv_listado_medicos.DataSource = conexion.nombreMedicoPorCodigoEspecialidad(dgv_especialidades.CurrentRow.Cells[0].Value.ToString());
            this.dgv_listado_medicos.Columns["Codigo"].Visible = false;
        }

        private void but_buscar_medicos_Click(object sender, EventArgs e)
        {
            //al hacer click en una fila del dgv_especialidades, va a mostrar el listado de nombre de medicos con dicha especialidad a cargo
            Conexion conexion = new Conexion();
            conexion.conectar();
            //el dgv tendra codigo(0) ,nombre(1) y apellido(2) del medico
            dgv_listado_medicos.DataSource = conexion.nombreMedicoPorCodigoEspecialidad(dgv_especialidades.CurrentRow.Cells[0].Value.ToString());
            this.dgv_listado_medicos.Columns["Codigo"].Visible = false;
        }

        private void but_Buscar_turnos_Click(object sender, EventArgs e)
        {
            //al hacer click en una fila del dgv_especialidades, va a mostrar el listado de nombre de medicos con dicha especialidad a cargo
            Conexion conexion = new Conexion();
            conexion.conectar();

            int codigoMedico = Convert.ToInt32(dgv_listado_medicos.CurrentRow.Cells[0].Value.ToString());
            
            //obtengo la especialidad
            int codigoEspecialidad = Convert.ToInt32(dgv_especialidades.CurrentRow.Cells[0].Value.ToString());
           
            //obtengo de la fecha del sistema, luego el dia,mes y anio para filtrar los turnos
            AppConfig ac = new AppConfig();
            String fecha = ac.obtenerFecha();
            DateTime dt = Convert.ToDateTime(fecha);
            int dia = dt.Day;
            int mes = dt.Month;
            int anio = dt.Year;

            //el dgv tendra: codigo, fecha, numero de afliado
            dgv_turnos_del_dia.DataSource = conexion.datosTurnoPorCodigoMedico(codigoMedico, dia, mes, anio, codigoEspecialidad);
            this.dgv_turnos_del_dia.Columns["Codigo"].Visible = false;
        }

        private void but_Buscar_bono_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.conectar();

                int codigoAfiliado = Convert.ToInt32(dgv_turnos_del_dia.CurrentRow.Cells[2].Value.ToString());
                //el dgv tendra: cod del bono disponible, tomando encuenta la restricciones de plan, grupo familiar y estado del bono
                dgv_bono_consulta_disponibles.DataSource = conexion.bonosDisponiblesPorAfiliado(codigoAfiliado);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al tratar de buscar los bonos");
            }
        }

        private void but_registrar_Click(object sender, EventArgs e)
        {
            /*ESTE BOTON HARA LOS SIGUIENTES CAMBIOS:
             * 1.- En "bono" : bon_nro_consulta, bon_fue_utilizado y bon_afiliado_uso
             * 2.- En "consulta" :
             * con_numero, con_fecha (fecha del turno),con_turno(saco del dgv_turnos_del_dia) ,
             * con_hora_llegada(fecha del sistema, dado q es la fecha actual), con_hora_medico(ESTO SE COMPLETARA CUANDO SE DE POR FINALIZADO EL TURNO)
             * 3.- En "turno" : tur_estado (sera "FINALIZADO PARCIALMENTE 1")
            */
            try
            {
                Conexion conexion = new Conexion();
                conexion.conectar();
                int codigoTurno = Convert.ToInt32(dgv_turnos_del_dia.CurrentRow.Cells[0].Value.ToString());
                int codigoBono = Convert.ToInt32(dgv_bono_consulta_disponibles.CurrentRow.Cells[0].Value.ToString());

                //fecha del sistema
                AppConfig ac = new AppConfig();
                String fechaSistema = ac.obtenerFecha();
                DateTime dt1 = Convert.ToDateTime(fechaSistema);

                
                //esto registra la consulta (y activa el trigger para la tabla turno)
                conexion.registrarConsulta(codigoTurno, codigoBono,dt1);

                MessageBox.Show("turno" + codigoTurno +"bono"+ codigoBono);
                //esto completa los campos para la tabla bono
                conexion.completarCamposEnBonoPorUnaConsulta(codigoTurno,codigoBono);
                MessageBox.Show("Agregado correctamente");
                this.Close();
            }
            catch (Exception ERROR)
            {
                MessageBox.Show("No se pudo registrar la CONSULTA por: " + ERROR);
            }
        }

        
    }
}
