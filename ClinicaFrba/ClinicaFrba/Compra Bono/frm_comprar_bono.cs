using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Compra_Bono
{
    public partial class frm_comprar_bono : Form
    {
        public frm_comprar_bono()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_calcular_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();
            if (tex_numero_afiliado.Text == "")
            { MessageBox.Show("Ingresar numero de afiliado."); }
            else if(rbn_bono_consulta.Checked)
            {
                int precioBono = conexion.consultarPrecioBono(Convert.ToInt32(tex_numero_afiliado.Text));
                tex_total.Text = (precioBono * Convert.ToInt32(tex_cant_bono_consulta.Text)).ToString();
            }
            else if(rbn_bono_farmacia.Checked)
            {
                int precioBono = conexion.consultarPrecioFarmacia(Convert.ToInt32(tex_numero_afiliado.Text));
                tex_total.Text = (precioBono * Convert.ToInt32(tex_cant_bono_farmacia.Text)).ToString();
            }
        }

        private void rbn_bono_consulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn_bono_consulta.Checked) { tex_cant_bono_farmacia.Enabled = false; tex_cant_bono_consulta.Enabled = true; }
        }

        private void rbn_bono_farmacia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbn_bono_farmacia.Checked) { tex_cant_bono_farmacia.Enabled = true; tex_cant_bono_consulta.Enabled = false; }
        }

        private void but_comprar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            conexion.conectar();
            try
            {
                if (rbn_bono_consulta.Checked)
                {
                    int cantidadDeBonos = Convert.ToInt32(tex_cant_bono_consulta.Text);
                    for (int i = 1; i <= cantidadDeBonos; i++)
                    {
                        conexion.comprarBono(Convert.ToInt32(tex_numero_afiliado.Text));
                    }
                    MessageBox.Show(tex_cant_bono_consulta.Text + " bonos de consulta comprados!");
                }
                if (rbn_bono_farmacia.Checked) {
                    int cantidadDeBonos = Convert.ToInt32(tex_cant_bono_farmacia.Text);
                    for (int i = 1; i <= cantidadDeBonos; i++)
                    {
                        conexion.comprarBonoFarmacia(Convert.ToInt32(tex_numero_afiliado.Text));
                    }
                    MessageBox.Show(tex_cant_bono_farmacia.Text + " bonos de farmacia comprados!"); 
                }

                
            }
            catch (Exception error)
            {MessageBox.Show("No se pudo procesar la compra por: " + error.ToString());}
        }

        private void frm_comprar_bono_Load(object sender, EventArgs e)
        {
            tex_cant_bono_farmacia.Enabled = false;
            tex_total.Enabled = false;
        }
    }
}
