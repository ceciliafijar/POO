using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosDePersonas
{
    public partial class Form1 : Form
    {
        ClassPersona objPersona = new ClassPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            //objPersona.RegistroPersona(dtpFecha.Value.Year, dtpFecha.Value.Month, dtpFecha.Value.Day);
            
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
