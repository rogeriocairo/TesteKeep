using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 num;
            String entrada;

            Console.Write("Insira um numero inteiro para ser calculado seu fatorial: ");
            entrada = Console.ReadLine();
            num = Convert.ToInt32(entrada);

            Console.WriteLine("Fatorial de " + num + " é: " + Fatorial(num));
            Console.ReadLine();
        }

        public static Int32 Fatorial(Int32 num)
        {
            if (num == 1)
            {
                return 1;
            }
            
            return num * Fatorial(num - 1);
        }
    }
}
