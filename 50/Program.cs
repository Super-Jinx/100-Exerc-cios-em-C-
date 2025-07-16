// 50) Desenvolva um programa que faça o sorteio de 20 números entre 0 e 10 e 
// mostre na tela:
// a) Quais foram os números sorteados
// b) Quantos números estão acima de 5
// c) Quantos números são divisíveis por 3

Random rand = new Random();
int contador = 0;
int acimaDe5 = 0;
int divisiveisPor3 = 0;

Console.WriteLine("Números sorteados:");

while (contador < 20)
{
    int numero = rand.Next(0, 11);
    Console.Write(numero + " ");

    if (numero > 5)
        acimaDe5++;

    if (numero % 3 == 0)
        divisiveisPor3++;

    contador++;
}

Console.WriteLine("\n\nQuantidade de números acima de 5: " + acimaDe5);
Console.WriteLine("Quantidade de números divisíveis por 3: " + divisiveisPor3);

