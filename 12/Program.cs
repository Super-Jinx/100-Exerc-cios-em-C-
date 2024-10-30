// See https://aka.ms/new-console-template for more information
Console.WriteLine("Comprando brusinhas né, quanto custa o seu produto?");

double valor = double.Parse(Console.ReadLine());

Console.WriteLine("Vou te dar um desconto de 5%");

double desconto = valor*5/100;
double valorFinal = valor - desconto;

Console.WriteLine($"Com o PREÇO PROMOCIONAL, seu produto custará apenas: {valorFinal:C}!");