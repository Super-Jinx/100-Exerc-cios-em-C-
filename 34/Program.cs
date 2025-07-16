//34) O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no 
//peso de uma pessoa. De acordo com o valor do IMC, podemos classificar o 
//indivíduo dentro de certas faixas.
// - abaixo de 18.5: Abaixo do peso
// - entre 18.5 e 25: Peso ideal
// - entre 25 e 30: Sobrepeso
// - entre 30 e 40: Obesidade
// - acima de 40: Obseidade mórbida
//Obs: O IMC é calculado pela expressão peso/altura² (peso dividido pelo quadrado 
//da altura)

Console.WriteLine("Vamos medir seu IMC. Digite seu peso e sua altura.");

double peso = double.Parse(Console.ReadLine());
double altura = double.Parse(Console.ReadLine());
double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine($"Seu IMC é {imc:F}, você está abaixo do peso.");
}
else if (imc >= 18.5 && imc <= 25)
{
    Console.WriteLine($"Seu IMC é {imc:F}, você está como peso ideal.");
}
else if (imc > 25 && imc <= 30)
{
    Console.WriteLine($"Seu IMC é {imc:F}, você está com sobrepeso.");
}
else if (imc > 30 && imc <= 40)
{
    Console.WriteLine($"Seu IMC é {imc:F}, você está com obesidade.");
}
else if (imc > 40)
{
    Console.WriteLine($"Seu IMC é {imc:F}, você está com obesidade mórbida.");
}