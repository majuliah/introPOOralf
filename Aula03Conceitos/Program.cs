using System;
namespace Aula03Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 03 conceitos");

            Pessoa obj = new Pessoa();
            //estamos criando uma pessoa, um objeto!
            obj.nome = "Majulia";
            obj.idade = 21;
            obj.mensagem();
            
        }
    }
}