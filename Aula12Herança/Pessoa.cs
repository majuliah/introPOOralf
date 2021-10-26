using System;

public class Pessoa
{
    //Atributos
    protected string nome;

    protected int idade;
    //própria classe e classes que herdam podem usar estes atributos

    protected void mensagemPessoa()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
    }
}
