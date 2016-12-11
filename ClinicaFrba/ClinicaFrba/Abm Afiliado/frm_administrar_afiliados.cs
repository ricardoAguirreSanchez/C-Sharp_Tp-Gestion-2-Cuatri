
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
            com_estado_civil.Enabled = false;
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
            com_estado_civil.Enabled = true;
            but_modificar.Visible = true;
            but_eliminar.Visible = true;
            
            try {
            //Conecto a BD
            Conexion conexion = new Conexion();
            conexion.conectar();

            string ID_Afiliado = tex_numero_afiliado.Text;

            DataTable paciente = conexion.buscarPacientePorID(ID_Afiliado);
            DataRow filaPaciente = paciente.Rows[0];

            //Completo los campos
            tex_nombre.Text = filaPaciente["pac_nombre"].ToString();
            tex_apellido.Text = filaPaciente["pac_apellido"].ToString();
            tex_dni.Text = filaPaciente["pac_nro_doc"].ToString();
            tex_direccion.Text = filaPaciente["pac_direccion"].ToString();      
	        tex_telefono.Text = filaPaciente["pac_telefono"].ToString();
            tex_mail.Text = filaPaciente["pac_mail"].ToString();
            dtp_fecha_nacimiento.Value = Convert.ToDateTime(filaPaciente["pac_fecha_nac"]);
            if(filaPaciente["pac_sexo"].ToString() == "F")
            { rdb_femenino.Checked = true; rdb_masculino.Checked = false;}
            else if (filaPaciente["pac_sexo"].ToString() == "M")
            {rdb_femenino.Checked = false; rdb_masculino.Checked = true; }
            com_estado_civil.SelectedItem = conexion.traigoNombreEstadoCivil(filaPaciente["pac_estado_civil"].ToString());
            com_plan_medico.SelectedItem = conexion.traigoNombrePlan(Convert.ToInt64(filaPaciente["pac_plan_medico"].ToString()));
            if (filaPaciente["pac_tit_relacion"].ToString() != "")
            {
                cbxFamiliar.Checked = true;
                txtDNITitular.Text = filaPaciente["pac_tit_relacion"].ToString();
            }
            else { cbxFamiliar.Checked = false; }

        }
            catch (Exception er1)
            {
                MessageBox.Show("Afiliado no encontrado o eliminado");
            }
        }

        private void rdb_femenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //modifico el nombre y estado
            try
            {
                Conexion conexion = new Conexion();
                conexion.conectar();

                DateTime fecha_nac = dtp_fecha_nacimiento.Value;
                Char sexo;

                if (rdb_masculino.Checked)
                { sexo = 'M'; }
                else { sexo = 'F'; };

                int plan_medico = conexion.traigoIDPlan(com_plan_medico.SelectedItem.ToString());
                int estado_civil = conexion.traigoIDEstadoCivil(com_estado_civil.SelectedItem.ToString());
                int idTitular;
                int idNuevoAfiliado = 0;
                if (txtDNITitular.Text != "")
                {
                    idTitular = int.Parse(txtDNITitular.Text);
                    
                    //paso todos los valores para actualizar si tiene un titular
                    idNuevoAfiliado = conexion.insertarAfiliado(tex_nombre.Text, tex_apellido.Text, int.Parse(tex_dni.Text), fecha_nac, tex_direccion.Text, int.Parse(tex_telefono.Text), tex_mail.Text, sexo, plan_medico, estado_civil, idTitular);

                }
                else {
                    //paso todos los valores para actualizar si NO tiene un titular
                   idNuevoAfiliado = conexion.insertarAfiliado(tex_nombre.Text, tex_apellido.Text, int.Parse(tex_dni.Text), fecha_nac, tex_direccion.Text, int.Parse(tex_telefono.Text), tex_mail.Text, sexo, plan_medico, estado_civil);
                }

                //int idPaciente = conexion.traerUltimoPaciente();
                MessageBox.Show("Agregado! ID: " + idNuevoAfiliado);
            }
            catch (Exception er1)
            {
                MessageBox.Show("Error al insertar el afiliado:" + er1);
            }

            this.Close();

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            but_buscar.Enabled = false;
            tex_numero_afiliado.Text = "";
            tex_nombre.Text = ""; tex_nombre.Enabled = true;
            tex_apellido.Text = ""; tex_apellido.Enabled = true;
            tex_dni.Text = ""; tex_dni.Enabled = true;
            tex_telefono.Text = ""; tex_telefono.Enabled = true;
            tex_mail.Text = ""; tex_mail.Enabled = true;
            dtp_fecha_nacimiento.Enabled = true;
            rdb_femenino.Enabled = true; rdb_masculino.Enabled = true; rdb_masculino.Checked = true;
            com_plan_medico.Enabled = true; com_plan_medico.SelectedIndex = 1;
            com_estado_civil.Enabled = true; com_estado_civil.SelectedIndex = 1;
            tex_direccion.Text = ""; tex_direccion.Enabled = true;

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
            but_modificar.Visible = false;
            but_eliminar.Visible = false;
            but_cargarnuevo.Visible = false;
            but_descartarNuevo.Visible = false;
            but_buscar.Enabled = true;
            
        }

        private void but_modificar_Click(object sender, EventArgs e)
        {
          
            //modifico el nombre y estado
            try
            {
                Conexion conexion = new Conexion();
                conexion.conectar();

                DateTime fecha_nac = dtp_fecha_nacimiento.Value;
                Char sexo;

                if (rdb_masculino.Checked)
                { sexo = 'M'; }
                else { sexo = 'F'; };

                int estado_civil = 0;
                                 
                int dniTitular;

                if (com_estado_civil.SelectedItem != null)
                {
                    int plan_medico = conexion.traigoIDPlan(com_plan_medico.SelectedItem.ToString());
                    estado_civil = conexion.traigoIDEstadoCivil(com_estado_civil.SelectedItem.ToString());

                    if (txtDNITitular.Text != "" & cbxFamiliar.Checked == true)
                    {
                        dniTitular = int.Parse(txtDNITitular.Text);
                        
                        //cargo fecha del sistema
                        AppConfig ap = new AppConfig();
                        DateTime fechaSistema = Convert.ToDateTime(ap.obtenerFecha());
                        conexion.cargaFecha(fechaSistema);

                        //paso todos los valores para actualizar si tiene un titular
                        conexion.modificarAfiliado(int.Parse(tex_numero_afiliado.Text), tex_nombre.Text, tex_apellido.Text, int.Parse(tex_dni.Text), fecha_nac, tex_direccion.Text, int.Parse(tex_telefono.Text), tex_mail.Text, sexo, plan_medico, estado_civil,dniTitular);
               
                    }
                    else if ((txtDNITitular.Text == "" & cbxFamiliar.Checked == false))
                    {
                        //cargo fecha del sistema
                        AppConfig ap = new AppConfig();
                        DateTime fechaSistema = Convert.ToDateTime(ap.obtenerFecha());
                        conexion.cargaFecha(fechaSistema);

                        //paso todos los valores para actualizar si NO tiene un titular
                        conexion.modificarAfiliado(int.Parse(tex_numero_afiliado.Text), tex_nombre.Text, tex_apellido.Text, int.Parse(tex_dni.Text), fecha_nac, tex_direccion.Text, int.Parse(tex_telefono.Text), tex_mail.Text, sexo, plan_medico, estado_civil);
                    }
                    //paso todos los valores para actualizar
                    MessageBox.Show("Modificado!");
                }

                else { MessageBox.Show("Completar Estado Civil!"); }
            }
            catch (Exception er1)
            {
                MessageBox.Show("Error al actualizar el afiliado:" + er1);
                this.Close();
            }


        }

        private void but_eliminar_Click(object sender, EventArgs e)
        {
            //modifico el nombre y estado
            try
            {
                //busco la fecha del sistema
                AppConfig ap = new AppConfig();
                DateTime fechaSistema = Convert.ToDateTime(ap.obtenerFecha());
                
                
                Conexion conexion = new Conexion();
                conexion.conectar();

                conexion.bajarAfiliado(int.Parse(tex_numero_afiliado.Text),fechaSistema);
                MessageBox.Show("Eliminado!");
            }
            catch (Exception er1)
            {
                MessageBox.Show("Error eliminando el afiliado:" + er1);
            }

            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFamiliar.Checked) { txtDNITitular.Enabled = true; }
            else { txtDNITitular.Enabled = false; }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtDNITitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (tex_numero_afiliado.Text != "")
            {
                frm_historial_plan frm = new frm_historial_plan();
                frm.txtID.Text = tex_numero_afiliado.Text;
                frm.Show();
            
            }
            
        }
    }
}
