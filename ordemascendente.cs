/*Questao 02*/
using System;

public class ordem_ascendente
{
    public static void Main()
    {
        int numero1, numero2;
        
        Console.WriteLine ("digite o numero1");
        numero1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("digite o numero2");
        numero2 = int.Parse(Console.ReadLine());
        
        if (numero1 > numero2)
        {
           Console.WriteLine($"{numero2} , {numero1}");
        }     
        
          if (numero2 > numero1)
        {
           Console.WriteLine($"{numero1} , {numero2}");
        }        
    }
}
