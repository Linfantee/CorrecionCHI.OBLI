using CorrecionCHI.OBLI.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecionCHI.OBLI.Servicios
{
    /// <summary>
    /// Implementación donde se encuentra el método donde se preguntan los números y los bucles for.
    /// <author>CHI - 31/01/24</author>
    /// </summary>
    internal class MensajeImplementacion : MensajeInterfaz
    {
        public float resultado()
        {
            //Esta bien pero no aclara que se deban usar números enteros.
            Console.WriteLine("Dame un número");
            float num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el número por el que se multiplicará");
            float num2 = Convert.ToInt32(Console.ReadLine());

            float sum = num1 * num2;
            Console.WriteLine(sum);

            Console.WriteLine("Dame le número por el que se dividirá");
            float num3 = Convert.ToInt32(Console.ReadLine());

            float divi = sum / num3;
            Console.WriteLine(divi);

            Console.WriteLine("-------------------------");

            //Esta bien pero se podría hacer de una manera mucho mas corta y y asi evitar cualquier error
            /* string aux = "";
            int resultado = Convert.ToInt32(division);

            for (int i = resultado; i >= 1; i--)
            {
            aux = aux + i;
            Console.WriteLine(aux);
             }
             return division;
             */
            //Seria algo asi y asi evitas hacer un bucle innecesario



                for (float i = divi; i >= 1; i--)
                {
                    for (float j = 1; j <= i; j++)
                    {
                       Console.WriteLine("" + j);

                    }
                         Console.WriteLine("");

                    Console.WriteLine("------------");
                }


                    return divi;
        }


    }
}
