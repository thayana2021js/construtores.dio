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

