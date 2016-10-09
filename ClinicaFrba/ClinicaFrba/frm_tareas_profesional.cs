using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Registro_Resultado;
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
    public partial class frm_tareas_profesional : Form
    {
        public frm_tareas_profesional()
        {
            InitializeComponent();
        }

        private void but_cancelar_atencion_Click(object sender, EventArgs e)
        {
            frm_cancelar_atencion_medico cancelarAtencion = new frm_cancelar_atencion_medico();
            cancelarAtencion.Show();

        }

        private void but_registro_resultado_Click(object sender, EventArgs e)
        {
            frm_registro_resultado registro = new frm_registro_resultado();
            registro.Show();
        }
    }
}
