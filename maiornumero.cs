/*Questao 04*/
using System;

public class maiornumero
{
    public static void Main()
    {
        int numero1, numero2, numero3;
        
        Console.WriteLine ("digite o numero1");
        numero1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("digite o numero2");
        numero2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("digite o numero3");
        numero3 = int.Parse(Console.ReadLine());
        
        if ((numero1 > numero2) && (numero1 > numero3))
        {
           Console.WriteLine($"{numero1} e o maior");
        }        
        if ((numero2 > numero1) && (numero2 > numero3))
        {
           Console.WriteLine($"{numero2} e o maior");
        } 
        if ((numero3 > numero1) && (numero3 > numero2))
        {
           Console.WriteLine($"{numero3} e o maior");
        } 
        
    }
}
