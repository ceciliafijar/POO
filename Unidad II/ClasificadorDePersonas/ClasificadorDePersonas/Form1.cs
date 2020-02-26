using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasificadorDePersonas
{
    public partial class Consierto : Form
    {
        ClassAsistentes objAsistente = new ClassAsistentes();

        public Consierto()
        {
            InitializeComponent();
        }

        private void btnContabilizar_Click(object sender, EventArgs e)
        {
            objAsistente.tipo = cboPersonas.Text;
            objAsistente.Cantidad = int.Parse (cboCantidad.Text);
            objAsistente.Contar();
            MessageBox.Show("se contabilizo las personas que asistieron");
            cboCantidad.Text = ("");
            cboPersonas.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAdultosMayores_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            lblRespuestaBebe.Text = objAsistente.contarBebes.ToString();
            lblRespuestaNinos.Text = objAsistente.contarNinos.ToString();
            lblRespuestaAdultos.Text = objAsistente.contarAdultos.ToString();
            lblRespuestaAdultosM.Text = objAsistente.contarAdultosMayores.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Consierto_Load(object sender, EventArgs e)
        {

        }

        private void cboPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
