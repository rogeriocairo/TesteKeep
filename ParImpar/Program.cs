using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Entre com um numero inteiro: ");
            var numero = int.Parse( Console.ReadLine());
            Console.WriteLine($"Invertido: {ParImpar(numero)}");
            Console.ReadLine();
        }

        private static string ParImpar(int numero)
        {
            return numero % 2 == 0 ? "Par" : "Impar";
        }        
    }
}
