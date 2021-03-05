using System;

namespace practica4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numero = {0,0,0,0,0};
            Console.WriteLine("Introduzca 5 numeros: ");
            numero[0] = int.Parse(Console.ReadLine());
            numero[1] = int.Parse(Console.ReadLine());
            numero[2] = int.Parse(Console.ReadLine());
            numero[3] = int.Parse(Console.ReadLine());
            numero[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("RESULTADO");

            Array.Reverse(numero);
            for (int i = 0; i <=4;i++)
            {
                Console.WriteLine(numero[i]);
            }
        }
    }
}
