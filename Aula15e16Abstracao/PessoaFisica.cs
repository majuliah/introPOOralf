﻿using System;
    class PessoaFisica : Padrao
    {
        //Método obrigatório
        public override void taxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de empréstimo para pessoa física {valor * 0.1}");
        }
    }
