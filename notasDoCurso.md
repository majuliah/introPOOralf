# Hi there! 👻

## Aqui é um espaço reservado para colocar as anotações sobre o curso do Ralf de introdução à Orientação a Objetos. O curso pode ser encontrado através deste [link](https://youtube.com/playlist?list=PLWXw8Gu52TRKlAqSfkdhSTPtAfAcYko5E)

![](https://media2.giphy.com/media/5jYt43Rzz83SeKR4oU/giphy.gif?cid=790b7611989eed76045fab8f87de7f194f5d0b1f06c52601&rid=giphy.gif&ct=g)



## <u>Aula 03🐱‍🏍:</u>

#### Vamos começar por entender a estrutura de código inicial do C#:

![](https://github.com/majuliah/introPOOralf/blob/main/img/print1.png?raw=true)

#### Na primeira linha temos o ***using System***. O *using* é para quando queremos importar alguma **funcionalidade**. A System é uma biblioteca padrão onde podemos exibir ou armazenar dados através do *console.* 

#### Na segunda, temos o *namespace*. *Namespace* é o lugar, a pasta, o diretório , o local onde temos o projeto. Podemos ter arquivos de mesmo nome em diferentes *namespaces*. A terceira linha temos a *class*, onde veremos daqui a pouco a funcionalidade dela.

#### Agora a quarta linha, onde temos o ***static void Main***, e cada *namespace* tem que haver pelo menos uma desta. O arquivo que tem o ***static void main*** é o arquivo principal e só deveremos ter um.

#### A ***Console.WriteLine*** é para escrevermos algo no console. 

### CLASSE, ATRIBUTO, MÉTODO E OBJETO🐣:

#### As classes são moldes e possuem atributos que são as caracteristicas que a classe pode ter;  Os métodos são funções, ações. É o que a classe faz. Para criar um objeto: nós instanciamos uma classe, instanciar significa criar e criaremos um objeto através de um molde (ou seja, da classe.) Depois de instanciar um objeto, podemos acessar os atributos da classe.  Portanto:

- **Classe: molde**
- **Atributos: características que o objeto pode ter**
- **Métodos: são as ações**
- **Objeto: onde estipulamos as características únicas de uma classe**
- ***Void* é quando a expressão ou função não espera receber um valor.**

![](https://github.com/majuliah/introPOOralf/blob/main/img/print2.png?raw=true)

## <u>Aula 04🐱‍🏍:</u>

#### **Métodos:** Podemos ter vários métodos com mesmo nome em uma classe, contato que eles tenham parâmetros diferentes.

​									 ![](https://github.com/majuliah/introPOOralf/blob/main/img/print3.png?raw=true)

#### Aqui temos 3 métodos com mesmo nome, mas com atributos diferentes. O primeiro não tem nenhum parâmetro. O segundo possui somente nome. E o terceiro já possui a idade. Sendo assim, não há erros porque possuem diferentes, sendo assim, só devemos passar os parâmetros na hora de instanciar a classe (criar o objeto):

####  ![](https://github.com/majuliah/introPOOralf/blob/main/img/print4.png?raw=true)



## <u>Aula 05🐱‍🏍:</u>

#### As classes começam com letra maiúscula e devemos nos atentar a ela haver o mesmo nome do projeto, deste jeito: 

![](https://github.com/majuliah/introPOOralf/blob/main/img/print5.png?raw=true)

####  Na primeira linha estamos criando a classe aluno. Cada aluno terá atributos como nome e nota1, nota2. Os métodos com public permitem acesso para outras classes. Na segunda, temos a criação dos métodos, também públicos para serem acessados  por outras classes. Temos 3 métodos, sendo eles:

- #### Média: ele calcula a média do aluno após fornecermos as variáveis;

- #### Situação: Ele recebe os parâmetros da média para retornarem um determinado resultado, no caso "aprovado" ou "reprovado". Estamos usando um operador ternário. Média é maior ou igual a 7 ? (sim) retorna "aprovado" : (não) retorna "reprovado".                                                                                                                                                                      return media >= 7 ? "aprovado " : "reprovado" 

- #### Mensagem: Vai ser void porque não queremos armazená-la em alguma variável e não a queremos de parâmetro para algum outro método, como aconteceu no caso da média sendo passada dentro da situação! Portanto só iremos reutilizar os recursos que já temos de outros métodos para imprimir as mensagens. 

  

![](https://github.com/majuliah/introPOOralf/blob/main/img/print6.png?raw=true)

#### Já aqui instanciamos a classe, criando o objeto e depois temos acesso as propriedades dele para passarmos as informações e termos os resultados no console. 



## <u>Aula 06🐱‍🏍:</u>































































 

