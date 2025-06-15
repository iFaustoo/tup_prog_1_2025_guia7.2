using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, posicion = 0;
            int nMenor = int.MaxValue;

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Ingrese un número");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < nMenor)
                {
                    nMenor = n;
                    posicion = i;
                }
            }

            Console.WriteLine($"El menor número ingresado fue {nMenor}, encontrado en la posición {posicion}");

        }
    }
}
