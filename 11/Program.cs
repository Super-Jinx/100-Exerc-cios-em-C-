// 11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do 
// segundo grau e mostre o valor de Delta.

Console.WriteLine("Olá jovem Padawan, vamos calcular o valor de Delta na amizade! Insira o valor de A:");

double A = double.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o valor de B:");

double B = double.Parse(Console.ReadLine());

Console.WriteLine("E por fim. digite o valor de C:");

double C = double.Parse(Console.ReadLine());

double Delta = B * B - 4 * A * C;

Console.WriteLine($"O valor de Delta é {Delta}. De nada, me deve essa!");
