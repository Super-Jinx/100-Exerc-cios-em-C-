// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a sua primeira nota:");

decimal nota1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua segunda nota:");

decimal nota2 = decimal.Parse(Console.ReadLine());

decimal media = (nota1 + nota2)/2;

Console.WriteLine($"A média ente {nota1} e {nota2} é {media}" );
