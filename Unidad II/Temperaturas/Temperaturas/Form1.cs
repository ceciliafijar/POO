using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperaturas
{
    
    public partial class lblGradosConvert : Form
    {
        ClassTemperatura objTemperatura = new ClassTemperatura();
        public lblGradosConvert()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            objTemperatura.unidades = cbmUnidades.Text;
            objTemperatura.grados = Convert.ToDouble(txtGrados.Text);
            objTemperatura.TransformarUnidad();

            lblGradosCon.Text = "Grados Convertidos: " + objTemperatura.grados.ToString() + "°";
        }

        private void lblGradosConver_Click(object sender, EventArgs e)
        {

        }
    }
}
