using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{
    public partial class frm_registro_resultado : Form
    {
        public frm_registro_resultado()
        {
            InitializeComponent();
        }

        private void rb_no_CheckedChanged(object sender, EventArgs e)
        {
            tex_sintomas.Enabled = false;
            tex_diagnostico.Enabled = false;
        }

        private void frm_registro_resultado_Load(object sender, EventArgs e)
        {
            tex_sintomas.Enabled = false;
            tex_diagnostico.Enabled = false;
        }

        private void rb_si_CheckedChanged(object sender, EventArgs e)
        {
            tex_sintomas.Enabled = true;
            tex_diagnostico.Enabled = true;
        }

        private void but_registrar_Click(object sender, EventArgs e)
        {
            /*
             1.- Completa los cambos faltantes en la consulta
             2.- cambia el estado del turno correspondiente (lo deja en FINALIZADO)
             */

            //abro conexion
            Conexion cn = new Conexion();
            cn.conectar();
            
            /*pregunto si en verdad de realizo, si no se realizo, entonces dejara la consulta con los 
             * campos faltantes en null y el turno quedara como FINALIZADO PARCIALMENTE ya q solo se
             * registro la llegada)*/

            if (rb_si.Checked)
            {
                //traigo el codigo de la consulta, los sintomas y diagnosticos
                int codigoConsulta = Convert.ToInt32(dgv_listado_consultas.CurrentRow.Cells[0].Value.ToString());
                String sintomas = tex_sintomas.Text;
                String diagnostico = tex_diagnostico.Text;


                //obtengo de la fecha del sistema
                AppConfig ac = new AppConfig();
                DateTime fechaSistema = Convert.ToDateTime(ac.obtenerFecha());

                
                //esto cambia de estado el turno
                cn.cambioEstadoTurnoPorUnaConsultaFinalizada(codigoConsulta);

                MessageBox.Show("Registrado Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se registra cambios");
                this.Close();
            }

            

        }

        private void but_buscar_consultas_Click(object sender, EventArgs e)
        {
            //Busca las consultas pendientes para ese dia en base al codigo del medico
            
            //abro la conexion
            Conexion cn1 = new Conexion();
            cn1.conectar();

            //uso el codigo del medico
            int codigoMedico =Convert.ToInt32(tex_codigo_medico.Text);

            //obtengo de la fecha del sistema, luego el dia,mes y anio para filtrar los turnos
            AppConfig ac = new AppConfig();
            String fecha = ac.obtenerFecha();
            DateTime dt = Convert.ToDateTime(fecha);
            int dia = dt.Day;
            int mes = dt.Month;
            int anio = dt.Year;

            //muestro  numero, fecha, afiliado y medico de consulta, 
            dgv_listado_consultas.DataSource = cn1.buscarConsultasPorID(codigoMedico,dia,mes,anio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abro conexion
            Conexion cn1 = new Conexion();
            cn1.conectar();

            //traigo el codigo de la consulta, los sintomas y diagnosticos
            int codigoConsulta = Convert.ToInt32(dgv_listado_consultas.CurrentRow.Cells[0].Value.ToString());
            String sintomas = tex_sintomas.Text;
            String diagnostico = tex_diagnostico.Text;


            //obtengo de la fecha del sistema
            AppConfig ac = new AppConfig();
            DateTime fechaSistema = Convert.ToDateTime(ac.obtenerFecha());
            //esto completa lo q faltaba en consulta
            cn1.completarCamposEnConsultaPorRegistroResultado(codigoConsulta, sintomas, diagnostico, fechaSistema);
            MessageBox.Show("Diagnostico y sintoma guardado");
            tex_diagnostico.Clear();
            tex_sintomas.Clear();
        }
    }
}
