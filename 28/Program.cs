// See https://aka.ms/new-console-template for more information
//28) Faça um programa que leia a largura e o comprimento de um terreno 
//retangular, calculando e mostrando a sua área em m². O programa também 
//devemostrar a classificação desse terreno, de acordo com a lista abaixo:
 //- Abaixo de 100m² = TERRENO POPULAR
 //- Entre 100m² e 500m² = TERRENO MASTER
 //- Acima de 500m² = TERRENO VIP


Console.WriteLine("Olá, digite o comprimento e a largura do seu terreno!");

double comprimento = double.Parse(Console.ReadLine());
double altura = double.Parse(Console.ReadLine());

double area = comprimento * altura;

if (area < 100)
{
    Console.WriteLine($"A área de {area} m² se enquadra em:Terreno Popular. ");
}

else if (area >= 100 && area <= 500)
{
    Console.WriteLine($"A área de {area} m² se enquadra em:Terreno Master. ");
}
else if (area > 500)
{
    Console.WriteLine($"A área de {area} m² se enquadra em:Terreno VIP. ");
}