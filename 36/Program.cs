﻿// 36) Um programa de vida saudável quer dar pontos atividades físicas que podem 
//ser trocados por dinheiro. O sistema funciona assim:
//- Cada hora de atividade física no mês vale pontos
// - até 10h de atividade no mês: ganha 2 pontos por hora
// - de 10h até 20h de atividade no mês: ganha 5 pontos por hora
// - acima de 20h de atividade no mês: ganha 10 pontos por hora
// - A cada ponto ganho, o cliente fatura R$0,05 (5 centavos) 
//Faça um programa que leia quantas horas de atividade uma pessoa teve por mês, 
//calcule e mostre quantos pontos ela teve e quanto dinheiro ela conseguiu ganhar.

Console.WriteLine("Olá atleta! Digite quantas horas de atividade física você praticou esse mês:");

int horas = int.Parse(Console.ReadLine());

double ponto = 0.05;


if (horas <= 10)
{
    int totalHoras = horas * 2;
    double totalGeral = totalHoras * ponto;
    Console.WriteLine($"Parabéns, você ganhou {totalHoras} pontos e {totalGeral:C}!");
}

if (horas > 10 && horas <= 20)
{
    int totalHoras = horas * 5;
    double totalGeral = totalHoras * ponto;
    Console.WriteLine($"Parabéns, você ganhou {totalHoras} pontos e {totalGeral:C}!");
}

if (horas > 20)
{
    int totalHoras = horas * 10;
    double totalGeral = totalHoras * ponto;
    Console.WriteLine($"Parabéns, você ganhou {totalHoras} pontos e {totalGeral:C}!");
}