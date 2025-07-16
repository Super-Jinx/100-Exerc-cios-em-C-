// 10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e 
// mostre a área a ser pintada e a quantidade de tinta necessária para o serviço, 
// sabendo que cada litro de tinta pinta uma área de 2 metros quadrados.

Console.WriteLine("Qual é a largura da parede?");

double largura = double.Parse(Console.ReadLine());

Console.WriteLine("Qual é a altura da parede?");

double altura = double.Parse(Console.ReadLine());

double area = altura * largura;

double tinta = area / 2;

Console.WriteLine($"A área da parede é: {area} m², para pintar a parede, você precisará de:" +
$" {tinta} L de tinta. ");
