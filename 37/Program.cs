//37) Uma empresa precisa reajustar o salário dos seus funcionários, dando um 
//aumento de acordo com alguns fatores. Faça um programa que leia o salário atual, 
//o gênero do funcionário e há quantos anos esse funcionário trabalha na empresa. 
//No final, mostre o seu novo salário, baseado na tabela a seguir:
//- Mulheres
//- menos de 15 anos de empresa: +5%
//- de 15 até 20 anos de empresa: +12%
// - mais de 20 anos de empresa: +23%
//- Homens
//- menos de 20 anos de empresa: +3%
//- de 20 até 30 anos de empresa: +13%
//- mais de 30 anos de empresa: +25%

Console.WriteLine("Olá querido funcionário, insira qual o seu salário, quantos anos você tem de empresa e qual o seu gênero:");

double salarioInicial = double.Parse(Console.ReadLine());
int anosEmpresa = int.Parse(Console.ReadLine());
string genero = Console.ReadLine();

if (genero == "mulher" && anosEmpresa < 15)
{

    double aumentoMulherMenor = salarioInicial * 1.05;
    Console.WriteLine($"Seu novo salário é de:{aumentoMulherMenor:C}");

}
if (genero == "mulher" && anosEmpresa >= 15 && anosEmpresa <= 20)
{

    double aumentoMulherMeio = salarioInicial * 1.12;
    Console.WriteLine($"Seu novo salário é de:{aumentoMulherMeio:C}");

}
if (genero == "mulher" && anosEmpresa > 20)
{

    double aumentoMulherMaior = salarioInicial * 1.23;
    Console.WriteLine($"Seu novo salário é de:{aumentoMulherMaior:C}");

}

if (genero == "homem" && anosEmpresa < 20)
{

    double aumentoHomemMenor = salarioInicial * 1.03;
    Console.WriteLine($"Seu novo salário é de:{aumentoHomemMenor:C}");

}
if (genero == "homem" && anosEmpresa >= 20 && anosEmpresa <= 30)
{

    double aumentoHomemMeio = salarioInicial * 1.13;
    Console.WriteLine($"Seu novo salário é de:{aumentoHomemMeio:C}");

}
if (genero == "homem" && anosEmpresa > 30)
{

    double aumentoHomemMaior = salarioInicial * 1.25;
    Console.WriteLine($"Seu novo salário é de:{aumentoHomemMaior:C}");

}