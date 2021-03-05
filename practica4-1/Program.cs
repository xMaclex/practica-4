using System;

namespace practica4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numero = {0,0,0,0};
            int Resultado = 0;

            Console.WriteLine("Introduzca 4 numeros: ");
            numero [0] = int.Parse(Console.ReadLine());
            numero [1] = int.Parse(Console.ReadLine());
            numero [2] = int.Parse(Console.ReadLine());
            numero [3] = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero.Length; i++)
            {
                Resultado += numero[i];
            }
                double media = (double) Resultado / numero.Length;
                Console.WriteLine("RESULTADO: ");
                Console.WriteLine(numero[0] + media);
                Console.WriteLine(numero[1] + media);
                Console.WriteLine(numero[2] + media);
                Console.WriteLine(numero[3] + media);
                Console.WriteLine("pulse cualquier tecla para culminar");

        }
    }
}
