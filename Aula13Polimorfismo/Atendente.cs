﻿using System;
public class Atendente : Imposto
{
    //Método
    public void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto atendente do vale alimentação é R$ {salario * 0.12}");
    }
}
