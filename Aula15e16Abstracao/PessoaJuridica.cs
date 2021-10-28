using System;
 class PessoaJuridica : Padrao
{
    //Método obrigatório
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine($"Taxa de empréstimo para pessoa jurídica {valor * 0.3}");
    }
}