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
carro.modelo = "Civic";
carro.anoFrabricacao = 2012;
carro.marca = "Honda";

carro.Andar();
carro.MostrarInformacoes();
carro.Parar();

Console.WriteLine("");

Carro carro2 = new Carro();
//Para acessar informacoes do objeto, usar o ponto(.)
carro2.modelo = "Volkswagem";
carro2.anoFrabricacao = 1998;
carro2.marca = "Gol";

carro2.Andar();
carro2.MostrarInformacoes();
carro2.Parar();


Console.WriteLine("");

Carro carro3 = new Carro();
//Para acessar informacoes do objeto, usar o ponto(.)
carro3.modelo = "Uno";
carro3.anoFrabricacao = 2015;
carro3.marca = "Fiat";

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

