// 46) Crie um programa que calcule e mostre na tela o resultado da soma entre 6 + 
// 8 + 10 + 12 + 14 + ... + 98 + 100.

int contador = 6;
int soma = 0;

while (contador <= 100) 
{  
    soma += contador;
    contador += 2;
}
Console.WriteLine ("Resultado da soma de 6 a 100 incrementando de 2 em 2: " + soma);