class Pessoa
{
    //Atributo nome:
    private string nome;
    
    //Get e Set
    public string Nome
    {
        //especificando as ações dos getters e setters
        get
        {
            return nome;
        }

        set
        {
            nome = value;
            //este valor é o que o usuário vai informar em outra classe
        }
    }
}