// See https://aka.ms/new-console-template for more information
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
