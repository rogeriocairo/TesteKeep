using System;
using static Objetos.Entidades.Enum;

namespace Objetos.Entidades
{
    public class Pessoa : EntidadeBase
    {
        public Pessoa(string nome, string sexo, DateTime dataNascimento, string nacionalidade, EstadoCivilType estadoCivil)
        {
            Nome = nome;            
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Nacionalidade = nacionalidade;
            EstadoCivil = estadoCivil;
        }

        public string Nome { get; set; }

        public int Idade { get =>  (DateTime.Today.Year - DataNascimento.Year); }

        public string Sexo { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public string Nacionalidade { get; private set; }

        public EstadoCivilType EstadoCivil { get; private set; }
    }
}
