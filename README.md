# construtores.dio
[classe pessoa]
namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private string name;
        private string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public (string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é: {nome} {sobrenome}");
        }
    }
}
--------------------------------------------//
[programa ]

using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
           Pessoa p1 = new Pessoa("Thayana", "Villar");
           p1.Apresentar();
        }
    }
}
