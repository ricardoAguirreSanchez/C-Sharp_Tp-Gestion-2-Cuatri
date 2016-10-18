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

            //el dgv tendra fecha,numero, afliado, medico del turno
            dgv_turnos_del_dia.DataSource = conexion.datosTurnoPorCodigoMedico(codigoMedico);
            this.dgv_listado_medicos.Columns["Codigo"].Visible = false;
        }

        
    }
}
