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
            /*1.- habilita la opcion de elegir la especialidad y los horarios,
              2.- ademas si se elige el dia sabado, entonces se habilita el horario L-V y horario Sabado
              3.- le muestran las especialidades que tiene a cargo el medico
           */ 
            gb_especialidad.Enabled = true;

            Conexion conexion = new Conexion();
            conexion.conectar();

            int codigoMedico = Convert.ToInt32(tex_codigo_medico.Text);
            //llena el dvg con codigo de especialidad y nombre de especialidad
            dgv_especialidad.DataSource = conexion.especialidadPorCodigoMedico(codigoMedico);
            this.dgv_especialidad.Columns["Codigo"].Visible = false;

            gb_horario.Enabled = true;
            dtp_horas_s_desde.Enabled = false;
            dtp_horas_s_hasta.Enabled = false;
            dtp_horas_lv_desde.Enabled = false;
            dtp_horas_lv_hasta.Enabled = false;

            for (int i = 0; i < dgv_dias.Rows.Count; i++)
            {

                if (Convert.ToBoolean(dgv_dias.Rows[i].Cells[0].Value) == true && (dgv_dias.Rows[i].Cells[2].Value.ToString() == "7") )
                {
                    dtp_horas_s_desde.Enabled = true;
                    dtp_horas_s_hasta.Enabled = true;
                }

                if (Convert.ToBoolean(dgv_dias.Rows[i].Cells[0].Value) == true && (dgv_dias.Rows[i].Cells[2].Value.ToString() != "7"))
                {
                    dtp_horas_lv_desde.Enabled = true;
                    dtp_horas_lv_hasta.Enabled = true;
                }



            }


        }

        private void but_especialidad_Click(object sender, EventArgs e)
        {

        }

        private void but_guardar_Click(object sender, EventArgs e)
        {
           // String dia = dtp_fecha_desde.Value.DayOfWeek
           /*1.- Recorre los dias elegidos del dvg
             2.- toma el codigo del medico y la especialidad
             3.- por cada dia elegido empieza a consultar si coinciden los Dias de la semana dentro del
                 rango de fecha elegido
             3.1.- si no coincide con ningun dia dentro del rango de fecha, no guarda nada
             4.- si coinicide, usa los rango de los horarios para separarlos cada 30 min
                 y va haciendo INSERT cada 30 min hasta cumplir el tope de rango de horario*/

            Conexion conexion = new Conexion();
            conexion.conectar();


            for (int i = 0; i < dgv_dias.Rows.Count; i++)
            {
                //consulta si fue elegido ese dia
                if (Convert.ToBoolean(dgv_dias.Rows[i].Cells[0].Value) == true)
                {
                    DateTime auxiliarFecha = dtp_fecha_desde.Value;
                    DateTime fechaTope = dtp_fecha_hasta.Value.AddDays(1);
                    

                    
                    while (auxiliarFecha.Date != fechaTope.Date  )
                    {
                        DateTime auxliarHoraLunVier = dtp_horas_lv_desde.Value;
                        DateTime auxliarHoraSabado = dtp_horas_s_desde.Value;
                        //consulta si el dia elegido es igual a algun dia dentro de la fecha
                        if ((int)auxiliarFecha.DayOfWeek == Convert.ToInt32(dgv_dias.Rows[i].Cells[2].Value.ToString()) - 1)
                        { 
                            //ES DIA SABADO
                            if (((int)auxiliarFecha.DayOfWeek == 6) && (dtp_horas_s_desde.Value.Hour >= 10) && (dtp_horas_s_hasta.Value.Hour <= 15))
                            {
                                //empezamos a insertar por cada tramo de 30 min

                                while (auxliarHoraSabado.Hour != dtp_horas_s_hasta.Value.Hour)
                                {
                                    int codigoMedico = Convert.ToInt32(tex_codigo_medico.Text);
                                    int codigoEspecialidad = Convert.ToInt32(dgv_especialidad.CurrentRow.Cells[0].Value.ToString());
                                    DateTime fechafinal = new DateTime(auxiliarFecha.Year, auxiliarFecha.Month, auxiliarFecha.Day, auxliarHoraSabado.Hour, auxliarHoraSabado.Minute, auxliarHoraSabado.Second);

                                    //MessageBox.Show("parametros:" + codigoMedico + codigoEspecialidad + "'" + fechafinal + "'");
                                    conexion.insertarAgendaMedico(codigoMedico,codigoEspecialidad,fechafinal);

                                    //agrego 30 min
                                    auxliarHoraSabado = auxliarHoraSabado.AddMinutes(30);
                                }

                            }
                            //ES DIA LUN - VIER
                            if (((int)auxiliarFecha.DayOfWeek != 6) && (dtp_horas_lv_desde.Value.Hour >= 7) && (dtp_horas_lv_hasta.Value.Hour <= 20))
                            {
                                //empezamos a insertar por cada tramo de 30 min
                                while (auxliarHoraLunVier.Hour != dtp_horas_lv_hasta.Value.Hour)
                                {
                                    int codigoMedico = Convert.ToInt32(tex_codigo_medico.Text);
                                    int codigoEspecialidad = Convert.ToInt32(dgv_especialidad.CurrentRow.Cells[0].Value.ToString());
                                    DateTime fechafinal = new DateTime(auxiliarFecha.Year, auxiliarFecha.Month, auxiliarFecha.Day, auxliarHoraLunVier.Hour, auxliarHoraLunVier.Minute, auxliarHoraLunVier.Second);

                                    //MessageBox.Show("parametros:" + codigoMedico + codigoEspecialidad + "'" + fechafinal + "'");
                                    conexion.insertarAgendaMedico(codigoMedico, codigoEspecialidad, fechafinal);

                                    //agrego 30 min
                                    auxliarHoraLunVier = auxliarHoraLunVier.AddMinutes(30);
                                }
                            }
                        }
    
                           
                        //agrega un dia mas
                        auxiliarFecha = auxiliarFecha.AddDays(1);
                    }
                }

             

            }
            MessageBox.Show("FINALZADO CORRECTAMENTE");
            this.Close();
        }
    }
}
