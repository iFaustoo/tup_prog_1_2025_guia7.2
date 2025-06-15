using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tenis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombre1, nombre2;
            int set1, set2, set3, puntos1, puntos2;
            int contador1 = 0, contador2 = 0;

            Console.WriteLine("Ingrese el nombre del primer jugador");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del segundo jugador");
            nombre2 = Console.ReadLine();

            Console.WriteLine($"Ingrese los puntos de {nombre1} del primer set");
            puntos1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ingrese los puntos de {nombre2} del primer set");
            puntos2 = Convert.ToInt32(Console.ReadLine());
            if (puntos1 > puntos2)
            {
                contador1 = contador1 + 1;
            }
            else
            {
                contador2 = contador2 + 1;
            }

            Console.WriteLine($"Ingrese los puntos de {nombre1} del segundo set");
            puntos1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ingrese los puntos de {nombre2} del segundo set");
            puntos2 = Convert.ToInt32(Console.ReadLine());
            if (puntos1 > puntos2)
            {
                contador1 = contador1 + 1;
            }
            else
            {
                contador2 = contador2 + 1;
            }

            Console.WriteLine($"Ingrese los puntos de {nombre1} del tercer set");
            puntos1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ingrese los puntos de {nombre2} del tercer set");
            puntos2 = Convert.ToInt32(Console.ReadLine());
            if (puntos1 > puntos2)
            {
                contador1 = contador1 + 1;
            }
            else
            {
                contador2 = contador2 + 1;
            }

            if (contador1 > contador2)
            {
                Console.WriteLine($"El ganador del partido de tenis al mejor de 3 sets fue {nombre1}");
                Console.WriteLine($"{nombre1} ganó un total de {contador1} sets y {nombre2} ganó un total de {contador2} sets");
            }
            else
            {
                Console.WriteLine($"El ganador del partido de tenis al mejor de 3 sets fue {nombre2}");
                Console.WriteLine($"{nombre1} ganó un total de {contador1} sets y {nombre2} ganó un total de {contador2} sets");

            }
        }
    }
}
