//LISTAS

//criando uma lista
//exemplo 1 - versao mais antiga utilizada
using Microsoft.VisualBasic;
using POO_CSharp;



List<string> listaNomes = new List<string>();

//exemplo 2 - versao mais nova utilizada
List<string> listaNomes2 = new();

//Adicionando nomes na lista
listaNomes.Add("Marcos");
listaNomes.Add("Beatriz");

//imprimir nomes da lista
foreach (var item in listaNomes)
{
    Console.WriteLine(item);
}

listaNomes.Remove("Joao");

//POO - Programacao orientada a objeto
//Objetivo da POO --> Aproximar a programacao do mundo real
//Objetivo da POO --> Separar nossos Sistemas em partes menores

//Quando o tema e POO envolve Classes e Objetos

//Classe --> E uma denificao (item da vida real, representado por codigo), toda classe pode ter 2 coisas (atributos e metodos)
//Atributos sao caracteristicas
//Metodos sao acoes

//Exemplo de como criar uma classe

//Objeto --> Instancia de uma classe

//Exemplo de instanciar a classe Carro

Carro carro = new Carro();
//Para acessar informacoes do objeto, usar o ponto(.)
//carro.modelo = "Civic";
carro.anoFrabricacao = 2012;
carro.marca = "Honda";

carro.Andar();
carro.MostrarInformacoes();
carro.Parar();

Console.WriteLine("");

Carro carro2 = new Carro();
//Para acessar informacoes do objeto, usar o ponto(.)
//carro2.modelo = "Volkswagem";
carro2.anoFrabricacao = 1998;
carro2.marca = "Gol";

carro2.Andar();
carro2.MostrarInformacoes();
carro2.Parar();


Console.WriteLine("");

Carro carro3 = new Carro();
//Para acessar informacoes do objeto, usar o ponto(.)
//carro3._modelo = "Uno";
carro3.anoFrabricacao = 2015;
carro3.marca = "Fiat";
carro3.SetModelo("HONDA");

carro3.Andar();
carro3.MostrarInformacoes();
carro3.Parar();

Livro livros = new Livro();

Console.Write("Digite o autor: ");
livros.autor = Console.ReadLine();
Console.Write("Digite o titulo: ");
livros.titulo = Console.ReadLine();
Console.Write("Digite qtda paginas: ");
livros.paginas = Console.ReadLine();

livros.MostrarInformacoes();

//Atribuir valores aos atributos de outra forma mais simples, depois dos atributos colocar virgula (,)

Livro livros1 = new Livro()
{
    autor = "Robert",
    titulo = "Clean code",
    paginas = "341",

    //autor = Console.ReadLine();
    //titulo = Console.ReadLine();
    //paginas = Console.ReadLine();
};


livros1.MostrarInformacoes();

Aluno aluno1 = new Aluno();

aluno1.nome = "Marcos";
aluno1.idade = 18;
aluno1.notaFinal = 7.5;

aluno1.MostrarNota();

Aluno aluno2 = new Aluno();

aluno2.nome = "Beatriz";
aluno2.idade = 25;
aluno2.notaFinal = 9.5;

aluno2.MostrarNota();

Produtos produtos1 = new Produtos();

produtos1.nome = "Caneta";
produtos1.preco = 1.5;
produtos1.quantidadeEmEstoque = 250;

Console.WriteLine(produtos1.nome);
Console.WriteLine(produtos1.preco);
Console.WriteLine(produtos1.quantidadeEmEstoque);

produtos1.nome = "Caneta";
produtos1.preco = 1.8;
produtos1.quantidadeEmEstoque = 250;
Console.WriteLine(produtos1.nome);
Console.WriteLine(produtos1.preco);
Console.WriteLine(produtos1.quantidadeEmEstoque);

Console.WriteLine(produtos1.CalcularTotal());


ContaBancaria mov = new ContaBancaria();
Console.Write("Informe o deposito: ");
double dep = double.Parse(Console.ReadLine());
mov.Depositar(dep);
Console.Write("Informe o valor de saque: ");
double sac = double.Parse(Console.ReadLine());
mov.Sacar(sac);
Console.Write("Informe o valor de saque: ");
sac = double.Parse(Console.ReadLine());
mov.Sacar(sac);
mov.VerSaldo();

Funcionario funcionario = new Funcionario();
funcionario.SetSalario(5000);
Console.WriteLine(funcionario.GetSalario()); 

Retangulo ret = new Retangulo();
ret.SetAltura(5.1);
ret.SetLargura(5.1);
Console.WriteLine(ret.GetAltura());
Console.WriteLine(ret.GetLargura());
Console.WriteLine(ret.CalcularArea());



//ENCAPSULAMENTO --> Esconde metodo e atributos. Exemplo um saldo de conta nao pode ser acessado/modificado diretamente, somente o metodo Sacar() ou Depositar() podem acessar/modificar o saldo
// existem 4 palavras prossiveis para o encapsulamento

//1-public --> classes, metodos ou atributos podem ser acessados por qualquer um ou qualquer lugar do codigo. Por padrao todas as classes sao publicas

//2-private --> classes, metodos ou atributos, somente podera ser acessado pelo proprio.  vantagens esconder atributos, metodos ou classes, outra vantagem e definir regras para alteracao ou listagem.
//REGRAS: todo atributo privado precisa comecar com sublinhado _.


//3-protected e internal --> so pode ser acessado por ele mesmo igual o private e por sua classe pai


//HERANCA --> 