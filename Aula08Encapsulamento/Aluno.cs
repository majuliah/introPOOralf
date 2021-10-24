using System;

namespace Aula08Encapsulamento
{
    class Aluno
    {
        private double nota1, nota2;
        
        //Media
        private double media()
        {
            return (nota1 + nota2) / 2;
        }

        public void mensagem()
        {
            Console.WriteLine($"Informe a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe a primeira nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"A média é {media()}");
        }
        
    }
}