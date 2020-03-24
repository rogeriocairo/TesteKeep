using System;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine($"Entre com o texto: ");
            var texto = Console.ReadLine();            
            Console.WriteLine($"Invertido: {Trocatexto(texto, "&")}");
            Console.ReadLine();
        }

        public static string Trocatexto(string texto, string troca)
        {
            var palavra = "";

            for (int i = 0; i < texto.Length; i++)
            {
                palavra += texto.Substring(i, 1).ToUpper() == "A" ? troca : texto.Substring(i, 1);
            }

            return palavra;
        }
    }
}
