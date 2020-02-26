using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDePromedios
{
    public partial class Form1 : Form

    {
        Calificacion objcalificacion = new Calificacion();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            objcalificacion.calLeida = Convert.ToDecimal(txtCalificacion.Text);
            objcalificacion.contarAprobacion();
            objcalificacion.sumarCalificacion();
            MessageBox.Show("Calificacion Capturada");
            txtCalificacion.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtAprob.Text = objcalificacion.aprobados.ToString();
            txtReprob.Text = objcalificacion.reprobados.ToString();
            txtProm.Text = objcalificacion.calcularPromedio().ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
