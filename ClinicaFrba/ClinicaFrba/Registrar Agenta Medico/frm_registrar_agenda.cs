using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class frm_registrar_agenda : Form
    {
        public frm_registrar_agenda()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_registrar_agenda_Load(object sender, EventArgs e)
        {
            gb_especialidad.Enabled = false;
            gb_horario.Enabled = false;


            Conexion conexion = new Conexion();
            conexion.conectar();

            //el dgv tendra check(0), codigo (1) y dia (2)
            dgv_dias.DataSource = conexion.traigoHorario();

            //oculata la columna "Codigo"
            this.dgv_dias.Columns["Codigo"].Visible = false;
        }

        private void but_dia_Click(object sender, EventArgs e)
        {
            //habilita la opcion de elegir la especialidad y los horarios, ademas si se elige el dia sabado
            //entonces se habilita el horario L-V y horario Sabado
            gb_especialidad.Enabled = true;

            Conexion conexion = new Conexion();
            conexion.conectar();

            dgv_especialidad.DataSource = conexion.especialidadesNombreCodigo();
            this.dgv_especialidad.Columns["Codigo"].Visible = false;

            gb_horario.Enabled = true;
            dtp_horas_s.Enabled = false;
            dtp_horas_lv.Enabled = false;

            for (int i = 0; i < dgv_dias.Rows.Count; i++)
            {

                if (Convert.ToBoolean(dgv_dias.Rows[i].Cells[0].Value) == true && (dgv_dias.Rows[i].Cells[2].Value.ToString() == "7") )
                {
                    dtp_horas_s.Enabled = true;
                }

                if (Convert.ToBoolean(dgv_dias.Rows[i].Cells[0].Value) == true && (dgv_dias.Rows[i].Cells[2].Value.ToString() != "7"))
                {
                    dtp_horas_lv.Enabled = true;
                }



            }


        }

        private void but_especialidad_Click(object sender, EventArgs e)
        {

        }
    }
}
