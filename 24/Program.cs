//24) Faça um algoritmo que pergunte a distância que um passageiro deseja 
//percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para 
//viagens até 200Km e R$0.45 para viagens mais longas.

Console.WriteLine("Olá passageiro! Quantos KM você deseja percorrer conosco?");

double km = double.Parse(Console.ReadLine());


if (km <= 200)
{
    double precoPassagem = km * 0.20;

    Console.WriteLine($"Sua viagem custará: {precoPassagem:C}");
}
else
{
    double precoPassagem = km * 0.45;

    Console.WriteLine($"Sua viagem custará: {precoPassagem:C}");
}