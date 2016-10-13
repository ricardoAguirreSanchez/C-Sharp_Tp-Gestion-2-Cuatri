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
    public partial class frm_agregar_rol : Form
    {
        public frm_agregar_rol()
        {
            InitializeComponent();
        }

       

        private void lab_Descripcion_Click(object sender, EventArgs e)
        {

        }

        private void frm_agregar_rol_Load(object sender, EventArgs e)
        {
            /*1.- Se agrega un id, y se verifica si ya existe (de ser asi se muestrar un error)
              2.- si no existe, te permite completar los datos
              3.- en el listbox estaran todas las funcionalidades q existen de las cuales se 
                  tendra q elegir las q se desean agregar para este nuevo rol
              4.- una ves completado todo y elegido las funcionalidades, se da en el boton agregar*/
            Conexion conexion = new Conexion();
            conexion.conectar();
            dataGridView1.DataSource = conexion.funcionalidadesTotales();
        }

        private void lab_codigo_rol_Click(object sender, EventArgs e)
        {

        }

        private void tex_Codigo_rol_TextChanged(object sender, EventArgs e)
        {

        }

        private void gro_Datos_rol_Enter(object sender, EventArgs e)
        {
            
        }

        private void but_Agregar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();
            if (conexion.buscarRolesPorNombreHabilitado(tex_Descripcion.Text))
            {
                MessageBox.Show("Ya existe un rol con ese nombre");
                tex_Descripcion.Clear();

            }
            else
            {
                 
                conexion.agregaRol(tex_Descripcion.Text);
                //recorro el dgv y voy insertando
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    
                    if (Convert.ToBoolean( dataGridView1.Rows[i].Cells[0].Value) == true)
                    {
                        conexion.agregaFuncionalidadARol(tex_Descripcion.Text,dataGridView1.Rows[i].Cells[1].Value.ToString());
                        
                    }
                    

                }



                MessageBox.Show("Agregado correctamente");
                this.Close();
            }
          

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
