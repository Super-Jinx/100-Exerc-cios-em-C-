//PASSO 03 - CONDIÇÕES COMPOSTAS
//26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando 
//na tela uma das mensagens abaixo:
// - O primeiro valor é o maior
// - O segundo valor é o maior
// - Não existe valor maior, os dois são iguais


Console.WriteLine("Olá jovem Padawan, digite dois número inteiro: ");

int valor1 = int.Parse(Console.ReadLine());
int valor2 = int.Parse(Console.ReadLine());

if (valor1 > valor2)
{
    Console.WriteLine("O primeiro valor é maior do que o segundo valor.");
}

else if (valor1 < valor2)
{
    Console.WriteLine("O primeiro valor é menor do que o segundo valor.");
}

else if (valor1 == valor2)
{
    Console.WriteLine("Não existe valor maior, os dois são iguais.");

}

