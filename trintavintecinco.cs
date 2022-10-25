/*Questao 01*/
using System;


public class trintavintecinco

{
    
public static void Main()
    
{
        
int numero , parte1 , parte2 , operacao1 , operacao2;
        
        
Console.WriteLine ("Digite numero");
        
numero = int.Parse(Console.ReadLine());
        
        
parte1 = numero / 100;
        
parte2 = numero % 100;
        
        
operacao1 = parte1 + parte2;
        
operacao2 = operacao1 * operacao1;
        
        
if(numero == operacao2){
            
Console.WriteLine("possui a propriedade");
        
}
        
else{
            
Console.WriteLine("nao possui a propriedade");
        
}
    
}

}
