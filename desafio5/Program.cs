using System;

namespace desafio5
{
    class Program
    {       
        static void Main(string[] args)
        {
            int ValorEntrada = 15;
            Fibonacci fibonacci = new Fibonacci();

            for(int i = 0; i < ValorEntrada; i++)
            {
                //Recebe o valor da variavel (valorAnterior) e faz a contagem atraves da variavel (i) a quantidade de vezes informada na variavel (ValorEntrada).
                System.Console.WriteLine("{0}", fibonacci.Calculo(i)); 
            }
        }
    }

    public class Fibonacci
    {
        public int Calculo(int valor)
        {
            int valorAnterior = 0;
            int valorAtual = 1;
            int proximoValor = 0;                       

            for(int i = 0; i < valor; i++) 
            {   //Formula onde é realizado o calculo conforme a sequencia Fibonacci
                proximoValor = valorAnterior;
			    valorAnterior = valorAtual;
			    valorAtual = proximoValor + valorAtual;
                		                
            }
            return valorAnterior;            
            
        }
    }
}
