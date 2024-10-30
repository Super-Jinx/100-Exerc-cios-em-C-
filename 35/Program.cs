// See https://aka.ms/new-console-template for more information
//35) Uma empresa de aluguel de carros precisa cobrar pelos seus serviços. O 
//aluguel de um carro custa R$90 por dia para carro popular e R$150 por dia para 
//carro de luxo. Além disso, o cliente paga por Km percorrido. Faça um programa
//que leia o tipo de carro alugado (popular ou luxo), quantos dias de aluguel e 
//quantos Km foram percorridos. No final mostre o preço a ser pago de acordo com a 
//tabela a seguir:
//- Carros populares (aluguel de R$90 por dia)
//- Até 100Km percorridos: R$0,20 por Km
//- Acima de 100Km percorridos: R$0,10 por Km
//- Carros de luxo (aluguel de R$150 por dia)
//- Até 200Km percorridos: R$0,30 por Km
//- Acima de 200Km percorridos: R$0,25 por Km

Console.WriteLine("Olá,bem vindo á locadora Relâmpago McQueen!Escolha a modalidade de carro que você contratou: A-popular; B-luxo.");
string tipodeCarro = Console.ReadLine();

Console.WriteLine("Agora nos informe a quantidade de dias.");
int dias = int.Parse(Console.ReadLine());

Console.WriteLine("Para finalizar, nos informe quantos Km foram percorridos.");
int kmPercorrido = int.Parse(Console.ReadLine());

double kmTotal = 0;
double diasTotal = 0;

if (tipodeCarro == "A")
{
    if (kmPercorrido <= 100)
    {
        kmTotal = kmPercorrido * 0.20;
        diasTotal = dias * 90;
    }
    else
    {
        kmTotal = kmPercorrido * 0.10;
        diasTotal = dias * 90;
    }


    Console.WriteLine($"O valor a ser pago é de: {kmTotal + diasTotal:C}");

}


if (tipodeCarro == "B")
{
    var taxaDoKm = 0.25;

    if (kmPercorrido <= 200)
        taxaDoKm = 0.30;

    kmTotal = kmPercorrido * taxaDoKm;
    diasTotal = dias * 150;

    Console.WriteLine($"O valor a ser pago é de: {kmTotal + diasTotal:C}");
}
