using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_de_Electricidad
{
    class ClassElecticidad
    {
        //Atributos
        public double ConsumoElectricidad, KW;
        public string Contrato;

        //Metodo
        public void CalcularConsumo()
        {
            switch (Contrato)
            {
                case "Hogar":
                    {
                        if (KW > 0 & KW < 251)
                        {
                            ConsumoElectricidad = KW * 0.65;
                        }
                        else if (KW > 250 & KW <= 500)
                        {
                            ConsumoElectricidad = KW * 0.85;
                        }
                        else if (KW > 500 & KW <= 1200)
                        {
                            ConsumoElectricidad = KW * 1.5;
                        }
                        else if (KW > 1200 & KW >= 2100)
                        {
                            ConsumoElectricidad = KW * 2.5;
                        }
                        else
                        {
                            ConsumoElectricidad = KW * 3;
                        }

                        
                    }
                    break;

                case "Negocio":
                    {
                        ConsumoElectricidad = KW * 5;
                        break;
                    }
            }
        }
    }
}
