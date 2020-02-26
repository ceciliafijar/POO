using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeEdad
{
    class ClassEdad
    {
        //Atributos
        public int anioNac, mesNac, diaNac, anioActuaL, mesActual, diaActual;
        public string MayordeEdad;
        
        //Metodo
        public void CalcularMayores()
        {
            {
                if (anioActuaL - anioNac > 18)
                {
                    MayordeEdad = "MAYOR DE EDAD";
                   
                }
                else
                {



                    if (mesActual == mesNac)

                    {
                    }
                    if (diaActual == diaNac)
                    {
                        MayordeEdad = "MAYOR DE EDAD";
                       
                    }
                    else
                    {
                        if (diaActual == diaNac)
                        {
                            MayordeEdad = "MAYOR DE EDAD";
                      

                        }
                    }
                    {

                    }
                }

            }
        }
    }
}