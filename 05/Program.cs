// 5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre 
//na tela a sua média na disciplina.
//Ex: 
//Nota 1: 4.5
//Nota 2: 8.5
// média entre 4.5 e 8.5 é igual a 6.5

Console.WriteLine("Digite a sua primeira nota:");

decimal nota1 = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua segunda nota:");

decimal nota2 = decimal.Parse(Console.ReadLine());

decimal media = (nota1 + nota2)/2;

Console.WriteLine($"A média ente {nota1} e {nota2} é {media}" );
