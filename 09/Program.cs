// 9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) 
// e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.

Console.WriteLine("Digite quanto você tem na carteira (R$):");

double valor = double.Parse(Console.ReadLine());

double cambio = valor / 3.45;


Console.WriteLine($"Com {valor} reais, você consegue comprar {cambio:N2} dólares");