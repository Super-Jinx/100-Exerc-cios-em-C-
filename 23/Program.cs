// 23) Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos 
//para todos, mas especialmente para mulheres. Faça um programa que leia nome, 
//sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo 
//que:
//- Homens ganham 5% de desconto
//- Mulheres ganham 13% de desconto

Console.WriteLine("Olá cliente, como é seu nome?");

string nome = Console.ReadLine();

Console.WriteLine($"Bem vindo(a) á nossa loja {nome}!, qual o seu sexo: Digite 1 - Homem ou 2 - Mulher");

int sexoCliente = int.Parse(Console.ReadLine());

Console.Write("Qual foi o valor da sua compra?");

double valorCompra = double.Parse(Console.ReadLine());

if (sexoCliente == 1)
{

    double desconto = valorCompra * 5 / 100;
    double valorFinal = valorCompra - desconto;

    Console.WriteLine($"Com o desconto de 5%, seu produto custará apenas: {valorFinal:C}!");
}
else
{
    double desconto = valorCompra * 13 / 100;
    double valorFinal = valorCompra - desconto;

    Console.WriteLine($"Com o desconto de 13%, seu produto custará apenas: {valorFinal:C}!");
}
