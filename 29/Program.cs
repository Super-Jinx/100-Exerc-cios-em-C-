//29) Desenvolva um programa que leia o nome de um funcionário, seu salário, 
//quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de 
//acordo com a tabela a seguir:
//- Até 3 anos de empresa: aumento de 3%
// - entre 3 e 10 anos: aumento de 12.5%
// 10 anos ou mais: aumento de 20%


Console.WriteLine("Olá colaborador! Qual o seu nome?");

string nome = Console.ReadLine();

Console.WriteLine($" {nome}, qual é o valor do seu salário?");

double salario = double.Parse(Console.ReadLine());

Console.WriteLine($"{nome}, quantos anos você trabalha na Tambaqui Software?");

double anos = double.Parse(Console.ReadLine());

if (anos <= 3)
{
    double salarioFinal = salario + (0.03 * salario);

    Console.WriteLine($"{nome}, seu novo salário é: {salarioFinal:C}");
}

else if (anos > 3 && anos < 10)
{
    double salarioFinal = salario + (0.125 * salario);

    Console.WriteLine($"{nome}, seu novo salário é: {salarioFinal:C}");
}

else if (anos >= 10)
{
    double salarioFinal = salario + (0.2 * salario);

    Console.WriteLine($"{nome}, seu novo salário é: {salarioFinal:C}");
}