﻿using System;

public class Pessoa
{
    //Atributo
    private string nome = "Majuliana";
    
    //Constructor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}
