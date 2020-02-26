using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacaciones
{
    class ClassEmpleado
    {
        //Atributos
        public int vacaciones, aniosTra;
        //Metodo
        public void DeterminarVacaciones()
        {
            if (aniosTra < 6)
            {
                vacaciones = 5;
            }
            else if (aniosTra > 5 & aniosTra <= 10)
            {
                vacaciones = 10;
            }
            else if (aniosTra > 10 & aniosTra <= 20)
            {
                vacaciones = aniosTra;
            }
            else if (aniosTra > 20 & aniosTra < 33)

            {
                vacaciones = (aniosTra + 10) + 2;
            }
        }
    }
}
