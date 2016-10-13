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
    public partial class frm_modificar_eliminar_rol : Form
    {
       //codigo del rol que me servira luego para modificar el rol, esto no es visible para el usuario
       private int codigoRol;
       public void setCodigoRol(int valor)
       {
           this.codigoRol = valor;
       }

        public frm_modificar_eliminar_rol()
        {
            InitializeComponent();
             
        }

        private void frm_modificar_eliminar_rol_Load(object sender, EventArgs e)
        {
            
            /*
            1.- muestra los datos y la posibilidad de AGREGAR MAS FUNCIONALIDADES, BORRAR FUNCIONALIDADES
                GUARDAR CAMBIOS DE NOMBRE Y BORRAR EL ROL COMPLETO (el campo id no sera editable)
            2.- del listado de "funcionalidades del rol", se pueden elegir los q se desean
             *  borrar y dar en el boton BORRAR FUNCIONALIDAD
            3.- del listado de "funcionalidades del sistema", se pueden elegir los q se desean
             *  agregar al rol (controlando q no sea uno ya existente en dicho rol)
            4.- se puede cambiar el nombre y dar en GUARDAR CAMBIOS
            5.- por ultimo, si se quiere borrar el rol completo, se usa el boton 
             *  ELIMINAR ROL
             
            */
            this.setHabilitado("NO");
            this.setHabilitado("SI");
            Conexion conexion = new Conexion();
            conexion.conectar();
            dgv_funcionalidades_sistema.DataSource = conexion.funcionalidadesRestantes(codigoRol);
            dgv_funcionalidades_rol.DataSource = conexion.funcionalidadesTotalesPorRol(tex_Nombre.Text);
           

        }
        public void setNombre(String nombre)
        {
            tex_Nombre.Text = nombre;
        }

        public void setHabilitado(String valor)
        {
            cb_habilitado_si_no.Items.Add(valor);
        }
        public void inicializaHabilitado(String valor)
        {
            cb_habilitado_si_no.Text=valor ;
        }

        private void but_Eliminar_rol_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.conectar();
                
                conexion.borrarRol(tex_Nombre.Text);
                MessageBox.Show("Borrado exitosamente");

            }
            catch (Exception er)
            {
                MessageBox.Show("Ocurrio el error:" + er);
            } this.Close();
        }

        private void gro_Datos_rol_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but_guardar_cambios_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();
            //aqui usare el codigoRol

            //modifico el nombre y estado
            try
            {
                //paso el codigoRol (int), nombreNuevo y el estadoNuevo (string)
                conexion.modificarNombreEstado(codigoRol, tex_Nombre.Text , cb_habilitado_si_no.Text);
                

            }
            catch (Exception er1)
            {
                MessageBox.Show("error al tratar de cambiar nombre y codigo:" + er1);
            }

            //modifico las funcionalidades eliminadas
            try
            {
                for (int i = 0; i < dgv_funcionalidades_rol.Rows.Count; i++)
                {

                    if (Convert.ToBoolean(dgv_funcionalidades_rol.Rows[i].Cells[0].Value) == true)
                    {
                        //conexion.agregaFuncionalidadARol(tex_Descripcion.Text, dataGridView1.Rows[i].Cells[1].Value.ToString());
                        String funcionalidadAEliminar = dgv_funcionalidades_rol.Rows[i].Cells[1].Value.ToString();
                        conexion.modificarFuncionalidadActual(codigoRol, funcionalidadAEliminar);
                    }


                }
                
            }
            catch (Exception er2)
            {
                MessageBox.Show("error al tratar de modificar las funcionalidades eliminadas:" + er2);
            }

            //modifica las funcionalidades agregadas
            try
            {
                for (int i = 0; i < dgv_funcionalidades_sistema.Rows.Count; i++)
                {

                    if (Convert.ToBoolean(dgv_funcionalidades_sistema.Rows[i].Cells[0].Value) == true)
                    {
                        //conexion.agregaFuncionalidadARol(tex_Descripcion.Text, dataGridView1.Rows[i].Cells[1].Value.ToString());
                        String funcionalidadAAgregar = dgv_funcionalidades_sistema.Rows[i].Cells[1].Value.ToString();
                        conexion.agregoFuncionalidadActual(codigoRol, funcionalidadAAgregar);
                    }


                }





            }
            catch (Exception er3)
            {
                MessageBox.Show("error al tratar de modificar las funcionalidades agregadas:" + er3);
            }
            MessageBox.Show("Modificado!");
            this.Close();
        }

        private void dgv_funcionalidades_sistema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
