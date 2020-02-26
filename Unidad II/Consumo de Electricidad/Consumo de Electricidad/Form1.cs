using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumo_de_Electricidad
{
    public partial class Form1 : Form
    {
        //Objeto de la clase
        ClassElecticidad objRecibo = new ClassElecticidad();
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
            objRecibo.Contrato = cmbContrato.Text;
            objRecibo.KW = Convert.ToDouble(txtKw.Text);
            objRecibo.CalcularConsumo();
            txtPagar.Text = objRecibo.ConsumoElectricidad.ToString();
        }
    }
}
