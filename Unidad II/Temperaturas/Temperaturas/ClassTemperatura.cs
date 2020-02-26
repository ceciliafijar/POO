using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    class ClassTemperatura
    {
        //Atributos
        public double grados;
        public string unidades;

        //Metodos
        public void TransformarUnidad()
        {
            if (unidades == "Centigrados")
            {
                grados = (grados * 1.8000) + 32;
            }
            else
            {
                grados = (grados - 32) / 1.800;
            }
        }
    }
}
