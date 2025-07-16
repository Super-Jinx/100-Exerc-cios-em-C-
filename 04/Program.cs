// 4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório 
//entre eles.
//Ex:
//Digite um valor: 8
//Digite outro valor: 5
//A soma entre 8 e 5 é igual a 13.

Console.WriteLine("Digite um valor:");

int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Agora,digite outro valor:");

int valor2 = int.Parse(Console.ReadLine());

int resultado = valor1 + valor2;
 
Console.WriteLine($"A soma entre {valor1} e {valor2} é igual a {resultado}");
  
