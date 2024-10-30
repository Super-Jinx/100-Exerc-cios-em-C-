// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem-vindo á locadora de Carros Relâmpago McQueen!" +
"Por favor, informe a quantidade de KM percorridos:");

double km = double.Parse(Console.ReadLine());

Console.WriteLine("Agora, nos informe quantos dias você ficou com o carro:");

double dia = double.Parse(Console.ReadLine());

double kmRodado = km *0.20;

double valorDias = dia *90;

double valorTotal = kmRodado + valorDias;

Console.WriteLine($"O Valor a ser pago é de: {valorTotal:C}. Agradecemos a Preferência!");

