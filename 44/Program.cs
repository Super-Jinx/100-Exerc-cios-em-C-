// 44) Crie um algoritmo que leia o valor inicial da contagem, o valor final e o 
// incremento, mostrando em seguida todos os valores no intervalo:
// Ex: Digite o primeiro Valor: 3
// Digite o último Valor: 10
// Digite o incremento: 2
// Contagem: 3 5 7 9 Acabou!

Console.WriteLine("Olá, sou eu de novo! Por favor, digite o valor inicial:");

int valorInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Certo, agora digite o valor final:");

int valorFinal = int.Parse(Console.ReadLine());

Console.WriteLine("E para encerrarmos, pode escolher o valor do incremento:");

int incremento = int.Parse(Console.ReadLine());

Console.WriteLine("Contagem: ");

int contador = valorInicial;

while (contador <= valorFinal)
{
    Console.WriteLine(contador);
    contador += incremento;
}

Console.WriteLine("Acabou!");



