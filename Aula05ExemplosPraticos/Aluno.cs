using System;
using System.Globalization;

class Aluno
{
    //Atributos
    public string nome;
    public double nota1, nota2;

    //Métodos
    public double media()
    {
        return (nota1 + nota2 / 2);
    }
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado!" : "reprovado";
    }
    public void mensagem()
    {
        //Obter a média
        double obterMedia = media();
        
        //Obter situacao
        string obterSituacao = situacao(obterMedia);
        
        //Mensagem
        Console.WriteLine($"{nome} está {obterSituacao} com média {obterMedia.ToString("F1", CultureInfo.InvariantCulture)}");
        
    }
}