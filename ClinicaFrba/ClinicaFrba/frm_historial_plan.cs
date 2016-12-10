using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba
{
    public partial class frm_historial_plan : Form
    {
        int id = 0;
        public frm_historial_plan()
        {
            InitializeComponent();
        }

        private void Historial_Plan_Load(object sender, EventArgs e)
        {   Conexion conexion = new Conexion();
            conexion.conectar();
            
            dataGridView1.DataSource =  conexion.historialPlanes(txtID.Text);
        }
    }
}
