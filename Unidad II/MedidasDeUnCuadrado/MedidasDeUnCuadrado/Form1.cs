using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedidasDeUnCuadrado
{
    public partial class Form1 : Form

    {
        ClassMedidas objCuadrado = new ClassMedidas();
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
            if (txtMedidas.Text == "")
            {
                errorProvider1.SetError(txtMedidas, "Debe intruducir medida");
                txtMedidas.Focus();
                return;
            }

            objCuadrado.lado = int.Parse(txtMedidas.Text);
            objCuadrado.CalculadorArea();
            objCuadrado.CalculadorPerimetro();
            lblArea.Text = "Area: " + objCuadrado.area.ToString();
            lblPerimetro.Text = "Perimetro: " + objCuadrado.perimetro.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
