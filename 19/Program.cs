// See https://aka.ms/new-console-template for more information

Console.WriteLine("Olá aluno(a), qual é o seu nome?");

string nome = Console.ReadLine();

Console.WriteLine($"{nome}, qual foi a sua primeira nota?");

double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{nome}, qual foi a sua segunda nota?");

double nota2 = Convert.ToDouble(Console.ReadLine());;

double media = (nota1 + nota2) / 2;


Console.WriteLine($"{nome}, sua média é: {media}");

if (media >= 7.0)
{
    Console.WriteLine($"Parabéns {nome}, você está aprovado!");
}

else
{
    Console.WriteLine($"{nome}. você não alcançou a média.Estude mais!");
}