// 12) Crie um programa que leia o preço de um produto, calcule e mostre o seu 
// PREÇO PROMOCIONAL, com 5% de desconto.

Console.WriteLine("Comprando brusinhas né, quanto custa o seu produto?");

double valor = double.Parse(Console.ReadLine());

Console.WriteLine("Vou te dar um desconto de 5%");

double desconto = valor * 5 / 100;
double valorFinal = valor - desconto;

Console.WriteLine($"Com o PREÇO PROMOCIONAL, seu produto custará apenas: {valorFinal:C}!");