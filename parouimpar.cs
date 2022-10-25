/*Questao 03*/
using System;


public class parouimpar

{
   
	public static void Main()
    
	{
    
	int numero , div;
    
        
	     Console.WriteLine ("Digite o numero");
        
	     numero = int.Parse(Console.ReadLine());
        
        
	     div = numero % 2;
        
        
             
	     if(div == 0){
        
	     Console.WriteLine("par");
        
             }
        
	     else{
        
	     Console.WriteLine("impar");
        
	     }
    
	}

}
