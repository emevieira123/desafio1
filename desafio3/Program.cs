using System;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {            
        int b1 = 1; int b2 = 2; int b3 = 3; int b4 = 4; //Variaveis de cada bismestre com seus respectivos valores

        //Variaveis que recebe o valor da nota de cada bismestre
        double nota1 = 8; 
        double nota2 = 8; 
        double nota3 = 8; 
        double nota4 = 10;        

        int anoLetivo = b1 +b2 + b3 + b4; //calculo dos valores das variaveis de cada bimestre

        //Calculos dos valores das notas de cada bimestre vezes (*) os valores das variaveis de cada bimestre
        double resultado1 = nota1 * b1;
        double resultado2 = nota2 * b2;
        double resultado3 = nota3 * b3;
        double resultado4 = nota4 * b4;

        double resultado = resultado1 + resultado2 + resultado3 + resultado4; // Soma dos dos resultados do calculo anterior
        
        double media = resultado / anoLetivo; //Calculo da média ponderada

        if(media < 7.5)
        { System.Console.WriteLine("A média {0}, esta baixa", media); Console.ReadLine(); }
        if(media >= 7.5 || media <= 8.5)
        { System.Console.WriteLine("A média {0}, esta ideal", media); Console.ReadLine(); }
        else{ System.Console.WriteLine("A média {0}, esta alta", media); Console.ReadLine(); }       
            
        }
    }
}
