using System;

namespace prova1q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Entre com um número inteiro: ");

            var numero = int.Parse(Console.ReadLine());
            Quadro(numero);
        }

        public static void Quadro(int num)  // criacao da funcao   
        {          
            int coluna;
            int[,] bingo = new int[num, num];
            string palavra;

            for (int i = 0; i < num; i++)
            {
                coluna = i + 1;

                for (int z = 0; z < num; z++)
                {
                    bingo[i, z] = coluna;
                    coluna++;
                }
            }

            for (int i = 0; i < num; i++)
            {
                palavra = "";

                for (int z = 0; z < num; z++)
                {
                    palavra += bingo[i, z].ToString();
                }

                Console.WriteLine(palavra);
            }

            Console.ReadLine();
        }
    }
}
