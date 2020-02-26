using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacaciones
{
    public partial class Form1 : Form
    {
        ClassEmpleado objEmpleado = new ClassEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objEmpleado.aniosTra = Convert.ToInt32(txtAnosLab.Text);
            objEmpleado.DeterminarVacaciones();
            lblVacaciones.Text = "Dias de vacaciones: " + objEmpleado.vacaciones.ToString();


        }
    }
}
