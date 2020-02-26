using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2y3
{
    public partial class Form1 : Form
    {
        ClassVehiculo objVehiculo = new ClassVehiculo();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            objVehiculo.TipoDeCarros = cmbVehiculo.Text;
            objVehiculo.CobrarCuota();
            lblCuota.Text = objVehiculo.CantidadACobrar.ToString();

        }
    }
}
