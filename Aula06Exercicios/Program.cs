using System;
using System.Reflection.PortableExecutable;

namespace Aula06Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa um = new Pessoa();
            um.peso = 80;
            um.altura = 1.80;
            um.mensagem();
        }
    }
}
