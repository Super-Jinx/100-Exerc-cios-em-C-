// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite um número real, ou seja, qualquer valor com vígula HAHA :");

double numero = double.Parse(Console.ReadLine());

double dobro = numero*2;
double tercaParte = numero/3;

Console.WriteLine($"O dobro de {numero} é {dobro}");

Console.WriteLine($"A terça parte de {numero} é {tercaParte}");


