// See https://aka.ms/new-console-template for more information

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
    

