// 22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua 
// situação em relação ao alistamento militar.
//  - Se estiver antes dos 18 anos, mostre em quantos anos faltam para o 
// alistamento.
//  - Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do 
// alistamento.

Console.WriteLine("Olá recruta, em que ano você nasceu?");

int anoNascimento = int.Parse(Console.ReadLine());

int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;

if (idade < 18)
{
int anosFaltantes = 18 - idade;
Console.WriteLine($"Faltam {anosFaltantes} anos para o alistamento militar.");
}
else if (idade == 18)
{
Console.WriteLine("Está na idade de se alistar no serviço militar.");
}
else
{
int anosPassados = idade - 18;
 
Console.WriteLine($"Já passaram {anosPassados} anos do alistamento militar.");
}
    

