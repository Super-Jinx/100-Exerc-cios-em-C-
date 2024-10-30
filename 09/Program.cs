// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite quanto você tem na carteira (R$):");

double valor = double.Parse(Console.ReadLine());

double cambio = valor /3.45; 


Console.WriteLine($"Com {valor} reais, você consegue comprar {cambio:N2} dólares");