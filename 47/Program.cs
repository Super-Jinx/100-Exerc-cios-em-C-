// Desenvolva um aplicativo que mostre na tela o resultado da expressão 500 + 
// 450 + 400 + 350 + 300 + ... + 50 + 0

int contador = 500;
int soma = 0;


while (contador >= 0)
{

    soma += contador;
    contador -= 50;

}

Console.WriteLine("Resultado: " + soma);