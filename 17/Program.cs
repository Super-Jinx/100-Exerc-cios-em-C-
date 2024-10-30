// See https://aka.ms/new-console-template for more information
Console.WriteLine("Diga ai Domenique Toreto, você estava digirindo em qual velocidade? (km/h)");

double quilometrosPercorridos = double.Parse(Console.ReadLine());

double limiteQuilometros = 80.0;

double valorPorKmExcedente = 5.0;

double valorTotalAdicional = 0.0;



if (quilometrosPercorridos <= limiteQuilometros)

{
    Console.WriteLine($"Parabéns! sua velocidade de {quilometrosPercorridos}, está dentro dos limities permitidos!");
}

else
{
    double quilometrosExcedentes = quilometrosPercorridos - limiteQuilometros;
     
            valorTotalAdicional = quilometrosExcedentes * valorPorKmExcedente;

            Console.WriteLine($"Você excedeu o limite de velocidade, sua multa é de:{valorTotalAdicional:C}");
   
   

}


    
     

   
    
    

      
    
