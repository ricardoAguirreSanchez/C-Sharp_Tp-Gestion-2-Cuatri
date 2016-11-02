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
            DataTable especialidades = conexion.traigoEspecialidades();

            cbx_especialidad.DataSource = especialidades;
            cbx_especialidad.DisplayMember = "esp_descripcion";
        }
    }
}
