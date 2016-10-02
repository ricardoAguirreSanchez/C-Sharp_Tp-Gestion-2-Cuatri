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
        }
    }
}
