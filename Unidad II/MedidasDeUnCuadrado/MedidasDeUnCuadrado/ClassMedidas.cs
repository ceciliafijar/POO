using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidasDeUnCuadrado
{
    class ClassMedidas
    {
        //Atributos
       public int area, perimetro;
        public int lado;

        //Metodos
        public void CalculadorArea()
        {
            area = lado * lado;
        }

        public void CalculadorPerimetro()
        {
            perimetro = lado * 4;
        }
    }
    

}
