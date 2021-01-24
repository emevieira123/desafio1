using System;

namespace desafio8
{
    class Program
    {
        static void Main(string[] args)
        {                       
            System.Console.WriteLine(quadradoMaior(12, 30));
        }
        public static int quadradoMaior(int largura, int comprimento)
        {
            int result = 0, i = 0;
            
            while(largura < comprimento)
            {
                i++;
                comprimento = comprimento - largura;                              
            }
            result = comprimento;
            while(result < largura)
            {
                i++;
                largura = largura - result;
            }
            return largura;            
        }
    }
}
