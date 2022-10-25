/*Questao 06*/
using System;

public class categoria
{
    public static void Main()
    {
        int idade;
        Console.WriteLine ("digite idade");
        idade = int.Parse(Console.ReadLine());
        
        if ((idade >= 14) && (idade <= 17))
        {
           Console.WriteLine("juvenil B");
        }        
        if ((idade >= 11) && (idade <= 13))
        {
           Console.WriteLine("juvenil A");
        } 
        if ((idade >= 8) && (idade <= 10))
        {
           Console.WriteLine("infantil B");
        } 
        
        else if (idade >= 18) {
            Console.WriteLine ("Voce e senior");
        }
       
    }
}
