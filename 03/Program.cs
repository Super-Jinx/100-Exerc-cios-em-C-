
//3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no 
//final uma mensagem.
//Ex:
//Nome do Funcionário: Maria do Carmo
//Salário: 1850,45
//O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.

Console.WriteLine("Olá, qual é o seu nome?");

string nome = Console.ReadLine();

Console.WriteLine($"Por gentileza,{nome}, digite o seu salário:");

decimal salário = decimal.Parse(Console.ReadLine());
        
Console.WriteLine($"Nome do funcionário: {nome} ");
Console.WriteLine($"Salário: {salário} ");
Console.WriteLine($"O(a) funcionário(a): {nome}, tem o salário de R$ {salário} em junho. ");
    
