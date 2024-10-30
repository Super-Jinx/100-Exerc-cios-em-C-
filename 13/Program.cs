// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá Funcionário do Mês, temos uma surpresa para você! Digite o seu salário: ");

double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Por ter alcançado suas metas, você terá 15% de aumento!");

double aumento = salario*15/100;
double novoSalario = salario + aumento;

Console.WriteLine($"Parabéns! Seu novo salário é: {novoSalario:C}!");
