// See https://aka.ms/new-console-template for more information
Console.WriteLine("Salve drogadito! Quantos cigarros você fuma por dia?");

double cigarro = double.Parse(Console.ReadLine());

Console.WriteLine("E há quantos anos você fuma?");

double anos = double.Parse(Console.ReadLine());

double perdaMinutos = cigarro * 60 * anos;
double perdaTotal = perdaMinutos / 24;

// double qtdeDias = anos * 365;
// double perdaMinutos = cigarro * 10 * qtdeDias;
// double perdaHoras = perdaMinutos / 60;
// double perdaDias = perdaHoras / 24;

Console.WriteLine($"Esse vício já te tirou {perdaDias:F1} dias de vida! REPENSE!!");

