// 31) [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)

Console.WriteLine("Oie! Vamos jogar! Escolha uma das opções e digite o número correspondente: 1 - Pedra; 2 - Papel e 3 - Tesoura");

int opcao = int.Parse(Console.ReadLine());

int pedra = 1;
int papel = 2;
int tesoura = 3;

if (opcao == 1)

    Console.WriteLine("Você escolheu PEDRA e eu PAPEL, PAPEL cobre a PEDRA, você perdeu! Vamos de novo?! :D");

else if (opcao == 2)

    Console.WriteLine("Você escolheu PAPEL e eu TESOURA, TESOURA corta o PAPEL, você perdeu! Vamos de novo?! :D");

else if (opcao == 3)

    Console.WriteLine("Você escolheu TESOURA e eu PEDRA, PEDRA esmaga a TESOURA, você perdeu! Vamos de novo?! :D");

