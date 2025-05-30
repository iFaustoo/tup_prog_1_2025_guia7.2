namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5;
            int nMayor;

            Console.WriteLine("Ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            nMayor = n1;
            Console.WriteLine("Ingrese el segundo numero");
            n2= int.Parse(Console.ReadLine());

            if (n2 > n1)
            {
                nMayor = n2;
            }
            Console.WriteLine("Ingrese el tercer numero");
            n3 = int.Parse(Console.ReadLine());
            if (n3 > n2)
            {
                nMayor = n3;

            }
            Console.WriteLine("Ingrese el cuarto numero");
            n4 = int.Parse(Console.ReadLine());
            if (n4 > n2 && n4 > n3)
            {
                nMayor = n4;
            }
            Console.WriteLine("Ingrese el quinto numero");
            n5 = int.Parse(Console.ReadLine());
            if (n5 > n4 && n5 > n3 && n5 > n2)
            {
                nMayor = n5;
            }

            Console.WriteLine("El numero mayor ingresado fue: " + nMayor);
        }
    }
}
