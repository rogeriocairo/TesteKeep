using System;
using System.Linq;

namespace Inversao
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "ABCDE";
            Console.WriteLine($"Normal   : {texto}");
            string textoInvertido = new string(texto.Reverse().ToArray());
            Console.WriteLine($"Invertido: {textoInvertido}");
            Console.ReadLine();
        }
    }
}
