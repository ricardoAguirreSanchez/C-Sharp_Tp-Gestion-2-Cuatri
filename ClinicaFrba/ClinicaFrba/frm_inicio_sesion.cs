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
    public partial class frm_inicio_sesion : Form
    {
        public frm_inicio_sesion()
        {
            InitializeComponent();
            but_Aceptar.Enabled = false;
        }

        private void but_Ingresar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();
            if (conexion.verificarLogeo(tex_username.Text, tex_password.Text))
            {
                dgw_Roles_a_elegir.DataSource = conexion.roles(tex_username.Text);
                but_Aceptar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrecto");
                tex_password.Clear();
                tex_username.Clear();
            }

        }
    }
}
