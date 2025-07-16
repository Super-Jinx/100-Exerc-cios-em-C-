// 19) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua 
// média e mostre na tela. No final, analise a média e mostre se o aluno teve ou 
// não um bom aproveitamento (se ficou acima da média 7.0).

Console.WriteLine("Olá aluno(a), qual é o seu nome?");

string nome = Console.ReadLine();

Console.WriteLine($"{nome}, qual foi a sua primeira nota?");

double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{nome}, qual foi a sua segunda nota?");

double nota2 = Convert.ToDouble(Console.ReadLine()); ;

double media = (nota1 + nota2) / 2;


Console.WriteLine($"{nome}, sua média é: {media}");

if (media >= 7.0)
{
    Console.WriteLine($"Parabéns {nome}, você teve um bom aproveitamento!");
}

else
{
    Console.WriteLine($"{nome}. Infelizmente seu aproveitamento não foi satisfatório!");
}