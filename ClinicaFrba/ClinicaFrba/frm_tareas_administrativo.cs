using ClinicaFrba.AbmRol;
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
    public partial class frm_tareas_administrativo : Form
    {
        public frm_tareas_administrativo()
        {
            InitializeComponent();
        }

        private void but_administrar_rol_Click(object sender, EventArgs e)
        {
            frm_administrar_roles abmRol = new frm_administrar_roles();
            abmRol.Show();
        }

        private void but_administrar_afiliado_Click(object sender, EventArgs e)
        {
            frm_administrar_afiliados abmAfiliado = new frm_administrar_afiliados();
            abmAfiliado.Show();
        }

        private void but_consultar_estadisticas_Click(object sender, EventArgs e)
        {
            frm_consultar_estadisticas listado = new frm_consultar_estadisticas();
            listado.Show();
        }

        private void but_registrar_llegada_Click(object sender, EventArgs e)
        {
            frm_registrar_llegada registroLlegada = new frm_registrar_llegada();
            registroLlegada.Show();
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
    }
}
