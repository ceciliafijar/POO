using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caseta
{
    class ClassVehiculo
    {
        //Atributos
        public int cantidadACobrar;
        public string TipoDeCarros;

        //Metodo
        public void CantidadACobrar()
        {
            switch (TipoDeCarros)
            {
                case "Motocicleta":
                    {
                        cantidadACobrar = 50;
                        break;
                    }
                case "Automovil":
                    {
                        cantidadACobrar = 112;
                        break;
                    }
                case "Autobus":
                    {
                        cantidadACobrar = 170;
                            break;
                           
                    }
                default:
                    {
                        cantidadACobrar = 250;
                        break;
                    }
            }
        }
    }
}
