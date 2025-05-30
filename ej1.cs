namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, promedio, promocion;

            Console.WriteLine("Ingrese la condicion de promocion");
            promocion = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese las 3 notas a evaluar");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());

            promedio = nota1 + nota2 + nota3 / 3;

            if (promedio >= promocion)
            {
                Console.WriteLine("Promociona");
            }
            else
            {
                Console.WriteLine("Rinde final");
            }
        }
    }
}