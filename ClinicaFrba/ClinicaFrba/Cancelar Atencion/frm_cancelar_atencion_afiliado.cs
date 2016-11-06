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
    public partial class frm_cancelar_atencion_afiliado : Form
    {
        public frm_cancelar_atencion_afiliado()
        {
            InitializeComponent();
        }

        private void but_buscar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();

            int numeroAfiliado = Convert.ToInt32(tex_num_afiliado.Text);

            //obtengo de la fecha del sistema, luego el dia,mes y anio para filtrar los turnos
            AppConfig ac = new AppConfig();
            String fecha = ac.obtenerFecha();
            DateTime fechaDT = Convert.ToDateTime(fecha);
            
            //el dgv tendra: codigo turno,  fecha (traida de la agenda)
            dgv_listado_turnos.DataSource = conexion.datosTurnoPorNumeroAfiliado(numeroAfiliado,fechaDT);
            
        }

        private void frm_cancelar_atencion_afiliado_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.conectar();
            dgv_tipo_cancelacion.DataSource = cn.tiposCancelacion();

        }

        private void but_cancelar_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.conectar();

            //se toma el detalle, numeroAfiliado, codigoTipoTurno y codigoTurno
            String detalle = tex_detalle_cancelacion.Text;
            int numeroAfiliado = Convert.ToInt32(tex_num_afiliado.Text);

            int codigoTipoTurno = Convert.ToInt32(dgv_tipo_cancelacion.CurrentRow.Cells[0].Value.ToString());

            int codigoTurno = Convert.ToInt32(dgv_listado_turnos.CurrentRow.Cells[0].Value.ToString());
            
            
            //cancela el turno elegido
            cn.cancelarTurnoElegido(codigoTurno, numeroAfiliado, detalle, codigoTipoTurno);
            
            MessageBox.Show("Turnos cancelado con exito");
            this.Close();

        }
    }
}
