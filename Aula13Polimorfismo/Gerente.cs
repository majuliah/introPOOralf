using System;
public class Gerente : Imposto
{
    //Método
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto gerente do vale alimentação é R$ {salario * 0.15}");
    }
    
    
}
