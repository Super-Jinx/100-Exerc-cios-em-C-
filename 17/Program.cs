// PASSO 02 - CONDIÇÕES BÁSICAS
// 17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse 
// 80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba 
// o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.

Console.WriteLine("Diga aí Domenique Toreto, você estava digirindo em qual velocidade? (km/h)");

double quilometrosPercorridos = double.Parse(Console.ReadLine());

double limiteQuilometros = 80.0;

double valorPorKmExcedente = 5.0;

double valorTotalAdicional = 0.0;



if (quilometrosPercorridos <= limiteQuilometros)

{
    Console.WriteLine($"Parabéns! sua velocidade de {quilometrosPercorridos} km, está dentro dos limities permitidos!");
}

else
{
    double quilometrosExcedentes = quilometrosPercorridos - limiteQuilometros;

    valorTotalAdicional = quilometrosExcedentes * valorPorKmExcedente;

    Console.WriteLine($"Você excedeu o limite de velocidade, sua multa é de:{valorTotalAdicional:C}");



}











