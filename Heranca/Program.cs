//HERANCA - Uma classe pode pegar todos os atributos e metodos de outra classe

//Carro - Modelo, Marca, Quilometragem
//Carroeletrico - Beteria, TempoDeCarga
//CarroCombustao - Combustivel

using System.Globalization;
using Heranca;
using POO_CSharp;

CarroEletrico carroE = new CarroEletrico();

carroE.marca = "Tela";
carroE.bateria = 10000;
carroE.tempoDeCarga = 2;

CarroCombustao carroC = new CarroCombustao();

carroC.marca = "Fiat";

Carro meuCarro;

Console.WriteLine("Digite E para eletrico ou Digte C para combustao");
string opcao = Console.ReadLine();

if (opcao == "E")
{
    meuCarro = new CarroEletrico();
}
else
{
    meuCarro = new CarroEletrico();
}

//Pesso que tem nome
//Criar 2 classes (PF e PJ)

PessoaFisica pf = new PessoaFisica();
pf.nome = "Marcos";
pf.cpf = "12345678901";

PessoaJuridica pj = new PessoaJuridica();
pj.nome = "joao";
pj.cnpj = "12345678756422";



ContaCorrente mov = new ContaCorrente();
Console.Write("Informe o deposito: ");
double dep = double.Parse(Console.ReadLine());
mov.Depositar(dep - mov.CobrarTaxa());
Console.Write("Informe o valor de saque: ");
double sac = double.Parse(Console.ReadLine());
mov.Sacar(sac);
Console.WriteLine($"O saldo e: {mov.VerSaldo()} e a taxa foi de {mov.CobrarTaxa()}");



