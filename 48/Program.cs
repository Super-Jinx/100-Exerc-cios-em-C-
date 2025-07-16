// 48) Faça um programa que leia 7 números inteiros e no final mostre o somatório 
// entre eles.

int contador = 0;
int soma = 0;



while (contador < 7)
{
    Console.WriteLine("Olá, digite um número inteiro! (7X)");
    int numero = int.Parse(Console.ReadLine());

    soma += numero;
    contador++;
}

Console.WriteLine("Resultado da soma dos números inseridos: " + soma);