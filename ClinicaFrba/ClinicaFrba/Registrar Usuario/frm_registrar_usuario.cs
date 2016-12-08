using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Usuario
{
    public partial class frm_registrar_usuario : Form
    {
        public frm_registrar_usuario()
        {
            InitializeComponent();
        }

        private void but_buscar_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.conectar();

            int codigo = Convert.ToInt32(tex_codigo.Text);

            //si es medico 
            if (rb_medico.Checked)
            {
                if (cn.verificarFaltaUsuarioEnMedico(codigo) )
                {
                    tex_usuario.Enabled = true;
                    tex_contraseña.Enabled = true;
                    
                }
                else
                {
                    MessageBox.Show("YA TIENE UN USUARIO");
                }
                
            }
            //si es paciente
            if (rb_paciente.Checked)
            {
                if (cn.verificarFaltaUsuarioEnPaciente(codigo))
                {
                    tex_usuario.Enabled = true;
                    tex_contraseña.Enabled = true;

                }
                else
                {
                    MessageBox.Show("YA TIENE UN USUARIO");
                }
               
            }
        }

        private void frm_registrar_usuario_Load(object sender, EventArgs e)
        {
            tex_contraseña.Enabled = false;
            tex_usuario.Enabled = false;
        }

        private void but_registrar_Click(object sender, EventArgs e)
        {
            
            String usuario = tex_usuario.Text;
            String contraseña = tex_contraseña.Text;
            int codigo = Convert.ToInt32(tex_codigo.Text);

            AppConfig ap = new AppConfig();
            DateTime fechaCreacion = Convert.ToDateTime( ap.obtenerFecha());


            Conexion cn = new Conexion();
            cn.conectar();

            if (rb_medico.Checked)
            {
                cn.completarUsuarioMedico(codigo,usuario,contraseña,fechaCreacion);
                MessageBox.Show("FINALIZADO CORRECTAMENTE");
                this.Close();
            }
            if (rb_paciente.Checked)
            {

                cn.completarUsuarioPaciente(codigo, usuario, contraseña, fechaCreacion);
                MessageBox.Show("FINALIZADO CORRECTAMENTE");
                this.Close();
            }

        }
    }
}
