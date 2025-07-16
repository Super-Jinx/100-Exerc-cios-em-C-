// 30) [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo 
// de triângulo será formado: 
//  - EQUILÁTERO: todos os lados iguais
//  - ISÓSCELES: dois lados iguais
//  - ESCALENO: todos os lados diferentes

Console.WriteLine("Olá, vamos ver se conseguimos formar um triângulo com a sua reta? Quanto mede o primeiro segmento?");

double segmento1 = double.Parse(Console.ReadLine());


Console.WriteLine("Agora, o segundo segmento: ");

double segmento2 = double.Parse(Console.ReadLine());

Console.WriteLine("Por fim, o terceiro segmento: ");

double segmento3 = double.Parse(Console.ReadLine());


bool regra1 = segmento3 < segmento1 + segmento2;
bool regra2 = segmento2 < segmento1 + segmento3;
bool regra3 = segmento1 < segmento2 + segmento3;


if (regra1 && regra2 && regra3)
{
    Console.WriteLine("É possível formar um triângulo!");


    if (segmento1 == segmento2 && segmento2 == segmento3)
    {
        Console.WriteLine("Tipo de triângulo: EQUILÁTERO (todos os lados iguais).");
    }
    else if (segmento1 == segmento2 || segmento1 == segmento3 || segmento2 == segmento3)
    {
        Console.WriteLine("Tipo de triângulo: ISÓSCELES (dois lados iguais).");
    }
    else
    {
        Console.WriteLine("Tipo de triângulo: ESCALENO (todos os lados diferentes).");
    }
}
else
{
    Console.WriteLine("Infelizmente, não é possível formar um triângulo.");
}


