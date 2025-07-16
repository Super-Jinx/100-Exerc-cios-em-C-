// 49) Crie um programa que leia 6 números inteiros e no final mostre quantos deles 
// são pares e quantos são ímpares.

int pares = 0;
int impares = 0;
int contador = 0;


while (contador < 6)
{
    Console.WriteLine("Digite um numero inteiro (6X): ");
    int numeros = int.Parse(Console.ReadLine());

    if (numeros % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
    contador++;


}

Console.WriteLine("Quatidade de números pares: " + pares);
Console.WriteLine("Quatidade de números impares: " + impares);