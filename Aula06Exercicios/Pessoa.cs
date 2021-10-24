using System;

 class Pessoa
{
    public double peso, altura;
    
    public double imc()
    {
        return peso / (altura * altura);
    }

    public string situacao(double imc)
    {
        string retorno;

        if (imc < 18.5)
        {
            retorno = "Abaixo do Peso";
        }else if (imc < 25)
        {
            retorno = "Peso normal";
        }else if (imc < 30)
        {
            retorno = "Acima do peso";
        }else if (imc < 35)
        {
            retorno = "Obesidade I";
        }else if (imc < 40)
        {
            retorno = "Obesidade 2";
        }
        else
        {
            retorno = "Obesidade Mórbida";
        }

        return retorno;
        
    }

    public void mensagem()
    {
        double obterPeso = imc();
        string obterSituacao = situacao(obterPeso);

        Console.WriteLine($"Seu peso IMC é de {obterPeso} e sua situação é {obterSituacao}");
        
    }
}