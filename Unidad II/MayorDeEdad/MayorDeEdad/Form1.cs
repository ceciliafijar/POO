using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorDeEdad
{
    public partial class Form1 : Form
    {
        ClassEdad objEdad = new ClassEdad();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            objEdad.anioNac = Convert.ToInt32(dtpMayorDeEdad.Value.Year.ToString());
            objEdad.mesNac = Convert.ToInt32(dtpMayorDeEdad.Value.Month.ToString());
            objEdad.diaNac = Convert.ToInt32(dtpMayorDeEdad.Value.Day.ToString());
            objEdad.anioActuaL = Convert.ToInt32(DateTime.Today.Year.ToString());
            objEdad.mesActual = Convert.ToInt32(DateTime.Today.Month.ToString());
            objEdad.diaActual = Convert.ToInt32(DateTime.Today.Day.ToString());
            objEdad.CalcularMayores();
            lblMayorDeEdad.Text = objEdad.MayordeEdad;
            objEdad.MayordeEdad = "";

        }

        private void dtpMayorDeEdad_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
