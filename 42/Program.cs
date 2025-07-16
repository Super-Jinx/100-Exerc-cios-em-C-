// 42) Faça um algoritmo que pergunte ao usuário um número inteiro e positivo 
// qualquer e mostre uma contagem até esse valor:
// Ex: Digite um valor: 35
// Contagem: 1 2 3 4 5 6 7 ... 33 34 35 Acabou!
Console.WriteLine("Olá jovem Padawan, por favor, digite um número inteiro e positivo:");

int limite = int.Parse(Console.ReadLine());
int contador = 1;

while (contador <= limite)
{
    Console.WriteLine($"{contador}");
    contador++;

}
Console.WriteLine("Acabou!");