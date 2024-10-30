// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qual é a largura da parede?");

double largura = double.Parse(Console.ReadLine());

Console.WriteLine("Qual é a altura da parede?");

double altura = double.Parse(Console.ReadLine());

double area = altura*largura;

double tinta = area/2;

Console.WriteLine($"A área da parede é: {area} m², para pintar a parede, você precisará de:" +
$" {tinta} L de tinta. ");
