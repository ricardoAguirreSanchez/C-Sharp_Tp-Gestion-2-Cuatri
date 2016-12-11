using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class frm_pedir_turno : Form
    {
        public frm_pedir_turno()
        {
            InitializeComponent();
        }

        private void frm_pedir_turno_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();

            //asigno la fecha del sistema como fecha inicial al dtp
            AppConfig ap = new AppConfig();
            dtp_fecha_hasta.Value = Convert.ToDateTime(ap.obtenerFecha());
            dtp_fecha_desde.Value = Convert.ToDateTime(ap.obtenerFecha());

            //el dgv tendra codigo(0) y descripcion de especialidad(1) del medico
            dgv_especialidades.DataSource = conexion.especialidadesNombreCodigo();

            //oculata la columna "Codigo"
            this.dgv_especialidades.Columns["Codigo"].Visible = true;

            but_aceptar_medico.Enabled = false;
            but_mostrar_horario.Enabled = false;
            but_reservar.Enabled = false;
            but_buscar_medicos.Enabled = false;
        }

        private void but_buscar_Click(object sender, EventArgs e)
        {

        }

        private void but_reservar_Click(object sender, EventArgs e)
        {
            //toma el codigo de paciente, el codigo de agenda y crea el turno en estado 0 (reservado) y con codigo igual al maximo - 1
            int codigoPaciente = Convert.ToInt32(tex_numero_afiliado.Text);

            int codigoAgenda = Convert.ToInt32(dgv_listado_horarios.CurrentRow.Cells[0].Value.ToString());
            try
            {
                Conexion conexion = new Conexion();
                conexion.conectar();
                conexion.crearTurno(codigoPaciente, codigoAgenda);
                MessageBox.Show("Turno Registrado Correctamente");
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("ERROR al momento de registrar turno "+ err);
            }
        }

        private void dgv_listado_turnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_buscar_medicos_Click(object sender, EventArgs e)
        {
            //al hacer click en una fila del dgv_especialidades, va a mostrar el listado de nombre de medicos con dicha especialidad a cargo
            Conexion conexion = new Conexion();
            conexion.conectar();
            //el dgv tendra codigo(0) ,nombre(1) y apellido(2) del medico
            dgv_listado_medicos.DataSource = conexion.nombreMedicoPorCodigoEspecialidad(dgv_especialidades.CurrentRow.Cells[0].Value.ToString());
            this.dgv_listado_medicos.Columns["Codigo"].Visible = false;

            but_aceptar_medico.Enabled = true;
        }

        private void but_aceptar_medico_Click(object sender, EventArgs e)
        {
            but_mostrar_horario.Enabled = true;
        }

        private void but_mostrar_horario_Click(object sender, EventArgs e)
        {
            //Solo mostrar aquellos horarios disponibles que NO tengan asociado previamente un turno, inicialmente en la migracion
            //todo esta como RESERVADO, asi que para probar la funcionalidad es necesario crear previamente unas cuantas fechas para la agenda
            but_reservar.Enabled = true;

            Conexion conexion = new Conexion();
            conexion.conectar();

            int codigoMedico = Convert.ToInt32(dgv_listado_medicos.CurrentRow.Cells[0].Value.ToString());
            //obtengo la especialidad
            int codigoEspecialidad = Convert.ToInt32(dgv_especialidades.CurrentRow.Cells[0].Value.ToString());

            //obtengo de la fecha del sistema, luego el dia,mes y anio para filtrar los turnos
            AppConfig ac = new AppConfig();
            String fecha = ac.obtenerFecha();
            DateTime fechaDesdeSistema = Convert.ToDateTime(fecha);
            DateTime fechaHastaIngresada = dtp_fecha_hasta.Value;

            //el dgv tendra: codigo de agenda (para luego usarlo en mi turno como "tur_age_cod"), fecha desde y fecha hasta con horarios de la agenda disponible 
            dgv_listado_horarios.DataSource = conexion.datosHorarios(codigoMedico,codigoEspecialidad,fechaDesdeSistema,fechaHastaIngresada);
            this.dgv_listado_horarios.Columns["Codigo"].Visible = true;




        }

        private void but_verificar_Click(object sender, EventArgs e)
        {
            int codigoAfiliado = Convert.ToInt32(tex_numero_afiliado.Text);

            Conexion conexion = new Conexion();
            conexion.conectar();


            if (conexion.afiliadoDadoBaja(codigoAfiliado))
            {
                MessageBox.Show("Imposible reserver, afiliado dado de baja");
                this.Close();
            }
            else
            {
                but_buscar_medicos.Enabled=true; 
            }


        }
    }
}
