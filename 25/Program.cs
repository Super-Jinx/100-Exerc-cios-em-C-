// 25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta. 
//Analise seus comprimentos e diga se é possível formar um triângulo com essas 
//retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento 
//de cada lado deve ser menor que a soma dos outros dois.

Console.WriteLine("Olá, vamos ver se conseguimos formar um triângulo com a sua reta? Quanto mede o primeiro segmento?");

double segmento1 = double.Parse(Console.ReadLine());


Console.WriteLine("Agora, o segundo segmento: ");

double segmento2 = double.Parse(Console.ReadLine());

Console.WriteLine("Por fim, o terceiro segmento: ");

double segmento3 = double.Parse(Console.ReadLine());


bool regra1 = segmento3 < segmento1 + segmento2;
bool regra2 = segmento2 < segmento1 + segmento3;
bool regra3 = segmento1 < segmento2 + segmento3;

if (regra1 && regra2 && regra3)
    Console.WriteLine("É possível formar um triângulo!");
else
    Console.WriteLine("Infelizmente, não é possível formar um triângulo.");