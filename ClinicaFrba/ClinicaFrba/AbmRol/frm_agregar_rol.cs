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

        private void but_Verificar_Click(object sender, EventArgs e)
        {

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
        }
    }
}
