//HERANCA - Uma classe pode pegar todos os atributos e metodos de outra classe

//Carro - Modelo, Marca, Quilometragem
//Carroeletrico - Beteria, TempoDeCarga
//CarroCombustao - Combustivel

using System.Globalization;
using Heranca.Carros;
using Heranca.Contas;
using Heranca.Funcionarios;

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
    if(meuCarro is CarroEletrico ce)
    {
        ce.bateria = 200;
    }
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
mov.Depositar(dep);
Console.Write("Informe o valor de saque: ");
double sac = double.Parse(Console.ReadLine());
mov.Sacar(sac);
mov.CobrarTaxa();

ContaPoupanca poupanca = new ContaPoupanca();
poupanca.Depositar(100);
poupanca.RenderJuros();

Gerente gerente = new Gerente();
gerente.SetSalario(8000);
gerente.Bonificar();


Carro carro1 = new Carro();
CarroEletrico carroEletrico = new CarroEletrico();

carro1.modelo = "Fusca";
carro1.marca = "Volkswagem";
carro1.quilometragem = 3000;

carroEletrico.modelo = "Fusca";
carroEletrico.marca = "Volkswagem";
carroEletrico.quilometragem = 3000;
carroEletrico.bateria = 120;
carroEletrico.tempoDeCarga = 2;

carro1.MostrarInformacoes();

carroEletrico.MostrarInformacoes();
