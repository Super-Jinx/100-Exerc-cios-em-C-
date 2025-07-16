//14) A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva 
// um programa que pergunte a quantidade de Km percorridos por um carro alugado e a 
// quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar, 
// sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado.

Console.WriteLine("Bem-vindo á locadora de Carros Relâmpago McQueen!" +
"Por favor, informe a quantidade de KM percorridos:");

double km = double.Parse(Console.ReadLine());

Console.WriteLine("Agora, nos informe quantos dias você ficou com o carro:");

double dia = double.Parse(Console.ReadLine());

double kmRodado = km * 0.20;

double valorDias = dia * 90;

double valorTotal = kmRodado + valorDias;

Console.WriteLine($"O Valor a ser pago é de: {valorTotal:C}. Agradecemos a Preferência!");

