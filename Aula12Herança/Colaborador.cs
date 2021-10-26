using System;

public class Colaborador : Pessoa
{
      //Atributo
      private double salario;

      //Contructor
      public Colaborador(string nome, int idade, double salario)
      {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            
            mensagemColaborador();
            mensagemPessoa();
      }
      
      
      //Método
      private void mensagemColaborador()
      {
            Console.WriteLine($"Salario {salario}");
            
      }
}
