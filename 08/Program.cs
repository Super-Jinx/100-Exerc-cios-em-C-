// 8) Desenvolva um programa que leia uma distância em metros e mostre os valores 
// relativos em outras medidas.
// Ex: 
// Digite uma distância em metros: 185.72
// A distância de 85.7m corresponde a:
// 0.18572Km
// 1.8572Hm
// 18.572Dam
// 1857.2dm
// 18572.0cm
// 185720.0mm

Console.WriteLine("Digite uma distância em Metros(m)");

double distancia = double.Parse(Console.ReadLine());

double km = distancia / 1000;
double Hm = distancia * 0.01;
double Dam = distancia / 10;
double Dm = distancia * 10;
double cm = distancia * 100;
double mm = distancia * 1000;

Console.WriteLine($"A distância de: {distancia} m corresponde a:" +
            $" {km} km; {Hm} Hm; {Dam} Dam; {Dm} Dm; {cm} cm e {mm} mm");
