using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace año_bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int año;

            Console.WriteLine("Ingrese un año");
            año = Convert.ToInt32(Console.ReadLine());

            if (año % 4 == 0)
            {
                if (año % 100 == 100 || año % 400 == 0)
                {
                    Console.WriteLine("Es un año bisiesto");
                }
                else
                {
                    Console.WriteLine("No es un año bisiesto");
                }
            }
            else
            {
                Console.WriteLine("No es un año bisiesto");
            }
        }
    }
}
