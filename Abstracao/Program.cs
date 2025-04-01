//Abstracao --> Muito ligado com heranca
//Criar uma interface -> vai ser um contrato
//Exemplo trocar marcha, na interface nao vai falar o que o metodo trocar marcha faz

//Classe livro, que e composto por texto, autor, ano. 
//Vai existir o metodo MostrarDadosLivro
//MostrarLivro() sera uma abstracao do metodo 

using Abstracao;

ICarro carro1 = new CarroManual();
carro1.TrocarMarcha();

ICarro carro2 = new CarroAutomatico();
carro2.TrocarMarcha();