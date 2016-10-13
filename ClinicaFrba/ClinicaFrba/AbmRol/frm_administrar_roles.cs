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
    public partial class frm_administrar_roles : Form
    {
        public frm_administrar_roles()
        {
            InitializeComponent();
        }

        private void but_Agregar_Click(object sender, EventArgs e)
        {
            frm_agregar_rol nuevoRol = new frm_agregar_rol();
            nuevoRol.Show();
        }

        private void but_Modificar_eliminar_rol_Click(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();
            conexion.conectar(); 

            frm_modificar_eliminar_rol modificaElimina = new frm_modificar_eliminar_rol();
            String nombreROl = dgv_Listado_roles.CurrentRow.Cells[0].Value.ToString();
            modificaElimina.setNombre(nombreROl);
            String codigoROL = dgv_Listado_roles.CurrentRow.Cells[1].Value.ToString();
            modificaElimina.setCodigoRol(Convert.ToInt32(codigoROL));
                 
            
          

            if (conexion.buscarRolesPorNombreHabilitado(nombreROl))
            {
                modificaElimina.inicializaHabilitado("SI");
            }
            else
            {
                modificaElimina.inicializaHabilitado("NO");
            }
            modificaElimina.Show();

        }

        private void frm_administrar_roles_Load(object sender, EventArgs e)
        {
            /*1.- se da en BUSCAR ROLES EXISTENTES
              2.- de la lista q se despliega, se puede elegir uno y modificarlo o eliminarlo
              3.- si no se elige ninguno, entonces puede agregar uno nuevo*/
            but_Agregar.Enabled = true;
            but_Modificar_eliminar_rol.Enabled = false;
        }

        private void but_Buscar_roles_existentes_Click(object sender, EventArgs e)
        {
            but_Agregar.Enabled = false;
            Conexion conexion = new Conexion();
            conexion.conectar();
            if (conexion.verificarRoles())
            {
                
                dgv_Listado_roles.DataSource = conexion.rolesTotal();
                but_Modificar_eliminar_rol.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay roles en el sistema");
               
            }
        }
    }
}
