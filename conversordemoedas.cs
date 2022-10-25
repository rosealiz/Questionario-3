/*Questao 05*/
using System;


public class conversordemoedas

{
    
	public static void Main()
    
	{
    
	double reais , valordolar , valoreuro , valorlibra;
    
	int moeda;
    
        

	    Console.WriteLine ("Digite o valor em reais");
        
	    reais = double.Parse(Console.ReadLine());
        
        

	    Console.WriteLine ("Digite a moeda desejada");
        
	    moeda = int.Parse(Console.ReadLine());
        
        

	    if(moeda == 1){
        
	    valordolar = reais / 4;
        
	    Console.WriteLine($"{valordolar}");
        
	    }
        
        

	    if(moeda == 2){
        
	    valoreuro = reais / 4.75;
        
	    Console.WriteLine($"{valoreuro}");
        
	    }
        
        

	    else if(moeda == 3){
        
	    valorlibra = reais / 6.15;
        
	    Console.WriteLine($"{valorlibra}");
        
	    }
    
	}

}
