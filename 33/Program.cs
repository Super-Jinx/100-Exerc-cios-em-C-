
//33) Escreva um programa para aprovar ou não o empréstimo bancário para a compra 
//de uma casa. O programa vai perguntar o valor da casa, o salário do comprador e 
//em quantos anos ele vai pagar. Calcule o valor da prestação mensal, sabendo que 
//ela não pode exceder 30% do salário ou então o empréstimo será negado.

Console.WriteLine("Bem-vindo ao Gatinho's Créditos! Qual o valor da casa que você deseja financiar?");

double valorCasa = double.Parse(Console.ReadLine());

Console.WriteLine("Qual é o seu salário e em quantos anos deseja pagar o financiamento?");

double salario = double.Parse(Console.ReadLine());

double anos = double.Parse(Console.ReadLine());
double anosMeses = anos * 12;

double parcela = valorCasa / anosMeses;

double descontoLimite = salario - (0.3 * salario);
double parcelaLimite = salario - descontoLimite;


if (parcela <= parcelaLimite)

{
    Console.WriteLine($"Seu crédito foi aprovado! A sua parcela terá o valor de {parcela:C}");
}

else
{
    Console.WriteLine("Crédito não aprovado!");
}