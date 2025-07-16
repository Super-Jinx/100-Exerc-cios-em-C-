// 15) Crie um programa que leia o número de dias trabalhados em um mês e mostre o 
// salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25 
// por hora trabalhada.

Console.WriteLine("Olá querido colaborador! Quantos dias você trabalhou esse mês?");

double dias = double.Parse(Console.ReadLine());

double totalHoras = dias * 8;

double salario = totalHoras * 25;

Console.WriteLine($"Seu salário esse mês é de: {salario:C}.Obrigada!");


