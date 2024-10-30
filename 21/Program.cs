﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Olá, qual ano você deseja verificar?");

int ano = int.Parse(Console.ReadLine());

if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
{
    Console.WriteLine($"O ano {ano} é bissexto.");
}
else
{
    Console.WriteLine($"O {ano} não é bissexto");
}