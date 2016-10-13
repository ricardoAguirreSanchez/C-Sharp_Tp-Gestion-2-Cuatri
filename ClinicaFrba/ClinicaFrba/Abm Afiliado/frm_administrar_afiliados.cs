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
            tex_nombre.Enabled = false;
            tex_apellido.Enabled = false;
            tex_dni.Enabled = false;
            dtp_fecha_nacimiento.Enabled = false;
            tex_direccion.Enabled = false;
            tex_telefono.Enabled = false;
            tex_mail.Enabled = false;
            rdb_femenino.Enabled = false;
            rdb_masculino.Enabled = false;
            com_plan_medico.Enabled = false;
            tex_dni_asociado_principal.Enabled = false;
            but_modificar.Visible = false;
            but_eliminar.Visible = false;
            but_cargarnuevo.Visible = false;
            but_descartarNuevo.Visible = false;
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
            //Habilito controles
            tex_numero_afiliado.Enabled = true;
            tex_nombre.Enabled = true;
            tex_apellido.Enabled = true;
            tex_dni.Enabled = true;
            dtp_fecha_nacimiento.Enabled = true;
            tex_direccion.Enabled = true;
            tex_telefono.Enabled = true;
            tex_mail.Enabled = true;
            rdb_femenino.Enabled = true;
            rdb_masculino.Enabled = true;
            com_plan_medico.Enabled = true;
            tex_dni_asociado_principal.Enabled = true;
            but_modificar.Visible = true;
            but_eliminar.Visible = true;

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

        private void rdb_femenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            but_buscar.Enabled = false;
            tex_numero_afiliado.Text = "";
            tex_nombre.Text = "";
            tex_apellido.Text = "";
            tex_dni.Text = "";
            tex_telefono.Text = "";
            tex_mail.Text = "";
            tex_dni_asociado_principal.Text = "";
            tex_direccion.Text = "";

            tex_numero_afiliado.Enabled = false;
            but_modificar.Visible = false;
            but_eliminar.Visible = false;
            but_cargarnuevo.Visible = true;
            but_descartarNuevo.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tex_numero_afiliado.Enabled = true;
            tex_nombre.Enabled = false;
            tex_apellido.Enabled = false;
            tex_dni.Enabled = false;
            dtp_fecha_nacimiento.Enabled = false;
            tex_direccion.Enabled = false;
            tex_telefono.Enabled = false;
            tex_mail.Enabled = false;
            rdb_femenino.Enabled = false;
            rdb_masculino.Enabled = false;
            com_plan_medico.Enabled = false;
            tex_dni_asociado_principal.Enabled = false;
            but_modificar.Visible = false;
            but_eliminar.Visible = false;
            but_cargarnuevo.Visible = false;
            but_descartarNuevo.Visible = false;
            but_buscar.Enabled = true;
        }
    }
}
