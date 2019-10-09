using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidos_de_unidades
{
    class Principal
    {
        //instaciamos 
        Valores V = new Valores();
        public void capturardatos()
        {
            //declaramos las variables locales que se usaran
           
            double Metro;
            double pulgadas;
            double Ml;
            
            int op;
            //creamos el menu
            Console.WriteLine("Menu");
            Console.WriteLine("1.cm a metros");
            Console.WriteLine("2.M a  pulgadas");
            Console.WriteLine("3.L a  ml");
            
            
            //capturamos la opcion
            Console.WriteLine("Dame opcion");
            op = Convert.ToInt32(Console.ReadLine());    
    
            //creamos el switch con las opciones que se usaran
            switch (op)
            {
                case 1: 
                    //realizamos el ingreso de datos y usamos el out
                     Console.WriteLine("ingese Cm: ");
            V.Dato1 = Convert.ToDouble(Console.ReadLine());
            convertir1(V.Dato1, out Metro);
                    //mostramos los resultados 
            Console.WriteLine("los centimetros convertidos a Metros son: " + Metro);
                    
                    break;
                case 2:
                     Console.WriteLine("ingese M: ");
            V.Dato2 = Convert.ToDouble(Console.ReadLine());
            convertir2(V.Dato2, out pulgadas);

            
            Console.WriteLine("los metros convertidos a pulgadas son: " + pulgadas);
                    break;
                case 3:
                    Console.WriteLine("ingese L: ");
            V.Dato3 = Convert.ToDouble(Console.ReadLine());
            convertir3(V.Dato3, out Ml);
            
            Console.WriteLine("los litros convertidos a militros son: " + Ml);
                 break;

         


            }

            

            
            
            
            
            Console.ReadKey();

        }

        //usamos el out para realizar las operaciones y mostrar los resultados
        public void convertir3( double Dato3, out double Ml)
        {
           
           
            Ml = V.Dato3 * 1000;


        }

        public void convertir1(double Dato1, out double Metro)
        {
            Metro = V.Dato1 / 100;
        }

       
        public void convertir2(double Dato2, out double pulgadas)
        {
            pulgadas = V.Dato2 * (100 / 2.54);
        }


    }
}
