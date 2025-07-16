// 32) [DESAFIO] Crie um jogo onde o computador vai sortear um número entre 1 e 5 o 
// jogador vai tentar descobrir qual foi o valor sorteado.

Console.WriteLine("Olá, nesse jogo o computador vai sortear um número de 1 a 5");

Random aleatorio = new Random();
int numero = aleatorio.Next(1, 6);

Console.WriteLine("Qual número você acha que foi o escolhido?");

int escolha = int.Parse(Console.ReadLine());

if (escolha == numero)

    Console.WriteLine($"Parabéns! Você acertou! O número sorteado foi {numero}");

else

    Console.WriteLine($"Há, erroooou,sua escolha foi {escolha}, mas o número sorteado foi: {numero} ");