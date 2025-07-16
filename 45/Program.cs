// 45) O programa acima vai ter um problema quando digitarmos o primeiro valor 
// maior que o último. Resolva esse problema com um código que funcione em qualquer 
// situação.

Console.Write("Digite o valor inicial: ");

int valorInicial = int.Parse(Console.ReadLine());

Console.Write("Digite o valor final (pode ser maior ou menor que o primeiro valor digitado, desde que seja inteiro e positivo.): ");

int valorFinal = int.Parse(Console.ReadLine());

Console.Write("Digite o incremento: ");

int incremento = int.Parse(Console.ReadLine());

if (incremento <= 0)
{
    Console.WriteLine("O incremento deve ser um número positivo!");
    return;
}

Console.Write("Contagem: ");


if (valorInicial < valorFinal)
{
    int contador = valorInicial;
    while (contador <= valorFinal)
    {
        Console.Write(contador + " ");
        contador += incremento;
    }
}

else
{
    int contador = valorInicial;
    while (contador >= valorFinal)
    {
        Console.Write(contador + " ");
        contador -= incremento;
    }
}

Console.WriteLine("Acabou!");


