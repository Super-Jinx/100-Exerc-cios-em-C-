// 16) [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um 
// fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele 
// já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule 
// quantos dias de vida um fumante perderá e exiba o total em dias.

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

Console.WriteLine($"Esse vício já te tirou {perdaTotal:N1} dias de vida! REPENSE!!");

