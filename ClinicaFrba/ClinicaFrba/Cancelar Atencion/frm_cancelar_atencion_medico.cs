using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class frm_cancelar_atencion_medico : Form
    {
        public frm_cancelar_atencion_medico()
        {
            InitializeComponent();
        }

        private void frm_cancelar_atencion_medico_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.conectar();
            dgv_tipo_cancelacion.DataSource = cn.tiposCancelacion();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void but_cancelar_periodo_Click(object sender, EventArgs e)
        {
            /*El medico deja su codigo, luego elige como desea cancelar su agenda, por periodo o por dia, finalmente
             * deja registro del tipo de cancelacion y del motivo.
             *1.- se cancelan todos los turnos q tengan ese horario
             *2.- se borra ese horario o perido de la agenda del medico
             */

            DateTime dtp_desde = new DateTime();
            if (tex_desde.Text != "")
            {
                dtp_desde = Convert.ToDateTime(tex_desde.Text);
            }

            DateTime dtp_hasta = new DateTime();
            if (tex_hasta.Text != "")
            {
                dtp_hasta = Convert.ToDateTime(tex_hasta.Text);
            }



            if (rb_cancelar_dia.Checked == true)
            {
                Conexion cn = new Conexion();
                cn.conectar();
               
                //se toma el detalle, codigo medico, dia elegido y el codigo de tipo de turno
                String detalle = tex_detalle_cancelacion.Text;
                int codigoMedico =Convert.ToInt32(tex_codigo_medico.Text);
                DateTime dt = Convert.ToDateTime( dgv_cancelar_dia.CurrentRow.Cells[0].Value.ToString());
                int codigoTipoTurno = Convert.ToInt32(dgv_tipo_cancelacion.CurrentRow.Cells[0].Value.ToString());

                //cancelara todos los turnos del dia elegido que sea del medico 
                cn.cancelarTurnos(dt, codigoMedico, detalle, codigoTipoTurno);
                //borra el dia elegido de la agenda
                cn.borrarDiaDeAgenda(dt,codigoMedico);
                MessageBox.Show("Turnos y dia cancelado con exito");
                this.Close();

            }
            if (rb_cancelar_periodo.Checked == true)
            {
                
                //se deja elegir el horario que quiere anular de su agenda del dia actual
                Conexion cn2 = new Conexion();
                cn2.conectar();
                //obtengo de la fecha del dgv
                
                DateTime fechaSistema = Convert.ToDateTime(dgv_cancelar_dia.CurrentRow.Cells[0].Value.ToString());
                                
                //obtengo los horarios
                DateTime desde = Convert.ToDateTime(dtp_desde.ToString("HH:mm "));
                DateTime hasta = Convert.ToDateTime(dtp_hasta.ToString("HH:mm "));
                

                String detalle = tex_detalle_cancelacion.Text;
                int codigoMedico = Convert.ToInt32(tex_codigo_medico.Text);
                int codigoTipoTurno = Convert.ToInt32(dgv_tipo_cancelacion.CurrentRow.Cells[0].Value.ToString());

                

                //cancelara todos los turnos del dia actual en el horario indicado 
                cn2.cancelarTurnosHorarios(fechaSistema, codigoMedico, detalle, codigoTipoTurno,desde,hasta);
                
                
                //borra el dia elegido de la agenda
                cn2.borrarDiaDeAgendaHorarios(fechaSistema,codigoMedico,desde,hasta);
                MessageBox.Show("Turnos y dia cancelado con exito");
                this.Close();


            }
            

        }

        private void rb_cancelar_periodo_CheckedChanged(object sender, EventArgs e)
        {
            gb_cancelar_dia.Enabled = false;
        }

        private void rb_cancelar_dia_CheckedChanged(object sender, EventArgs e)
        {
            gb_cancelar_periodo.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lleno el dgv

            //traigo el codigo del medico
            int codigoMedico = Convert.ToInt32(tex_codigo_medico.Text);

            //obtengo de la fecha del sistema
            AppConfig ac = new AppConfig();
            DateTime fechaSistema = Convert.ToDateTime(ac.obtenerFecha());


            //abro conexion
            Conexion cn = new Conexion();
            cn.conectar();

            //pido los dias de la agenda del medico que se podran cancelar, esto requiere del codigo del medico
            //y de la fecha actual, DADO QUE NO PUEDE CANCELAR EL DIA ACTUAL, SOLO LOS POSTERIORES.
            dgv_cancelar_dia.DataSource = cn.diasDeAgendaParaCancelar(codigoMedico, fechaSistema);

        }

        private void dgv_cancelar_dia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
