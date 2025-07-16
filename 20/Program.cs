// 20) Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou 
// ÍMPAR.

Console.WriteLine("Olá, digite um número inteiro:");

int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}

else
{
    Console.WriteLine($"O número {numero} é ímpar.");
}
