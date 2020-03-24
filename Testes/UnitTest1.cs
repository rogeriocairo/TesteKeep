using Objetos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Objetos.Entidades.Enum;

namespace Testes
{
    public class UnitTest1
    {
        [Fact]
        public void Idade()
        {
            var pessoa = new Pessoa("Rogério", "M", DateTime.Parse("11/01/1968"), "Brasileira", EstadoCivilType.Casado);

            Assert.Equal(52, pessoa.Idade);           
        }

        [Fact]
        public void Solteiros()
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

            Assert.Equal(3, listaSolteiros.Count());          
        }

        [Fact]
        public void TrocaNome()
        {
            var lista = new List<Pessoa>
            {
                new Pessoa("Rogério", "M", DateTime.Parse("11/01/1968"), "Brasileira", EstadoCivilType.Casado),
                new Pessoa("Eduardo", "M", DateTime.Parse("13/01/2004"), "Brasileira", EstadoCivilType.Solteiro),
                new Pessoa("Lucas", "M", DateTime.Parse("13/12/1998"), "Brasileira", EstadoCivilType.Solteiro),
                new Pessoa("Cacau", "F", DateTime.Parse("13/09/2013"), "Brasileira", EstadoCivilType.Solteiro),
                new Pessoa("Paula", "F", DateTime.Parse("24/06/1975"), "Brasileira", EstadoCivilType.Casado)
            };

            lista.ElementAt(2).Nome = "João";
                        
            Assert.Equal("João", lista.ElementAt(2).Nome);
        }
    }
}
