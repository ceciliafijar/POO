using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasificadorDePersonas
{
    class ClassAsistentes
    {
        //Atributos//
        public int Cantidad = 0;
        public String tipo;

        //Variables para metodos//
        public int contarBebes = 0, contarNinos = 0, contarAdultos = 0, contarAdultosMayores = 0;
        
        //Metodo//
       public void Contar()
        {
          switch (tipo)
            {
                case "Bebes":
                    {
                        contarBebes = contarBebes + Cantidad;
                        break;
                            
                    }
                case "Niños":
                    {
                        contarNinos = contarNinos + Cantidad;
                        break;

                    }
                case "Adultos":
                    {
                        contarAdultos = contarAdultos + Cantidad;
                        break;
                    }
                default :
                    {
                        contarAdultosMayores = contarAdultosMayores + Cantidad;
                        break;
                    }
            }
        } 
       
    }
}
