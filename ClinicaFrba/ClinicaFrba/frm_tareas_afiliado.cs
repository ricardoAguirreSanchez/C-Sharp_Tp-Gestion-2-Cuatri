using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Compra_Bono;
using ClinicaFrba.Pedir_Turno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba
{
    public partial class frm_tareas_afiliado : Form
    {
        public frm_tareas_afiliado()
        {
            InitializeComponent();
        }

        private void but_Gestion_Rol_Click(object sender, EventArgs e)
        {

        }

        private void but_comprar_bonos_Click(object sender, EventArgs e)
        {
            frm_comprar_bono comprarBono = new frm_comprar_bono();
            comprarBono.Show();
        }

        private void but_pedir_turno_Click(object sender, EventArgs e)
        {
            frm_pedir_turno pedirTurno = new frm_pedir_turno();
            pedirTurno.Show();
        }

        private void but_cancelar_atencion_Click(object sender, EventArgs e)
        {
            frm_cancelar_atencion_afiliado cancelarAtencion = new frm_cancelar_atencion_afiliado();
            cancelarAtencion.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_tareas_afiliado_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.conectar();
            dgv_listadoFuncionalidades.DataSource = cn.funcionalidadesTotalesPorRol("PACIENTE");
        }

        private void but_ir_Click(object sender, EventArgs e)
        {
            if (dgv_listadoFuncionalidades.CurrentRow.Cells[0].Value.ToString() == "Comprar Bonos")
            {
                frm_comprar_bono cb = new frm_comprar_bono();
                cb.Show();
            }
            if (dgv_listadoFuncionalidades.CurrentRow.Cells[0].Value.ToString() == "Pedir Turno")
            {
                frm_pedir_turno pt = new frm_pedir_turno();
                pt.Show();
            }
            if (dgv_listadoFuncionalidades.CurrentRow.Cells[0].Value.ToString() == "Cancelar Atencion")
            {
                frm_cancelar_atencion_afiliado caa = new frm_cancelar_atencion_afiliado();
                caa.Show();
            }
        }
    }
}
