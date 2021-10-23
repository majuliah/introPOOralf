using System;
using System.Globalization;

namespace Aula05ExemplosPraticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nome = "Maraju";
            aluno.nota1  = 9.2;
            aluno.nota2 = 8.3;
            aluno.mensagem();
        }
    }
}