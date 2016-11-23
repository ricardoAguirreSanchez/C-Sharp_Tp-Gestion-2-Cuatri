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
    public partial class frm_consultar_estadisticas : Form
    {
        public frm_consultar_estadisticas()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_consultar_estadisticas_Load(object sender, EventArgs e)
        {
            tex_cod_especialidad.Enabled = false;
            tex_cod_plan.Enabled = false;
        }

        private void tex_cod_especialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tex_cod_especialidad.Enabled = true;
            tex_cod_plan.Enabled = true; 
        }

        private void but_buscar_Click(object sender, EventArgs e)
        {
            int anioConsultado = Convert.ToInt32( tex_anio.Text);
            int semestreConsultado = Convert.ToInt32( tex_semestre.Text);

            Conexion cn = new Conexion();
            cn.conectar();

            if (rb_especialidades_mas_canceladas.Checked == true)
            {
                // dvg tendra: (0)codigo de especialidad
                dgv_listado_estadistico.DataSource = cn.especialidadesMasCanceladas(anioConsultado,semestreConsultado);
            }
            if (rb_profesionales_mas_consultados.Checked == true)
            {
                //dvg tendra: (0) codigo de profesional (1) codigo de plan y (2)codigo de  especialidad
                dgv_listado_estadistico.DataSource = cn.profesionalesMasConsultados(anioConsultado, semestreConsultado);
            }
            if (rb_especilidades_mas_bono_consulta_usados.Checked == true)
            {
                //dvg tendra: (0) codigo especialidad
                dgv_listado_estadistico.DataSource = cn.especialidadesMasBonosConsultaUsados(anioConsultado, semestreConsultado);
            
            }
            if (rb_afiliado_mayor_cantidad_bono_comprados.Checked == true)
            {
                //dvg tendra: (0) codigo de afiliado
                dgv_listado_estadistico.DataSource = cn.afiliadosMayorCantidadBonoComprado(anioConsultado, semestreConsultado);
            

            }
            if (rb_profesional_menos_horas_trabajadas.Checked == true)
            {
                int codigoEspecialidad = Convert.ToInt32(tex_cod_especialidad.Text);
                int codigoPlan = Convert.ToInt32(tex_cod_plan.Text);
                //dvg tendra: (0) codigo de profesional
                dgv_listado_estadistico.DataSource = cn.profesionalMenosHorasTrabajadas(anioConsultado, semestreConsultado,codigoPlan,codigoEspecialidad);
            

            }
        }
    }
}
