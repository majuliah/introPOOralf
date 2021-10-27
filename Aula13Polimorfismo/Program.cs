using System;

namespace Aula13Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar Estagiário
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(400);
            Console.WriteLine("------------------------------");
            
            //Instanciar Gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTransporte(500);
            Console.WriteLine("-------------------------------");

            //Instanciar Atendente
            Imposto objetoH = new Atendente();
            objetoH.valeAlimentacao(3000);
            objetoH.valeTransporte(400);

        }
    }
}
