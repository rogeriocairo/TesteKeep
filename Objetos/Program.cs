using Objetos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using static Objetos.Entidades.Enum;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Pessoa>
            {
                new Pessoa("Rogério", "M", DateTime.Parse("11/01/1968"), "Brasileira", EstadoCivilType.Casado),
                new Pessoa("Eduardo", "M", DateTime.Parse("13/01/2004"), "Brasileira", EstadoCivilType.Solteiro),
                new Pessoa("Lucas", "M", DateTime.Parse("13/12/1998"), "Brasileira", EstadoCivilType.Solteiro),
                new Pessoa("Cacau", "F", DateTime.Parse("13/09/2013"), "Brasileira", EstadoCivilType.Solteiro),
                new Pessoa("Paula", "F", DateTime.Parse("24/06/1975"), "Brasileira", EstadoCivilType.Casado)
            };

            var listaSolteiros = lista.Where(z => z.EstadoCivil.Equals(EstadoCivilType.Solteiro));

            lista.ElementAt(1).Nome = "João";

            var validacao = lista.Where(x => x.Idade >= 18).Count() > 0 ? "Sucesso" : "NOK";

            Console.WriteLine($"Invertido: {validacao}");
            Console.WriteLine($"Elementos: {lista.Count()}");
            Console.ReadLine();
            //Resposta 11.6
            //lista.RemoveAt(posicao);

            //11.7
            lista.Insert(1, new Pessoa("Ana", "F", DateTime.Parse("13/01/1950"), "Brasileira", EstadoCivilType.Casado));
            lista.Insert(3, new Pessoa("Ana", "F", DateTime.Parse("13/01/1950"), "Brasileira", EstadoCivilType.Casado));
        }
    }
}
