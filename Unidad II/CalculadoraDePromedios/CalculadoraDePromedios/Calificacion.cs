using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDePromedios
{
    public class Calificacion
    {
        //Atributos de la clase 
        public decimal calLeida = 0, promedioGrupal, sumaCalif;
        public int aprobados = 0;
        public int reprobados = 0;

        //Metodos de la clase
        public void contarAprobacion()

        {
            if (calLeida < 70)
                reprobados++;
            else
                aprobados++;

        }
        public void sumarCalificacion()
        {
            sumaCalif += calLeida;
        }
        public decimal calcularPromedio()
        {
            promedioGrupal = sumaCalif / (aprobados + reprobados);
            return promedioGrupal;
        }
            
      
    }
}
