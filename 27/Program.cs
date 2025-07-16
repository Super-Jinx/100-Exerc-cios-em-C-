//27) Crie um programa que leia duas notas de um aluno e calcule a sua média, 
//mostrando uma mensagem no final, de acordo com a média atingida:
// - Média até 4.9: REPROVADO
// - Média entre 5.0 e 6.9: RECUPERAÇÃO
// - Média 7.0 ou superior: APROVADO

Console.WriteLine("Olá aluno,buchudo e remelento! Digite suas duas notas desse bimestre: ");

double nota1 = double.Parse(Console.ReadLine());
double nota2 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;


if (media <= 4.9)
{

    Console.WriteLine($"Sua média é: {media} REPROVADO");
}

else if (media >= 5.0 && media <= 6.9)
{
    Console.WriteLine($"Sua média é: {media} RECUPERAÇÃO");
}

else if (media >= 7.0)
{
    Console.WriteLine($"Sua média é: {media} APROVADO");
}