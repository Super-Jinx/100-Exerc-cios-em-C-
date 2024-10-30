// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite uma distância em Metros(m)");

double distancia = double.Parse(Console.ReadLine());

double km = distancia /1000;
double Hm = distancia *0.01;
double Dam = distancia /10;
double Dm = distancia *10;
double cm = distancia *100;
double mm = distancia *1000;

Console.WriteLine($"A distância de: {distancia} m corresponde a: " +
            $" {km} km, {Hm} Hm,{Dam} Dam,{Dm} Dm, {cm} cm e {mm} mm");
