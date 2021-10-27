using System;

public class Imposto
{
    
    //Métodos
    public void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto padrão do valo alimentação é R$ {salario * 0.1}");
    }

    public void valeTransporte(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale transporte pe de R${salario * 0.06}");
    }
        
}

