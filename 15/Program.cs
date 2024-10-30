// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá querido colaborador! Quantos dias você trabalhou esse mês?");

double dias = double.Parse(Console.ReadLine());

double totalHoras = dias *8;

double salario = totalHoras *25;

Console.WriteLine($"Seu salário esse mês é de: {salario:C}.Obrigada!");


