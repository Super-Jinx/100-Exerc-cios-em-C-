
Console.WriteLine("Olá, foi obrigado a vir na Justiça Eleitoral, né! Me informe o ano em que você nasceu:");

double anoNascimento = double.Parse(Console.ReadLine());

double anoAtual = 2024;
double idadeAtual = anoAtual - anoNascimento;
double maiorIdade = 18.0;


if (idadeAtual >= maiorIdade)
{
    Console.WriteLine($"Com a sua idade de {idadeAtual} ano, você já pode votar!");
}

else
{

    Console.WriteLine($"Com a sua idade de {idadeAtual} anos, você não pode votar!");
}


// SHIFT + ALT + F = Formatar Bonitinho