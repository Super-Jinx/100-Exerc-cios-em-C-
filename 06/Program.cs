// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite um número inteiro:");

int numero = int.Parse(Console.ReadLine());

int antecessor = numero-1;
int sucessor = numero+1;

 Console.WriteLine($"O antecessor de {numero} é {antecessor}");


Console.WriteLine($"O sucessor de {numero} é {sucessor}");