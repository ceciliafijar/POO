using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2y3
{
    class ClassVehiculo
    {
        //Atributos de la clase
        public string TipoDeCarros;
        public int CantidadACobrar;

        //Metodo de la clase
        public void CobrarCuota()
        {
            switch (TipoDeCarros)
            {
                case "Motocicleta":
                    {
                        CantidadACobrar = 50;
                        break;
                    }
                case "Automovil":
                    {
                        CantidadACobrar = 112;
                        break;
                    }
                case "Autobus":
                    {
                        CantidadACobrar = 170;
                        break;

                    }
                default:
                    {
                        CantidadACobrar = 250;
                        break;
                    }
            }
        }
    }
               

            

        
    
}
