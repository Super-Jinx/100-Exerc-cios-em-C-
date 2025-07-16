// 7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a 
// sua terça parte.
// Ex: 
// Digite um número: 3.5
// O dobro de 3.5 é 7.0
// A terça parte de 3.5 é 1.16666

Console.WriteLine("Digite um número real, ou seja, qualquer valor com vígula HAHA :");

double numero = double.Parse(Console.ReadLine());

double dobro = numero*2;
double tercaParte = numero/3;

Console.WriteLine($"O dobro de {numero} é {dobro}");

Console.WriteLine($"A terça parte de {numero} é {tercaParte}");


