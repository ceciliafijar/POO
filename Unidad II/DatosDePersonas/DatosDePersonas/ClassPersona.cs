using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDePersonas
{
    class ClassPersona
    {
        //Variables (Atributos)//
        private String Nombre;
        private String ApePaterno;
        private String ApeMaterno;
        private String Estado;
        private String Tipo;
        private int Telefono;
        private int Fecha;

        public int contadorEstado = 0;
        public int ContadorAlumnos = 0, ContadorDocente = 0, ContadorAdmon = 0, ContadorMayores = 0;
        public string MayordeEdad;

        //Metodo//
        public void RegistroPersona(String NombreM, String ApePaternoM, String ApeMaternoM, String EstadoM, String TipoM, int TelefonoM, int FechaM)
        {
            Nombre = NombreM;
            ApePaterno = ApePaternoM;
            ApeMaterno = ApeMaternoM;
            Estado = EstadoM;
            Tipo = TipoM;
            Telefono = TelefonoM;
            Fecha = FechaM;


        }

        public void Nayarit()
        {
            if (Estado == "Nayarit")
            {
                contadorEstado++;
            }
        }

        public void contarTipos()
        {

            switch (Tipo)
            {
                case "Alumno":
                    {
                        ContadorAlumnos++;
                        break;
                    }
                case "Docente":
                    {
                        ContadorDocente++;
                        break;
                    }
                default:
                    {
                        ContadorAdmon++;
                        break;
                    }
            }
        }

        public void mayorEdad(int anioNac, int mesNac, int diaNac, int anioActuaL, int mesActual, int diaActual)
        {
            if (anioActuaL - anioNac > 18)
            {
                MayordeEdad = "MAYOR DE EDAD";
                ContadorMayores++;
            }
            else
            {



                if (mesActual == mesNac)

                {
                }
                if (diaActual == diaNac)
                {
                    MayordeEdad = "MAYOR DE EDAD";
                    ContadorMayores++;
                }
                else
                {
                    if (diaActual == diaNac)
                    {
                        MayordeEdad = "MAYOR DE EDAD";
                        ContadorMayores++;

                    }
                }
                {

                }
            }


        }
    }
}
