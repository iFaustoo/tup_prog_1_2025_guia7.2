using System.ComponentModel.Design;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2, nombre3;
            double nota1, nota2, nota3;

            Console.WriteLine("Ingrese el nombre y la nota del primer parcial");
            nombre1 = Console.ReadLine();
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre y la nota del segundo parcial");
            nombre2 = Console.ReadLine();
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre y la nota del tercer parcial");
            nombre3 = Console.ReadLine();
            nota3 = double.Parse(Console.ReadLine());


            if (nota1 > nota2 && nota1 > nota3)
            {
                Console.WriteLine(nombre1 + " " + nota1);
                if (nota2 > nota3)
                {
                    Console.WriteLine(nombre2 + " " + nota2);
                    Console.WriteLine(nombre3 + " " + nota3);
                }
                else
                {
                    Console.WriteLine(nombre3 + " " + nota3);
                    Console.WriteLine(nombre2 + " " + nota2);
                }
            }
            else if (nota2 > nota1 && nota2 > nota3)
            {
                Console.WriteLine(nombre2 + " " + nota2);
                if (nota1 > nota3)
                {
                    Console.WriteLine(nombre1 + " " + nota1);
                    Console.WriteLine(nombre3 + " " + nota3);
                }
                else
                {
                    Console.WriteLine(nombre3 + " " + nota3);
                    Console.WriteLine(nombre1 + " " + nota1);
                }
            }
            else if (nota3 > nota1 && nota3 > nota2)
            {
                Console.WriteLine(nombre3 + " " + nota3);
                if (nota1 > nota2)
                {
                    Console.WriteLine(nombre1 + " " + nota1);
                    Console.WriteLine(nombre2 + " " + nota2);
                }
                else
                {
                    Console.WriteLine(nombre2 + " " + nota2);
                    Console.WriteLine(nombre1 + " " + nota1);
                }
            }
            

        }
    }
}
