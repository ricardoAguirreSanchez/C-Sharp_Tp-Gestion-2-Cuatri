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
    public partial class frm_administrar_afiliados : Form
    {
        public frm_administrar_afiliados()
        {
            InitializeComponent();
        }

        private void frm_administrar_afiliados_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void opcional_Click(object sender, EventArgs e)
        {

        }

        private void but_buscar_Click(object sender, EventArgs e)
        {
            //Conecto a BD
            Conexion conexion = new Conexion();
            conexion.conectar();

            string ID_Afiliado = tex_numero_afiliado.Text;

            Array paciente = conexion.buscarPacientePorID(ID_Afiliado);

            //Completo los campos
            tex_nombre.Text = paciente.GetValue(0).ToString();
            tex_apellido.Text = paciente.GetValue(1).ToString();
            tex_dni.Text = paciente.GetValue(2).ToString();
            tex_direccion.Text = paciente.GetValue(3).ToString();
            tex_telefono.Text = paciente.GetValue(4).ToString();
            tex_mail.Text = paciente.GetValue(5).ToString();
            tex_dni_asociado_principal.Text = paciente.GetValue(6).ToString();
            //tex_fecha.Text = paciente.GetValue(3).ToString();
        }
    }
}
